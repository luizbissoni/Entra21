using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ListaEstruturaCondicionalWhile
{
    class Exercicio15
    {
        public Exercicio15()
        {
            int Contador = 0;
            int Antecessor = 0, Sucessor = 0;
            Console.WriteLine("Digite um Número: ");
            int Numero = Convert.ToInt32(Console.ReadLine());

            while (Contador < 50)
            {
                Antecessor = (Numero % 2) - Contador++;
                Sucessor = (Numero % 1) + Contador;
                Contador = Contador + 1;

                Console.WriteLine(Antecessor);
                Console.WriteLine(Sucessor);

            }
        }
    }
}
