using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExerciciosFor
{
    class Exercicio08
    {
        public Exercicio08()
        {
            
            Console.Write("Quantidade de numeros: ");
            int quantidadeNumerosCadastro = Convert.ToInt32(Console.ReadLine());

            int[] numerosDigitado = new int[quantidadeNumerosCadastro];
            int[] numerosPar = new int[quantidadeNumerosCadastro];
            int[] numerosImpar = new int[quantidadeNumerosCadastro];

            for (int i = 0; i < quantidadeNumerosCadastro; i++)
            {
                Console.Write("Digite o numero para registro: ");
            numerosDigitado[i] = Convert.ToInt32(Console.ReadLine());
            }
            var numeroPar = "";
            var numeroImpar = "";
            var numeroDigitadoTela ="";
            string resultadoPar = "", resultadoImpar = "", resultado = "";
            for (int i = 0; i < quantidadeNumerosCadastro; i++)
            {
                if (numerosDigitado[i] %2==0)
                {
                    numerosPar[i] = numerosDigitado[i];
                    numeroPar += numerosDigitado[i];
                }
                if (numerosDigitado[i] % 2 != 0)
                {
                    numerosImpar[i] = numerosDigitado[i];
                    numeroImpar += numerosDigitado[i];
                }
                resultadoPar = string.Join(",", numerosPar);
                resultadoImpar = string.Join(",", numerosImpar);
                resultado = string.Join(",", numerosDigitado);
            numeroDigitadoTela += numerosDigitado[i];
            }
            Console.WriteLine("Numeros Digitados: "+resultado);
            Console.WriteLine("Par: "+resultadoPar);
            Console.WriteLine("Impar: "+resultadoImpar);

        }
    }
}
