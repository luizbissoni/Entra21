using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicios02
{
    class Exercicio06
    {
        static void Main6(string[] args)
        {
            Console.Write("Digite um Número: ");
            int NumeroDiferente = Convert.ToInt32(Console.ReadLine());

            if (NumeroDiferente != 1)
            {
                Console.WriteLine("O Número " + NumeroDiferente + " é Diferente de 1."); 
            }
        }
    }
}
