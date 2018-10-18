using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ListaEstruturaCondicionalWhile
{
    class Exercicio05
    {
        public Exercicio05()
        {
            double Resultado = 0;
            string ResultadoNumeros = "";
            double Numero1 = 0;
            double Numero2 = 0;
            int Opcao = 0;
           
            while (Opcao != 5) 
            {
                Console.Write("Digite um numero: ");
                Numero1 = Convert.ToDouble(Console.ReadLine());

                Console.Clear();

                Console.Write("Digite mais um numero: ");
                Numero2 = Convert.ToDouble(Console.ReadLine());

                Console.Clear();


                Console.WriteLine("\n1 = Soma" +
                                    "\n2 = Subtrair" +
                                    "\n3 = Multiplicar" +
                                    "\n4 = Dividir" +
                                    "\n5 = Sair");
                Opcao = Convert.ToInt32(Console.ReadLine());

                Console.Clear();

                if (Opcao == 1)
                {
                    Resultado = Numero1 + Numero2;
                    ResultadoNumeros = Numero1 + " + " + Numero2 + "=" + Resultado;
                }
                else if (Opcao == 2)
                {
                    Resultado = Numero1 - Numero2;
                    ResultadoNumeros = Numero1 + " - " + Numero2 + "=" + Resultado;
                }
                else if (Opcao == 3)
                {
                    Resultado = Numero1 * Numero2;
                    ResultadoNumeros = Numero1 + " X " + Numero2 + " = " + Resultado;
                }

                else if (Opcao == 4)
                {
                    Resultado = Numero1 / Numero2;
                    ResultadoNumeros = Numero1 + " / " + Numero2 + " = " + Resultado;
                }
                    Console.WriteLine(ResultadoNumeros);
            }
                   
        }
    }
}
