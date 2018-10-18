using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ListaEstruturaCondicionalWhile
{
    class Exercicio12
    {
        public Exercicio12()
        {
            int Contador = 0, Quantidade = 5;

            while (Quantidade < 5)
            {
                Contador = Contador + 1;
                Quantidade = Quantidade - 1;

                Console.Write("Nome Produto: ");
                string NomeProduto = Console.ReadLine();

                Console.Write("Valor total: R$");
                double ValorTotal = Convert.ToDouble(Console.ReadLine());

                Console.Write("Quantidade: ");
                Quantidade = Convert.ToInt32(Console.ReadLine());


            }


        }
    }
}
