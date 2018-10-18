using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExerciciosFor
{
    class Exercicio01
    {
        public Exercicio01()
        {
            bool validarRegistro = true;
            string[] nomes = new string[10];
            int numero;


            for (int i = 0; i < nomes.Length; i++, validarRegistro = true)
            {
                while (validarRegistro == true)
                {
                    try
                    {
                        Console.Write("Nome: ");
                        nomes[i] = Console.ReadLine().Trim();

                        if (int.TryParse(nomes[i], out numero))
                        {
                            throw new Exception();
                        }
                        validarRegistro = false;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Somente Nomes !");
                    }
                }
            }
            Console.WriteLine();
            for (int i = 0; i < nomes.Length; i++)
            {

                Console.WriteLine(nomes[i]);
            }




        }


    }
}

