using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploFor
{
    class Exemplo01
    {
        public Exemplo01()
        {
            int i = 0;
            for (i = 0; i <=1000000; i++)
            {
                Console.WriteLine(i); //conta ate chegar a 1000000
            }
            Console.WriteLine(i); //imprime o resultado na hora
        }
    }
}
