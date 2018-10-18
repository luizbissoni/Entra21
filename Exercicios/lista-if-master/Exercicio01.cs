using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicios02
{
    class Exercicio01
    {
        static void Main1(string[] args)
        {
            Console.Write("Digite um número: ");
            int Numero01 = Convert.ToInt32(Console.ReadLine());

            if (Numero01 >=1)
            {
                Console.Write("O Número "+Numero01 + " é Positivo. "+"\n");

            }
            else 
            {
                Console.Write("O Número é "+ Numero01 + " é Negativo."+"\n");
            }

            

            

        }
    }
}
