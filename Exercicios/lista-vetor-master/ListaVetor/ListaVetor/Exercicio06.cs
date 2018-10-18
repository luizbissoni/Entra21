using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ListaVetor
{
    class Exercicio06
    {
        public Exercicio06()
        {
            int maiorIdade = 0;

            int[] idade = new int[9];

            Console.Write("Idade 1: ");
            idade[0] = Convert.ToInt32(Console.ReadLine());

            Console.Write("Idade 2: ");
            idade[1] = Convert.ToInt32(Console.ReadLine());

            Console.Write("Idade 3: ");
            idade[2] = Convert.ToInt32(Console.ReadLine());

            Console.Write("Idade 4: ");
            idade[3] = Convert.ToInt32(Console.ReadLine());

            Console.Write("Idade 5: ");
            idade[4] = Convert.ToInt32(Console.ReadLine());

            Console.Write("Idade 6: ");
            idade[5] = Convert.ToInt32(Console.ReadLine());

            Console.Write("Idade 7: ");
            idade[6] = Convert.ToInt32(Console.ReadLine());

            Console.Write("Idade 8: ");
            idade[7] = Convert.ToInt32(Console.ReadLine());

            Console.Write("Idade 9: ");
            idade[8] = Convert.ToInt32(Console.ReadLine());

            if (idade[0] > maiorIdade)
            {
                maiorIdade = idade[0];
            }
            if (idade[1] > maiorIdade)
            {
                maiorIdade = idade[1];
            }
            if (idade[2] > maiorIdade)
            {
                maiorIdade = idade[2];
            }
            if (idade[3] > maiorIdade)
            {
                maiorIdade = idade[3];
            }
            if (idade[4] > maiorIdade)
            {
                maiorIdade = idade[4];
            }
            if (idade[5] > maiorIdade)
            {
                maiorIdade = idade[5];
            }
            if (idade[6] > maiorIdade)
            {
                maiorIdade = idade[6];
            }
            if (idade[7] > maiorIdade)
            {
                maiorIdade = idade[7];
            }
            if (idade[8] > maiorIdade)
            {
                maiorIdade = idade[8];
            }
            Console.WriteLine(string.Format("{0} Maior idade: ", maiorIdade));
        }
    }
}
