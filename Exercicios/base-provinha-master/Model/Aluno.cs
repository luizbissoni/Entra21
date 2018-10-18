using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Aluno
    {
        private static int UltimoCodigo;
        private int Codigo;
        private string Nome;
        private int Idade;
        private string Turno;
        private string Turma;
        private int Matricula;
        private List<double> Notas = new List<double>();

        public Aluno()
        {
            Codigo = ++UltimoCodigo;
        }
        public int GetCodigo()
        {
            return Codigo;
        }


        public void SetNome(string nome)
        {
            if (nome.Trim().Count() < 3)
            {
                throw new Exception("Nome deve conter no minimo 3 caracteres");
            }
            if (nome.Trim().Count() > 100)
            {
                throw new Exception("nome deve conter no maximo 100 caracteres");
            }
            Nome = nome;
        }
        public string GetNome()
        {
            return Nome;
        }

        public void SetIdade(int idade)
        {
            if (idade < 4)
            {
                throw new Exception("Idade deve ser no minimo maior que 4");
            }
            if (idade > 23)
            {
                throw new Exception("Idade deve ser no menor que 23");
            }
            Idade = idade;
        }
        public int GetIdade()
        {
            return Idade;
        }

        public void SetTurno(string turno)
        {
            if (turno.Trim() == "")
            {
                throw new Exception("Turno deve conter no minimo 7 caracteres");
            }
            if (turno.Trim().ToLower() != "matutino" && turno.Trim().ToLower() != "vespertino" && turno.Trim().ToLower() != "noturno")
            {
                throw new Exception("Turno deve conter somente maturino ou vespertino ou noturno");
            }
            Turno = turno;
        }
        public string GetTurno()
        {
            return Turno;
        }

        public void SetTurma(string turma)
        {
            if (turma.Trim().Count() < 1)
            {
                throw new Exception("Turma deve conter no minimo 1 caracter");
            }
            if (turma.Trim().Count() > 3)
            {
                throw new Exception("Turma deve conter no maximo 3 caracteres");
            }
            Turma = turma;
        }
        public string GetTurma()
        {
            return Turma;
        }

        public void SetMatricula(int matricula)
        {
            if (matricula < 0)
            {
                throw new Exception("Matricula tem que ser maior que 0");
            }

            Matricula = matricula;
        }
        public int GetMatricula()
        {
            return Matricula;
        }


        public void AdicionarNota(double nota)
        {
            Notas.Add(nota);
        }
        public List<double> GetNotas()
        {
            return Notas;
        }
    }
}
