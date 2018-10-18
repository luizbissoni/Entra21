using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicios02
{
    class Exercicio7
    {
        static void Main7(string[] args)
        {
            //Numero

            //Console.Write("Digite um Número: ");
            double NumeroComparacao = Convert.ToDouble(Console.ReadLine());

            if (NumeroComparacao % 2 == 0)
            {
                Console.WriteLine("Número é Par");

            }
            else if (NumeroComparacao % 2 == 1)
            {
                Console.WriteLine("Número é Impar");
            }





            

        }
    }
}
