using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExerciciosFor
{
    class Exercicio05
    {
        public Exercicio05()
        {
            Console.Write("Quantidade de jogos para cadastro: ");
            int quantidadeJogos = Convert.ToInt32(Console.ReadLine());
            string[] nomeJogos = new string[quantidadeJogos];
            int[] quantidadeJogosLoja = new int[quantidadeJogos];

            for (int i = 0; i < quantidadeJogos; i++)
            {
                Console.Write("Nome do Game: ");
                nomeJogos[i] = Console.ReadLine();

                Console.Write("Quantas unidades: ");
                quantidadeJogosLoja[i] = Convert.ToInt32(Console.ReadLine());

            }

            for (int i = 0; i < quantidadeJogos; i++)
            {
                Console.WriteLine(string.Format("{0} --- {1}", nomeJogos[i],quantidadeJogosLoja[i]));
            }
        }
    }
}
