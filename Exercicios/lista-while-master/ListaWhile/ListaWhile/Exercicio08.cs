using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ListaEstruturaCondicionalWhile
{
    class Exercicio08
    {
        public Exercicio08()
        {
            int contador = 0;
            string CaracterDigitou = "";
                Console.Write("Caracteres: ");
                string Caracter = Console.ReadLine();

            while (contador < 10)
            {
                CaracterDigitou = CaracterDigitou + Caracter;

                contador = contador + 1;
            }
                Console.WriteLine("Caracter: " + CaracterDigitou);




        }
    }
}
