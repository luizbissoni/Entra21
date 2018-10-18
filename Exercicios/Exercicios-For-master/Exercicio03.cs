using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExerciciosFor
{
    class Exercicio03
    {
        public Exercicio03()
        {
            bool validacaoDadosRecebidos = true;
            bool validacaoRegistro = true;
            int QuantidadeRegistros = 0;


            while (validacaoRegistro == true)
            {
                try
                {
                    Console.Write("Quantidade de Registros: ");
                    QuantidadeRegistros = Convert.ToInt32(Console.ReadLine());
                    validacaoRegistro = false;
                }
                catch (Exception)
                {
                    Console.WriteLine("Valor invalido !!");
                }
                double[] preco = new double[QuantidadeRegistros];

                for (int i = 0; i < QuantidadeRegistros; i++)
                {
                    while (validacaoDadosRecebidos == true)
                    {
                        try
                        {
                            Console.Write("Preço " + i + ": ");
                            preco[i] = Convert.ToDouble(Console.ReadLine());

                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Valor invalido !");
                        }
                    }
                }
                for (int i = 0; i < QuantidadeRegistros; i++)
                {
                    Console.WriteLine(i + " = " + preco[i]);
                }

            }


        }
    }
}
