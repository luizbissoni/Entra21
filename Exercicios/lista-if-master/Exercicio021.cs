using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaEstruturaCondicional
{
    class Exercicio021
    {
        public Exercicio021()
        {
            Console.Write("Informe um número: ");
            double TrianguloA = Convert.ToDouble(Console.ReadLine());

            Console.Write("Informe o segundo número: ");
            double TrianguloB = Convert.ToDouble(Console.ReadLine());

            Console.Write("Informe o Terceiro número: ");
            double TrianguloC = Convert.ToDouble(Console.ReadLine());

            if ((TrianguloA == TrianguloB) && (TrianguloA == TrianguloC))
            {
                Console.WriteLine("Triângulo Equilátero");
            }
            else if ((TrianguloA == TrianguloB) && (TrianguloA != TrianguloC))
            {
                Console.WriteLine("Triângulo Isósceles");
            }
            else if ((TrianguloA != TrianguloB) && (TrianguloA != TrianguloC))
            {
                Console.WriteLine("Triângulo Escaleno");
            }
        }
    }
}
