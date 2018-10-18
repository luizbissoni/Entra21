using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicios02
{
    class Exercicio02
    {
        static void Main2(string []args)
        {
            Console.Write("Infomer um Número: ");
            int NumeroNegativo = Convert.ToInt32(Console.ReadLine());

            if (NumeroNegativo <= 1)
            {
                Console.Write("O Número " + NumeroNegativo + " è Negativo"+"\n");
            }

            else
            {
                Console.Write("O Número " + NumeroNegativo + " é Positivo"+"\n");
            }

        }
    }
}
