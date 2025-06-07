using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace GeradorSenha
{
    public partial class Form1 : Form
    {
        private readonly string minusculas = "abcdefghijklmnopqrstuvwxyz";
        private readonly string maiusculas = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private readonly string numeros = "0123456789";
        private readonly string especiais = "!@#$%^&*()-_=+[]{}/|;:<>?/";

        private List<string> senhasGeradas = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtComprimento.Text, out int comprimento) || comprimento < 8)
            {
                MessageBox.Show("O comprimento deve ser um número maior ou igual a 8.");
                return;
            }

            if (!chkMaiusculas.Checked && !chkNumeros.Checked && !chkEspeciais.Checked)
            {
                MessageBox.Show("Selecione ao menos uma opção: letras maiúsculas, números ou caracteres especiais.");
                return;
            }

            string senha = GerarSenha(comprimento);
            senhasGeradas.Add(senha);
            lstSenhas.Items.Add(senha);
            Clipboard.SetText(senha);
            MessageBox.Show("Senha gerada e copiada para a área de transferência!");
        }

        private void btnCopiarSelecionada_Click(object sender, EventArgs e)
        {
            if (lstSenhas.SelectedItem != null)
            {
                Clipboard.SetText(lstSenhas.SelectedItem.ToString());
                MessageBox.Show("Senha copiada para a área de transferência!");
            }
            else
            {
                MessageBox.Show("Selecione uma senha na lista.");
            }
        }

        private string GerarSenha(int comprimento)
        {
            Random rng = new Random();
            List<char> obrigatorios = new List<char>();
            List<char> senhaRestante = new List<char>();

            char primeiraLetra = chkMaiusculas.Checked
                ? maiusculas[rng.Next(maiusculas.Length)]
                : minusculas[rng.Next(minusculas.Length)];

            if (chkNumeros.Checked)
                obrigatorios.Add(numeros[rng.Next(numeros.Length)]);

            if (chkEspeciais.Checked)
                obrigatorios.Add(especiais[rng.Next(especiais.Length)]);

            if (!chkMaiusculas.Checked)
                obrigatorios.Add(minusculas[rng.Next(minusculas.Length)]);

            string pool = minusculas;
            if (chkMaiusculas.Checked) pool += maiusculas;
            if (chkNumeros.Checked) pool += numeros;
            if (chkEspeciais.Checked) pool += especiais;

            while (1 + obrigatorios.Count + senhaRestante.Count < comprimento)
            {
                senhaRestante.Add(pool[rng.Next(pool.Length)]);
            }

            var corpo = obrigatorios.Concat(senhaRestante).OrderBy(_ => rng.Next()).ToList();

            corpo.Insert(0, primeiraLetra); 

            return new string(corpo.ToArray());
        }
    }
}
