using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ListaEstruturaCondicionalWhile
{
    class Exercicio13
    {
        public Exercicio13()
        {
            int Contador = 0;
            Console.Write("Digite um número: ");
            int Tabuada = Convert.ToInt32(Console.ReadLine());

            while (Contador < 1000)
            {
                Contador = Contador + 1;
                int TabuadaVezes = Tabuada * Contador;
                Console.WriteLine(Tabuada + " x " + Contador + " = " + TabuadaVezes);
            }

        }
    }
}
