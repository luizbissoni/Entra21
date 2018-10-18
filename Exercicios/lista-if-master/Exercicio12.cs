using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicios02
{
    class Exercicio12
    {
        static void Main12(string[] args)
        {
            Console.Write("Primeiro Número: ");
            double Numero1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Segundo Número: ");
            double Numero2 = Convert.ToDouble(Console.ReadLine());

            if (Numero1 > Numero2)
            {
                Console.WriteLine(Numero1 + " é maior que " + Numero2);
            }
            else if (Numero2 > Numero1)
            {
                Console.WriteLine(Numero2 + " é maior que " + Numero1);
            }


        }
    }
}
