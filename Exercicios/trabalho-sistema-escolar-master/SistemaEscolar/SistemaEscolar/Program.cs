using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaEscolar
{
    static class Program
    {
        public static List<UsuarioSistema> cadastroUsuarioSistemaLogin = new List<UsuarioSistema>();
        public static List<Produto> produtos = new List<Produto>();
        public static List<Professor> professores = new List<Professor>();
        public static List<Aluno> alunos = new List<Aluno>();
        public static List<Alimento> alimentos = new List<Alimento>();
        public static List<Material> materiais = new List<Material>();
        public static List<Equipamento> equipamentos = new List<Equipamento>();
        public static List<Financeiro> financeiros = new List<Financeiro>();
        public static List<Funcionario> funcionarios = new List<Funcionario>();

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            new Popular();
            Application.Run(new Login());
        }
    }
}
