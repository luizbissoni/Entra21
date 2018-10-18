using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExerciciosFor
{
    class Exercicio04
    {
        public Exercicio04()
        {

            int[] TotaldeCamisas = new int[40];
            string[] tamanhoCamisas = new string[TotaldeCamisas.Length];
            bool validacaoEntrada = true;

            for (int i = 0; i < TotaldeCamisas.Length; i++, validacaoEntrada = true)
            {
                while (validacaoEntrada == true)
                {
                    try
                    {
                        Console.Write("Tamanho da camisa " + i + ": ");
                        tamanhoCamisas[i] = Console.ReadLine().ToUpper().Trim();
                        if (tamanhoCamisas[i] != "P" && tamanhoCamisas[i] != "PP" && tamanhoCamisas[i] != "M" && tamanhoCamisas[i] != "G" && tamanhoCamisas[i] != "GG" && tamanhoCamisas[i] != "XG" && tamanhoCamisas[i] != "XGG")
                        {
                            throw new Exception();
                        }

                        validacaoEntrada = false;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Somente tamanho !");
                    }

                }
            }

            int quantidadeP = 0;
            int quantidadePP = 0;
            int quantidadeM = 0;
            int quantidadeG = 0;
            int quantidadeGG = 0;
            int quantidadeXG = 0;
            int quantidadeXGG = 0;

            for (int i = 0; i < TotaldeCamisas.Length; i++)
            {
                if (tamanhoCamisas[i] == "P")
                {
                    quantidadeP++;
                }
                if (tamanhoCamisas[i] == "PP")
                {
                    quantidadePP++;
                }
                if (tamanhoCamisas[i] == "M")
                {
                    quantidadeM++;
                }
                if (tamanhoCamisas[i] == "G")
                {
                    quantidadeG++;
                }
                if (tamanhoCamisas[i] == "GG")
                {
                    quantidadeGG++;
                }
                if (tamanhoCamisas[i] == "XG")
                {
                    quantidadeXG++;
                }
                if (tamanhoCamisas[i] == "XGG")
                {
                    quantidadeXGG++;
                }
            }
            Console.WriteLine();
            Console.WriteLine("Quantidade de camisas do tamanho PP:" + quantidadePP);
            Console.WriteLine("Quantidade de Camisas do tamanho P:" + quantidadeP);
            Console.WriteLine("Quantidade de camisas do tamanho M:" + quantidadeM);
            Console.WriteLine("Quantidade de camisas do tamanho G:" + quantidadeG);
            Console.WriteLine("Quantidade de camisas do tamanho GG:" + quantidadeGG);
            Console.WriteLine("Quantidade de camisas do tamanho XG:" + quantidadeXG);
            Console.WriteLine("Quantidade de camisas do tamanho XGG:" + quantidadeXGG);

        }
    }
}
