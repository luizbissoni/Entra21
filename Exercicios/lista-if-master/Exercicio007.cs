using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaEstruturaCondicional
{
    class Exercicio007
    {
        public Exercicio007()
        {


            Console.Write("Digite um Número: ");
            double NumeroComparacao = Convert.ToDouble(Console.ReadLine());

            if ((NumeroComparacao % 2 == 0) && (NumeroComparacao != 0))
            {
                Console.WriteLine("Número é Par");

            }
            else if (NumeroComparacao % 2 == 1)
            {
                Console.WriteLine("Número é Impar");
            }

            else if (NumeroComparacao == 0)
            {
                Console.WriteLine("Número é Neutro");
            }

            if (NumeroComparacao >= 1)
            {
                Console.WriteLine("Número Positivo");
            }
            else if (NumeroComparacao < 0)
            {
                Console.WriteLine("Número Negativo");
            }

            else if (NumeroComparacao > 10)
            {
                Console.WriteLine("Número é maior que 10");
            }

            if (NumeroComparacao < 50)
            {
                Console.WriteLine("Número é menor que 50");
            }
            else if (NumeroComparacao == 50)
            {
                Console.WriteLine("Número é igual a 50");
            }
            if (NumeroComparacao < -10)
            {
                Console.WriteLine("Número é menor que -10");
            }
            if (NumeroComparacao > 30)
            {
                Console.WriteLine("Número é maior que 30");
            }
            else if (NumeroComparacao == 30)
            {
                Console.WriteLine("Número é igual a 30");
            }
            if (NumeroComparacao != 1)
            {
                Console.WriteLine("Número é diferente de 1");
            }





        }
    }
}
