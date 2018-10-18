using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExerciciosFor
{
    class Exercicio10
    {
        public Exercicio10()
        {
            string[] nome = new string[10];
            int quantidadeS = 0,quantidadeA =0, quantidadeSilva = 0, maiorNome = 0, menorNome = 99,quantidadeNomeMenor = 0, quantidadeNomeMaior = 0;
            string todosNomes = "";
            
            for (int i = 0; i < nome.Length; i++)
            {
                Console.Write("Nome "+i+": ");
                nome[i] = Console.ReadLine().ToUpper().Trim();

                if (nome[i] == "S")
                {
                    quantidadeS++;
                }
                if (nome[i] == "A")
                {
                    quantidadeA++;
                }
                
                if (nome[i] == "SILVA")
                {
                    quantidadeSilva++;
                }
                if (nome[i].Length > maiorNome)
                {
                    quantidadeNomeMaior++;
                }
                if (nome[i].Length < menorNome)
                {
                    quantidadeNomeMenor++;
                }

                todosNomes = string.Join(",", nome);
            }

            Console.WriteLine("Todos os nomes: "+ todosNomes);
            Console.WriteLine("A " + quantidadeA);
            Console.WriteLine("S " + quantidadeS);
            Console.WriteLine("Silva " + quantidadeSilva);
            Console.WriteLine("Menor " + quantidadeNomeMenor);
            Console.WriteLine("Maior "+quantidadeNomeMaior);
        }
    }
}
