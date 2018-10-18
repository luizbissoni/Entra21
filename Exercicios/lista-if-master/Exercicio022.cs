using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ListaExercicios02
{
    class Exercicio022
    {
        public Exercicio022()
        {
            Console.Write("Quantidade de Produtos: ");
            int QuantidadeProduto = Convert.ToInt32(Console.ReadLine());

            Console.Write("Valor unitário: ");
            double ValorUnitario = Convert.ToDouble(Console.ReadLine());

            Console.Write("Dinheiro recebido: ");
            double ValorRecebido = Convert.ToDouble(Console.ReadLine());

            double ValorCompra = ValorUnitario * QuantidadeProduto;
            double ValorRestante;

            Console.WriteLine("\n");

            if (ValorRecebido < ValorCompra)
            {
                ValorRestante = ValorCompra - ValorRecebido;
                Console.WriteLine(string.Format("Valor Compra: R${0:n}"+"\nFaltou R${1:n}",ValorCompra,ValorRestante));
            }
            else if (ValorRecebido > ValorCompra)
            {
                ValorRestante = ValorRecebido - ValorCompra;
                Console.WriteLine(string.Format("Valor compra: R${0:n}"+"\nTroco: R${1:n}",ValorCompra,ValorRestante));
            }
            else if (ValorRecebido == ValorCompra)
            {
                ValorRestante = ValorRecebido - ValorCompra;
                Console.WriteLine("Valor compra: R${0:n}" + "\ntroco: R${1:n}",ValorCompra,ValorRecebido );
            }
        }
    }
}
