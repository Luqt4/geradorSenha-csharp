using System;
using System.Windows.Forms;
using GeradorSenha;

namespace GeradorDeSenhas
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}
