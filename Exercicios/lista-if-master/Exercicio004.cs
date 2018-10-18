using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaEstruturaCondicional
{
    class Exercicio004
    {
        public Exercicio004()
        {
            Console.WriteLine("Digite um Número: ");
            int NumeroPar = Convert.ToInt32(Console.ReadLine());

            if (NumeroPar % 2 == 0 )
            {
                Console.WriteLine("Número Par");
            }
        }
    }
}
