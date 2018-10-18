using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaEstruturaCondicional
{
    class Exercicio006
    {
        public Exercicio006()
        {
            Console.Write("Digite um Número: ");
            int NumeroDiferente = Convert.ToInt32(Console.ReadLine());

            if (NumeroDiferente != 1)
            {
                Console.WriteLine(string.Format("O Número {0} é Diferente de 1.",NumeroDiferente)); 
            }
        }
    }
}
