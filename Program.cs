using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using TextCopy;

class Program
{
    
    static List<string> senhasSalvas = new List<string>();

    static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("=== Gerador de senha off  ===");
            Console.WriteLine("1. Gerar nova senha");
            Console.WriteLine("2. Ver e Copiar senhas geradas (temporário)");
            Console.WriteLine("3. Sair");
            Console.Write("Escolha uma opção: ");
            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    GerarNovaSenha();
                    break;
                case "2":
                    VerECopiarSenhasGeradas();
                    break;
                case "3":
                    Console.WriteLine("Saindo...");
                    
                    return;
                default:
                    Console.WriteLine("Opção inválida. Pressione ENTER para continuar...");
                    Console.ReadLine();
                    break;
            }
        }
    }

    static void GerarNovaSenha()
    {
        Console.Clear();
        Console.WriteLine("=== Gerar nova senha ===");

        Console.Write("Comprimento da senha (mínimo 8): ");
        if (!int.TryParse(Console.ReadLine(), out int comprimento) || comprimento < 8)
        {
            Console.WriteLine("Erro: curta demais.");
            Console.ReadLine();
            return;
        }

        Console.Write("Incluir letras maiúsculas? (s/n): ");
        bool incluirMaiusculas = Console.ReadLine().Trim().ToLower() == "s";

        Console.Write("Incluir números? (s/n): ");
        bool incluirNumeros = Console.ReadLine().Trim().ToLower() == "s";

        Console.Write("Incluir caracteres especiais? (s/n): ");
        bool incluirEspeciais = Console.ReadLine().Trim().ToLower() == "s";

        try
        {
            string caracteresPossiveis = "abcdefghijklmnopqrstuvwxyz";
            if (incluirMaiusculas) caracteresPossiveis += "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            if (incluirNumeros) caracteresPossiveis += "0123456789";
            if (incluirEspeciais) caracteresPossiveis += "!@#$%^&*()-_=+[]{}|;:'\",.<>?/";

            if (caracteresPossiveis.Length == 0)
            {
                Console.WriteLine("Erro: selecione ao menos um tipo de caractere para gerar a senha.");
                Console.ReadLine();
                return;
            }

            string novaSenhaGerada = GerarSenhaSegura(comprimento, caracteresPossiveis);
            Console.WriteLine($"\nSenha gerada: {novaSenhaGerada}");

            senhasSalvas.Add(novaSenhaGerada); 

            Console.WriteLine("Senha gerada e adicionada à lista temporária! Pressione ENTER para copiar para a área de transferência...");
            Console.ReadLine();
            ClipboardService.SetText(novaSenhaGerada);
            Console.WriteLine("Senha copiada para a área de transferência.");

        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Erro: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro ao gerar senha: {ex.Message}");
        }

        Console.WriteLine("\nPressione ENTER para voltar ao menu...");
        Console.ReadLine();
    }

    static void VerECopiarSenhasGeradas()
    {
        Console.Clear();
        Console.WriteLine("=== Senhas Geradas (Temporário) ===");

        if (senhasSalvas.Count == 0)
        {
            Console.WriteLine("Nenhuma senha gerada ainda nesta sessão.");
        }
        else
        {
            for (int i = 0; i < senhasSalvas.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {senhasSalvas[i]}");
            }

            Console.Write("\nDigite o número da senha que deseja copiar ou 0 para voltar: ");
            if (int.TryParse(Console.ReadLine(), out int choice) && choice > 0 && choice <= senhasSalvas.Count)
            {
                string senhaParaCopiar = senhasSalvas[choice - 1];
                try
                {
                    ClipboardService.SetText(senhaParaCopiar);
                    Console.WriteLine($"Senha '{senhaParaCopiar}' copiada para a área de transferência!");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Erro ao copiar a senha: {ex.Message}");
                }
            }
            else if (choice != 0)
            {
                Console.WriteLine("Opção inválida.");
            }
        }

        Console.WriteLine("\nPressione ENTER para voltar ao menu...");
        Console.ReadLine();
    }

    
    static string GerarSenhaSegura(int comprimento, string caracteresPossiveis)
    {
        StringBuilder senha = new StringBuilder(comprimento);
        using (var rng = RandomNumberGenerator.Create())
        {
            byte[] dadosAleatorios = new byte[comprimento];
            for (int i = 0; i < comprimento; i++)
            {
                rng.GetBytes(dadosAleatorios.AsSpan(i, 1)); 
                int indice = dadosAleatorios[i] % caracteresPossiveis.Length;
                senha.Append(caracteresPossiveis[indice]);
            }
        }
        return senha.ToString();
    }
}