using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ListaEstruturaCondicionalWhile
{
    class Exercicio03
    {
        public Exercicio03()
        {
            Console.Write("Digite um peso: ");
            double Peso = Convert.ToDouble(Console.ReadLine());

            while ((Peso > 0) && (Peso < 300))
            {
                Console.Write("Digite um peso: ");
                Peso = Convert.ToDouble(Console.ReadLine());
            }
        }
    }
}
