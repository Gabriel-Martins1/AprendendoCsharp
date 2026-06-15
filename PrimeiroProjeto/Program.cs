using System;
using System.Windows.Forms;
using ControleLocacao.Data;

namespace ControleLocacao
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Database.Initialize(); // cria o banco e as tabelas na primeira vez
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}