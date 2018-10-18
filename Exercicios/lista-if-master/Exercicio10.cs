using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicios02
{
    class Exercicio10
    {
        static void Main(string[] args)
        {
            Console.Write("Primeiro Número: ");
            double LadoA = Convert.ToDouble(Console.ReadLine());

            Console.Write("Segundo Número: ");
            double LadoB = Convert.ToDouble(Console.ReadLine());

            Console.Write("Terceiro Número: ");
            double LadoC = Convert.ToDouble(Console.ReadLine());

            Console.Write("Quarto Número: ");
            double LadoD = Convert.ToDouble(Console.ReadLine());

            if ((LadoA == LadoB) && (LadoC == LadoD))
            {
                Console.WriteLine("Retângulo");
            }
            if ((LadoA == LadoD)&&(LadoA == LadoC))
            {
                Console.WriteLine("Não é um Retângulo");
            }
        }
    }
}
