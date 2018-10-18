using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaEstruturaCondicional
{
    class Exercicio002
    {
        public Exercicio002()
        {
            Console.Write("Infomer um Número: ");
            int NumeroNegativo = Convert.ToInt32(Console.ReadLine());

            if (NumeroNegativo <= 1)
            {
                Console.Write(string.Format("O Número {0} è Negativo",NumeroNegativo));
            }

            else
            {
                Console.Write(string.Format("O Número {0} é Positivo",NumeroNegativo));
            }

        }
    }
}
