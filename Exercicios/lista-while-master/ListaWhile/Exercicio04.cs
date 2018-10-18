using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ListaEstruturaCondicionalWhile
{
    class Exercicio04
    {
        public Exercicio04()
        {
            int Contador = 0;
            string Modelo = " ".ToUpper();
            double ValorCarro = 0, SomaValor = 0;
            int LetraA = 0, AnoCarro = 0, SomaAno = 0, LetraG = 0;
            int QuantidadeCarros = 0;
            bool ValidarCadastro = true;

            
            while (ValidarCadastro == true)
            {
                try
                {
                    Console.Write("Digite a quantidade de carro: ");
                    QuantidadeCarros = Convert.ToInt32(Console.ReadLine());
                    ValidarCadastro = false;
                }
                catch (Exception e)
                {
                    Console.WriteLine(" Somente Números! ");
                }
            }
            
            while (Contador < QuantidadeCarros)
            {

                Console.Write("Modelo do Veiculo: ");
                Modelo = Console.ReadLine();

                Console.Write("Valor do veiculo: R$");
                ValorCarro = Convert.ToDouble(Console.ReadLine());

                Console.Write("Ano do Veiculo: ");
                AnoCarro = Convert.ToInt32(Console.ReadLine());

                if (Modelo == "A")
                {
                    LetraA = Modelo.Length;
                    LetraA += LetraA;
                    
                }
                if (Modelo == "G")
                {
                    LetraG = Modelo.Length;
                    LetraG += LetraG;
                }

                SomaAno = SomaAno + QuantidadeCarros;
                SomaValor = Contador + QuantidadeCarros;
                Contador = Contador + 1;
            }
                double MediaValor = SomaValor / QuantidadeCarros;
                double MediaAno = SomaAno / QuantidadeCarros;
                Console.WriteLine(string.Format("\nMedia Valor: R${0:n}", MediaValor));
                Console.WriteLine("media Ano: " + MediaAno);
                Console.WriteLine(LetraA + " Carros que começam com a letra A");
                Console.WriteLine(LetraG + " Carros que começam com a letra G");
        }
    }
}
