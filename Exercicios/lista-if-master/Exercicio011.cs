using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaEstruturaCondicional
{
    class Exercicio011
    {
        public Exercicio011()
        {
            Console.Write("Nota 1: ");
            double Nota1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nota 2: ");
            double Nota2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nota 3: ");
            double Nota3 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nota 4: ");
            double Nota4 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nota 5: ");
            double Nota5 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\n");

            double Media = (Nota1 + Nota2 + Nota3 + Nota4 + Nota5) / 5;
            Console.WriteLine(string.Format("Media: {0}",Media));

            if (Media <= 5.99)
            {
                Console.WriteLine("Reprovado!");
            }
            else if (Media <= 6.00)
            {
                Console.WriteLine("Recuperação!");
            }
            else if (Media >= 7.99)
            {
                Console.WriteLine("Aprovado!");
            }

        }

    }
}
