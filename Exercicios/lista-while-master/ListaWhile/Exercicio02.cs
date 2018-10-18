using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaEstruturaCondicionalWhile
{
    class Exercicio02
    {
        public Exercicio02()
        {
            Console.Write("Digite idade");
            int Idade = Convert.ToInt32(Console.ReadLine());

            while (Idade < 128)
            {
                Console.WriteLine("Digite uma Idade");
                Idade = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}
