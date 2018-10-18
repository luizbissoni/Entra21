using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace SistemaEscolar
{
    public class Tools
    {
        public static bool IsPasswordStrong(string password)
        {
            int tamanhoMinimo = 8;
            int tamanhoMinusculo = 1;
            int tamanhoMaiusculo = 1;
            int tamanhoNumeros = 1;
            int tamanhoCaracteresEspeciais = 1;

            // Definição de letras minusculas
            Regex regTamanhoMinusculo = new Regex("[a-z]");

            // Definição de letras minusculas
            Regex regTamanhoMaiusculo = new Regex("[A-Z]");

            // Definição de letras minusculas
            Regex regTamanhoNumeros = new Regex("[0-9]");

            // Definição de letras minusculas
            Regex regCaracteresEspeciais = new Regex("[^a-zA-Z0-9]");

            // Verificando tamanho minimo
            if (password.Length < tamanhoMinimo) return false;

            // Verificando caracteres minusculos
            if (regTamanhoMinusculo.Matches(password).Count < tamanhoMinusculo) return false;

            // Verificando caracteres maiusculos
            if (regTamanhoMaiusculo.Matches(password).Count < tamanhoMaiusculo) return false;

            // Verificando numeros
            if (regTamanhoNumeros.Matches(password).Count < tamanhoNumeros) return false;

            // Verificando os diferentes
            if (regCaracteresEspeciais.Matches(password).Count < tamanhoCaracteresEspeciais) return false;

            return true;
        } //Verifica a Força da senha

        public static bool ValidarCep(string cep)
        {
            cep = cep.Replace("-", "");

            Regex Rgx = new Regex(@"^\d{8}$");

            if (!Rgx.IsMatch(cep))

                return false;

            else

                return true;
        }

        //public static bool ValidarTelefone(string fone)
        //{
        //    fone = fone.Replace("()", "").Replace("-", "");
        //    Regex rgx = new Regex("^(?:(?([0-9]{2}))?[-. ]?)?([0-9]{4,5})[-. ]?([0-9]{4})$");

        //    if (!rgx.IsMatch(fone))
            
        //        return false;
            
        //    else
            
        //        return true;
            
        //} //Validar telefone fixo ou movel 

        // Inicio do método utilizado para validar CPF
        public static bool ValidaCPF(string cpf)
        {

            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };

            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };

            string tempCpf;

            string digito;

            int soma;

            int resto;

            cpf = cpf.Trim();

            cpf = cpf.Replace(".", "").Replace(",", "").Replace("-","");

            if (cpf.Length != 11)

                return false;

            tempCpf = cpf.Substring(0, 9);

            soma = 0;

            for (int i = 0; i < 9; i++)

                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];

            resto = soma % 11;

            if (resto < 2)

                resto = 0;

            else

                resto = 11 - resto;

            digito = resto.ToString();

            tempCpf = tempCpf + digito;

            soma = 0;

            for (int i = 0; i < 10; i++)

                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];

            resto = soma % 11;

            if (resto < 2)

                resto = 0;

            else

                resto = 11 - resto;

            digito = digito + resto.ToString();

            return cpf.EndsWith(digito);

        }
        // Fim do método de validar CPF

        //Inicio do método para Validar RG
        public static bool ValidaRG(string rg)
        {
            //Elimina da string os traços, pontos e virgulas,
           // rg = rg.Replace(".", "");

            //Verifica se o tamanho da string é 9
            if (rg.Length == 9)
            {
                int[] n = new int[9];

                try
                {
                    n[0] = Convert.ToInt32(rg.Substring(0, 1));
                    n[1] = Convert.ToInt32(rg.Substring(1, 1));
                    n[2] = Convert.ToInt32(rg.Substring(2, 1));
                    n[3] = Convert.ToInt32(rg.Substring(3, 1));
                    n[4] = Convert.ToInt32(rg.Substring(4, 1));
                    n[5] = Convert.ToInt32(rg.Substring(5, 1));
                    n[6] = Convert.ToInt32(rg.Substring(6, 1));
                    n[7] = Convert.ToInt32(rg.Substring(7, 1));
                    if (rg.Substring(8, 1).Equals("x") || rg.Substring(8, 1).Equals("X"))
                    {
                        n[8] = 10;
                    }
                    else
                    {
                        n[8] = Convert.ToInt32(rg.Substring(8, 1));
                    }
                }
                catch (Exception)
                {
                    return false;
                }
                //obtém cada um dos caracteres do rg

                //Aplica a regra de validação do RG, multiplicando cada digito por valores pré-determinados
                n[0] *= 2;
                n[1] *= 3;
                n[2] *= 4;
                n[3] *= 5;
                n[4] *= 6;
                n[5] *= 7;
                n[6] *= 8;
                n[7] *= 9;
                n[8] *= 100;

                //Valida o RG
                int somaFinal = n[0] + n[1] + n[2] + n[3] + n[4] + n[5] + n[6] + n[7] + n[8];
                if ((somaFinal % 11) == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        //Fim do método Validar RG
    }



}

