using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ListaEstruturaCondicionalWhile
{
    class Exercicio01
    {
        public Exercicio01()
        {
            Console.Write("Digite seu nome, para sair digite fim: ");
            string Nome = Console.ReadLine();

            while (Nome != "fim")
            { 
                Console.Write("Digite um nome, para sair digite fim: ");
                Nome = Console.ReadLine();
            }
        }
    }
}
