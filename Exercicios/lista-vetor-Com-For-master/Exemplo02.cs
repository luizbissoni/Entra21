using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExemploVetorComFor
{
    class Exemplo02
    {
        public Exemplo02()
        {
            int[] levelLOL = new int[3];
            for (int i = 0; i < levelLOL.Length; i++)
            {
                Console.Write("Digite o seu Level no LOL: ");
                levelLOL[i] = Convert.ToInt32(Console.ReadLine());
            }
            int somaLevels = 0;
            for (int i = 0; i < levelLOL.Length; i++)
            {
                somaLevels = levelLOL[i] + somaLevels;
            }
            double mediaLevel = somaLevels / levelLOL.Length;
            Console.WriteLine("Média: " + mediaLevel);
        }
    }
}
