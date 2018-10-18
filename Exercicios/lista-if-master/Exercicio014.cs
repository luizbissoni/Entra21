using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaEstruturaCondicional
{
    class Exercicio014
    {
        public Exercicio014()
        {
            Console.Write("Primeiro número: ");
            int Numero1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Segundo número: ");
            int Numero2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Terceiro número: ");
            int Numero3 = Convert.ToInt32(Console.ReadLine());

            int Crecente1 = 0;
            int Crecente2 = 0;
            int Crecente3 = 0;

            if ((Numero3 > Numero1) && (Numero3 > Numero2))
            {
                Crecente1 = Numero3;
                if (Numero1 > Numero2)
                {
                    Crecente2 = Numero1;
                    Crecente3 = Numero2;
                }
                else
                {
                    Crecente2 = Numero2;
                    Crecente3 = Numero1;
                }
            }
            else if ((Numero3 > Numero1) && (Numero3 < Numero2))
            {
                Crecente1 = Numero2;
                Crecente2 = Numero3;
                Crecente3 = Numero1;
            }
            else
            {
                Crecente3 = Numero3;
            }

            Console.WriteLine(string.Format("\n{0} \n{1} \n{2}", Crecente1, Crecente2, Crecente3));


        }
    }
}
