using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ListaEstruturaCondicionalWhile
{
    class Exercicio10
    {
        public Exercicio10()
        {
            int Contador = 0;
            Console.Write("Digite um texto: ");
            string Texto = Console.ReadLine();
            string TextoContador = Texto;
            string Alfabeto = "abcdefghijklmnopqrstuvxwyz";



            while (Contador < Alfabeto.Length)
            {
                int ContadorQuantCharEncontrados = 0;
                int ContadorTextoDigitado = 0;
                var PrimeiraComparacao = Alfabeto[Contador].ToString();

                while (ContadorTextoDigitado < Texto.Length)
                {
                    if (Texto[ContadorTextoDigitado].ToString().ToLower() == PrimeiraComparacao)
                    {
                        ContadorQuantCharEncontrados++;
                    }
                    ContadorTextoDigitado++;
                }

                Console.WriteLine(string.Format("{0} = {1}", PrimeiraComparacao, ContadorQuantCharEncontrados));
                Contador++;
            }

            Console.ReadKey();

        }
    }
}
