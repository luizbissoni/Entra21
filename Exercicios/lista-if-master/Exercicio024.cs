using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ListaExercicios02
{
    class Exercicio024
    {
        public Exercicio024()
        {
            Console.Write("Valor total da compra: R$");
            double ValorTotal = Convert.ToDouble(Console.ReadLine());

            Console.Write("Valor de Desconto: R$");
            double ValorDesconto = Convert.ToDouble(Console.ReadLine());

            double ValorPorcento = (ValorDesconto * 100) / ValorTotal ;

            Console.WriteLine(string.Format("{0:n}% de Desconto",ValorPorcento));


        }
    }
}
