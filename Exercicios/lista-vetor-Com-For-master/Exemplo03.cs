using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExemploVetorComFor
{
    class Exemplo03
    {
        public Exemplo03()
        {
            int maiorFazendaComPorcos = 0;
            string fazendoMaiorQuantidadeSuinos = "";
            string menorNome = "";
            
            Console.Write("Digite a quantidade de registros que deseja cadastrar: ");
            int quantidadeRegistro = Convert.ToInt32(Console.ReadLine());
            string[] fazendas = new string[quantidadeRegistro];

            int[] quantidadePorcos = new int[quantidadeRegistro];

            for (int i = 0; i < fazendas.Length; i++)
            {
                Console.Write("Nome da fazendo: ");
                fazendas[i] = Console.ReadLine();

                Console.Write("Quantidade de suinos: ");
                quantidadePorcos[i] = Convert.ToInt32(Console.ReadLine());

                if (quantidadePorcos[i] > maiorFazendaComPorcos)
                {
                    maiorFazendaComPorcos = quantidadePorcos[i];
                    fazendoMaiorQuantidadeSuinos = fazendas[i];
                }
            }
                Console.WriteLine(fazendoMaiorQuantidadeSuinos + "Contém " + maiorFazendaComPorcos);

                for (int i = 0; i < fazendas.Length; i++)
                {
                    if (fazendas[i].Length < menorNome.Length)
                    {
                        menorNome = fazendas[i];
                    }
                    Console.WriteLine("Fazenda com o menor nome: " + menorNome);
                }
            }
        }
    }

