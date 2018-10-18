using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExerciciosFor
{
    class Exercicio11
    {
        public Exercicio11()
        {

            string[] nomes = new string[5];
            var nomesApresentar = "";
            string exemplo = "";
            for (int i = 0; i < nomes.Length; i++)
            {
                Console.Write("Nomes para registro: ");
                nomes[i] = Console.ReadLine();

                nomesApresentar += nomes[i];
                exemplo = string.Join(",", nomes);
            }
            Console.WriteLine(exemplo);




        }

    }
}
