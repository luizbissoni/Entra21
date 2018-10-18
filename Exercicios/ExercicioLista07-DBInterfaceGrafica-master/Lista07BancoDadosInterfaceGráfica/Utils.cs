using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista07BancoDadosInterfaceGráfica
{
    public static class Utils
    {
        public static double MediaNotas(double nota_1, double nota_2, double nota_3)
        {

            double mediaNotas = (nota_1 + nota_2 + nota_3) / 3;

            return mediaNotas;
        }

        public static string SituacaoMedia(double mediaNotas)
        {

            if (mediaNotas >= 7)
            {
                string SituacaoMedia = "Aprovado";
                return SituacaoMedia;
            }
            else if (mediaNotas < 7 && mediaNotas >= 5)
            {
                string SituacaoMedia = "Recuperação";
                return SituacaoMedia;
            }
            else
            {
                string SituacaoMedia = "Reprovado";
                return SituacaoMedia;
            }


        }

        public static string Frequencia(int frequencia)
        {
            string aprovado = string.Empty;           

            if (frequencia < 65)
            {
                aprovado = "Reprovado por frequencia.";
                return aprovado;
            }
            else
            {
                aprovado = "Aprovado";
                return aprovado;
            }
        }

        public static string ValidarNome(string nomes)
        {
            string exception = string.Empty;

            if (string.IsNullOrEmpty(nomes))
            {
                exception = "Nome deve ser preenchido corretamente.";
            }

            else if (nomes.Length < 5)
            {
                exception = "Nome não deve ser menor que 5 caracteres.";
            }
            else if (nomes.Length > 30)
            {
                exception = "Nome não deve ser maior que 30 caracteres.";
            }
            return exception;
        }

        public static string ValidarNota(double notas)
        {
            string mensagemException = string.Empty;
            
            //double ? notaNull = notas;

            if (string.IsNullOrEmpty(Convert.ToString(notas)))
            {
                mensagemException = "Nota deve ser preenchida.";
            }
            else if (notas < 0)
            {
                mensagemException = "Nota não deve ser menor que zero.";
            }
            else if (notas > 10)
            {
                mensagemException = "Nota não deve ser maior que 10";
            }

            return mensagemException;
        }

        public static string ValidarFrequencia(int frequencia)
        {
            string mensagemExceptio = string.Empty;
            int? frequenciaNull = frequencia;

            if (!frequenciaNull.HasValue)
            {
                mensagemExceptio = "Frequencia deve ser preenchida.";
            }

            return mensagemExceptio;
        }

        public static string ValidarMatricula(Int16 matricula)
        {
            string mensagemExecption = string.Empty;
            //Int16? matriculaNull = matricula;

            if (string.IsNullOrEmpty(Convert.ToString(matricula)))
            {
                mensagemExecption = "Matricula deve ser preenchida";
            }
            else if (matricula > 255)
            {
                mensagemExecption = "Matricula não deve ser maior que 255.";
            }
            else if (matricula <= 0)
            {
                mensagemExecption = "Matricula não deve ser zero e/ou menor que zero.";
            }


            return mensagemExecption;
        }

        public static bool Exeption(string exception) //recebe as validaçoes dos metodos que retornam string, se retornar algo esse metodo ira retornar true
        {
            if (!string.IsNullOrEmpty(exception))
                return true;

            return false;
        }


    }
}
