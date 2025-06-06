Gerador e armazenador de senhas offline

Tive a ideia de fazer esse pequeno projeto após usar o NordPass por um tempo e pensei "E se fizesse algo semelhante?!", lógico que não ficou na mesma proporção. Alias, é um projeto que roda no console. Feito de forma simples em C# com o intuito de criar senhas fortes de maneira rápida e prática. Também guarda temporariamente as senhas criadas durante o uso.

O que tem implementado?

Geração de senhas com o tamanho que você quiser (mínimo de 8 caracteres);
Escolher se quer usar letras maiúsculas, números e símbolos especiais;
Copiar a senha direto para a área de transferência com um clique (usando a biblioteca TextCopy);

Ver as senhas geradas enquanto o programa estiver aberto.

Tecnologias usadas:

C# (.NET);

System.Security.Cryptography (para garantir senhas seguras);

TextCopy (para copiar a senha sem complicação).

Como seria o uso (até o momento):

Abra o projeto e execute no seu terminal ou IDE favorita;
Escolha no menu se quer gerar uma senha nova ou ver as que já criou na sessão;
As senhas são guardadas só enquanto o programa estiver rodando. Ao fechar, tudo é apagado.

Algumas observações:

O foco aqui é praticidade e segurança local;

As senhas não são salvas em nenhum lugar além da memória do programa.
É uma base para montar algo maior depois, pensei em um gerenciador com banco de dados ou integração com autenticação.

Se quiser contribuir ou dar sugestões, fique à vontade!
