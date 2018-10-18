using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExemploVetorComFor
{
    class Exemplo01
    {
        public Exemplo01()
        {
            //armazenar as informçoes no vetor

            string[] nomes = new string[5];
            for (int i = 0; i < nomes.Length; i++)
            {
                Console.Write("Digite um nome: ");
                nomes[i] = Console.ReadLine();
            }
            Console.Clear();

            //Apresenta as infromaçoes do vetor

            Console.WriteLine("Pessoas cadastradas: ");
            for (int i = 0; i < nomes.Length; i++)
            {
                Console.WriteLine("Nomes: " + nomes[i]);
            }
        }
    }
}
