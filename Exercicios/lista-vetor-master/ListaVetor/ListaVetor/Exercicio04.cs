
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ListaVetor
{
    class Exercicio04
    {
        public Exercicio04()
        {
            double[] Notas = new double[4];
            string[] Nomes = new string[1];

            Console.Write("Nome: ");
            Nomes[0] = Console.ReadLine();
            Console.Write("Nota 1: ");
            Notas[0] = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nota 2: ");
            Notas[1] = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nota 3: ");
            Notas[2] = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nota 4: ");
            Notas[3] = Convert.ToDouble(Console.ReadLine());

            double medianotas = (Notas[0] + Notas[1] + Notas[2] + Notas[3]) / 4;
            Console.WriteLine(string.Format("{0} com a media {1}",Nomes[0],medianotas));

        }
    }
}
