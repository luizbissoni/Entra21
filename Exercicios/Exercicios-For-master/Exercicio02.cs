using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExerciciosFor
{
    class Exercicio02
    {
        public Exercicio02()
        {
            bool validacao = true;
            int[] idade = new int[7];

            for (int i = 0; i < idade.Length; i++, validacao = true)
            {
                while (validacao == true)
                {
                    try
                    {
                        Console.Write("Idade " + i + ":");
                        idade[i] = Convert.ToInt32(Console.ReadLine().Trim());
                        validacao = false;
                    }
                    catch (Exception)
                    {
                       
                        Console.WriteLine("Valor invalido!");
                    }
                }
            }
            Console.WriteLine();

            for (int i = 0; i < idade.Length; i++)
            {
                Console.WriteLine("Idades: " + idade[i]);
            }

        }
    }
}

