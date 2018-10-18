using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExerciciosFor
{
    class Exercicio09
    {
        public Exercicio09()
        {
            int[] notaMateria = new int[4];

            Console.Write("Nome da disciplina: ");
            string disciplina = Console.ReadLine();
            double mediaNotas = 0;
            int somaNotas = 0; 
            for (int i = 0; i < notaMateria.Length; i++)
            {
                Console.Write("Nota "+i+": ");
                notaMateria[i] = Convert.ToInt32(Console.ReadLine());

                somaNotas = somaNotas + notaMateria[i];
                mediaNotas = somaNotas / notaMateria.Length;

                Console.Write(" Notas: " + notaMateria[i]);
            }
           
                Console.Write(string.Format("{0} Media ", mediaNotas));

        }
    }
}
