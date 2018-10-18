using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExemploFor
{
    class Exemplo03
    {
        public Exemplo03()
        {


            for (int i = 0; i < 11; i++)
            {
                for (int j = 0; j < 11; j++)
                {
                    
                    Console.WriteLine(+j + " x " + i + " = " + j * i);
                }
            }
        }
    }
}
