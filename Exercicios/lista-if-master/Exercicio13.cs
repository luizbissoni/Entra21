using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicios02
{
    class Exercicio13
    {
        static void Main13(string[] args)
        {
            Console.Write("Primero Número: ");
            double Numero1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Segundo Número: ");
            double Numero2 = Convert.ToDouble(Console.ReadLine());

            if (Numero1 < Numero2)
            {
                Console.WriteLine(Numero1 + " é menor que "+ Numero2);

            }
            else if  (Numero2 < Numero1)
            {
                Console.WriteLine(Numero2 + " é maior que "+Numero1);
            }
        }
    }
}
