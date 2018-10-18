using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ListaEstruturaCondicionalWhile
{
    class Exercicio09
    {
        public Exercicio09()
        {

            Console.Write("Digite alguma coisa: ");
            string Texto = Console.ReadLine();
            int Texto1 = Texto.Length;
            int Contador = 1;

            while (Contador < Texto1) 
            {
                
                Console.WriteLine(Texto.Substring(0, Contador));
                Contador++;
            }



        }
    }
}
