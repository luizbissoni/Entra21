using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ListaExercicios02
{
    class Exercicio025
    {
        public Exercicio025()
        {
            Console.Write("Valor total da compra: R$");
            double ValorTotalCompra = Convert.ToDouble(Console.ReadLine());

            Console.Write("Porcentual de Desconto: ");
            double ValorPorcentualDesconto = Convert.ToDouble(Console.ReadLine());

            double ValorDesconto = (ValorTotalCompra * ValorPorcentualDesconto) / 100;

            Console.WriteLine(string.Format("Valor total de Desconto: R${0:n}",ValorDesconto));
        }
    }
}
