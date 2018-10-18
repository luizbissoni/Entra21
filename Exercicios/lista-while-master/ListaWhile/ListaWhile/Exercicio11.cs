using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ListaEstruturaCondicionalWhile
{
    class Exercicio11
    {
        public Exercicio11()
        {
            int Contador = 0;
            Console.Write("Digite Fim para sair: ");
            string Sair = Console.ReadLine();

            while (Sair != "fim")
            {
                Contador = Contador + 1;
                Console.Write("Nome Produto: ");
                string NomeProduto = Console.ReadLine();

                Console.Write("Quantidade: ");
                int Quantidade = Convert.ToInt32(Console.ReadLine());

                Console.Write("Valor Unitario: R$");
                double ValorUnitario = Convert.ToDouble(Console.ReadLine());

                double TotalValor = ValorUnitario * Quantidade;
                double Desconto = (TotalValor * 5) / 100;

                Console.Write(string.Format("Valor total: R${0:n}",Desconto));

                Console.Write("Digite fim para sair");
                Sair = Console.ReadLine();


            }

        }    
    }
}
