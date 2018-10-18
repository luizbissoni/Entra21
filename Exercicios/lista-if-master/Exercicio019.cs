using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaEstruturaCondicional
{
    class Exercicio019
    {
        public Exercicio019()
        {
            Console.Write("Seu saldo: ");
            double Saldo = Convert.ToDouble(Console.ReadLine());

            Console.Write("Valor Do Depósito: ");
            double Deposito = Convert.ToDouble(Console.ReadLine());

            Console.Write("Valor Parcela do Emprestimo: ");
            double Emprestimo = Convert.ToDouble(Console.ReadLine());

            Console.Write("Valor dos Saques: ");
            double Saque = Convert.ToDouble(Console.ReadLine());

            double TotalSaldo = (Saldo + Deposito) - Emprestimo - Saque;

            if (TotalSaldo == 0)
            {
                Console.WriteLine("Saldo Neutro: " + TotalSaldo);
            }
            else if (TotalSaldo > 0)
            {
                Console.WriteLine("Saldo Positivo: " + TotalSaldo);
            }
            else if (TotalSaldo < 0)
            {
                Console.WriteLine("Saldo Negativo: " + TotalSaldo);
            }


        }
    }
}
