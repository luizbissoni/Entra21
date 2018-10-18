using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaEstruturaCondicional
{
    class Exercicio013
    {
        public Exercicio013()
        {
            Console.Write("Primero Número: ");
            double Numero1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Segundo Número: ");
            double Numero2 = Convert.ToDouble(Console.ReadLine());

            if (Numero1 < Numero2)
            {
                Console.WriteLine(string.Format("{0} é menor que {1}",Numero1,Numero2));

            }
            else if (Numero2 < Numero1)
            {
                Console.WriteLine(string.Format(Numero2 + "{0} é maior que {1}",Numero2,Numero1));
            }
        }
    }
}
