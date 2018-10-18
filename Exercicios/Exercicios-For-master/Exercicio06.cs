using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExerciciosFor
{
    class Exercicio06
    {
        public Exercicio06()
        {
            Random aleatorio = new Random();

            int[] numero = new int[10];

            for (int i = 0; i < numero.Length; i++)
            {
                numero[i] = aleatorio.Next(-15, 150);
            }

            int quantidadePar = 0, quantidadeImpar = 0, quantidadeNegativo = 0, quantidadePositivo = 0, quantidadeNeutros = 0;
            double somaTotal = 0;
            double mediaTotal = 0;

            for (int i = 0; i < numero.Length; i++)
            {
                if (numero[i] % 2 == 0)
                {
                    quantidadePar++;
                }
                if (numero[i] % 2 == 1)
                {
                    quantidadeImpar++;
                }
                if (numero[i] < 0)
                {
                    quantidadeNegativo++;
                }
                if (numero[i] == 0)
                {
                    quantidadeNeutros++;
                }
                if (numero[i] > 0)
                {
                    quantidadePositivo++;
                }

                Console.WriteLine(numero[i]);
                somaTotal = somaTotal + numero[i];
                mediaTotal = somaTotal / numero.Length;

            }
            Console.WriteLine();
            Console.WriteLine("Media: " + mediaTotal);
            Console.WriteLine("Soma: " + somaTotal);
            Console.WriteLine(string.Format("{0} Par, {1} Impar, {2}Negativos, {3}Neutros, {4}Positivos", quantidadePar, quantidadeImpar, quantidadeNegativo, quantidadeNeutros, quantidadePositivo));



        }
    }
}
