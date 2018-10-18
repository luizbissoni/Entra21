using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ListaEstruturaCondicionalWhile
{
    class Exercicio14
    {
        public Exercicio14()
        {
            int Contador = 0;

            Console.Write("Digite um número: ");
            int Numero = Convert.ToInt32(Console.ReadLine());

            while (Contador < 10)
            {
                Contador = Contador + 1;
                int MenosNumero =  Numero * Numero - Contador;
                Console.WriteLine(MenosNumero);
            }

        }
    }
}
