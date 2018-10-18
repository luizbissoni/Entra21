using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicios02
{
    class Exercicio05
    {
        static void Main5(string[] args)
        {
            Console.Write("Digite um Número: ");
            int Impar = Convert.ToInt32(Console.ReadLine());

            if (Impar % 2 == 1)
            {
                Console.WriteLine("O Número: "+ Impar + " é Impar. ");
            }
        }
    }
}
