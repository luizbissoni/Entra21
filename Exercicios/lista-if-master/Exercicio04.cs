using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicios02
{
    class Exercicio04
    {
        static void Main4(string[] args)
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
