using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaEstruturaCondicional
{
    class Exercicio005
    {
        public Exercicio005()
        {
            Console.Write("Digite um Número: ");
            int Impar = Convert.ToInt32(Console.ReadLine());

            if (Impar % 2 == 1)
            {
                Console.WriteLine(string.Format("O Número: {0} é Impar. ",Impar));
            }
        }
    }
}
