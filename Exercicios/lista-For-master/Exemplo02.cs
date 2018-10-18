using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExemploFor
{
    class Exemplo02
    {
        public Exemplo02()
        {
            Console.Write("Digite um numero: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            for (int i = -100000; i < 10000; i++)
            {
                int Vezes = i * numero;
                Console.WriteLine(numero + " X " + i + " = " + Vezes);
            }

        }
    }
}
