using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicios02
{
    class Exercicio9
    {
        static void Main9(string[] args)
        {
            Console.Write("Primeiro Número: ");
            double LadoA = Convert.ToDouble(Console.ReadLine());

            Console.Write("Segundo Número: ");
            double LadoB = Convert.ToDouble(Console.ReadLine());

            Console.Write("Terceiro Número: ");
            double LadoC = Convert.ToDouble(Console.ReadLine());

            Console.Write("Quarto Número: ");
            double LadoD = Convert.ToDouble(Console.ReadLine());

            if ((LadoA == LadoB) && (LadoA == LadoC) && (LadoA == LadoD))
            {
                Console.WriteLine("É Um Quadrado");
            }
            else
            {
                Console.WriteLine("Não é um Quadrado");
            }
        }
    }
}
