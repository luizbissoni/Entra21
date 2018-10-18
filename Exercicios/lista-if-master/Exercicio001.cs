using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaEstruturaCondicional
{
    class Exercicio001
    {
        public Exercicio001()
        {
            Console.Write("Digite um número: ");
            int Numero01 = Convert.ToInt32(Console.ReadLine());

            if (Numero01 >=1)
            {
                Console.WriteLine(string.Format("O Número {0} é Positivo. ",Numero01));

            }
            else 
            {
                Console.WriteLine(string.Format("O Número {0} é Negativo. ",Numero01));
            }

            

            

        }
    }
}
