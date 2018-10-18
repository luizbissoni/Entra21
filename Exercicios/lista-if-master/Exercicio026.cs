using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ListaExercicios02
{
    class Exercicio026
    {
        public Exercicio026()
        {
            Console.Write("Valor de Desconto: R$");
            double ValorDesconto = Convert.ToDouble(Console.ReadLine());

            Console.Write("Percentual de Desconto: ");
            double ValorPorcentualDesconto = Convert.ToDouble(Console.ReadLine());

            double ValorTotalCompra = (ValorDesconto * 100) / ValorPorcentualDesconto;

            Console.WriteLine(string.Format("Valor total da Compra: R${0:n}",ValorTotalCompra));
        }
    }
}
