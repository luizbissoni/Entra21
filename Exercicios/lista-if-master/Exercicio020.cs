using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaEstruturaCondicional
{
    class Exercicio020
    {
        public Exercicio020()
        {

            Console.Write("Seu Peso: ");
            double Peso = Convert.ToDouble(Console.ReadLine());

            Console.Write("Sua Altura: ");
            double Altura = Convert.ToDouble(Console.ReadLine());

            double Imc = Peso / (Altura * Altura);

            if (Imc <= 9.99)
            {
                Console.WriteLine("Desnutrição Grau V");
            }
            else if ((Imc > 10) || (Imc <= 12.9))
            {
                Console.WriteLine("Desnutrição Grau IV");
            }
            else if ((Imc > 13) || (Imc <= 15.9))
            {
                Console.WriteLine("Desnutrição Grau III");
            }
            else if ((Imc > 16) || (Imc <= 16.9))
            {
                Console.WriteLine("Desnutrição Grau II");
            }
            else if ((Imc > 17) || (Imc <= 18.4))
            {
                Console.WriteLine("Desnutrição Grau I");
            }
            else if ((Imc > 18.5) || (Imc <= 24.9))
            {
                Console.WriteLine("Normal");
            }
            else if ((Imc > 25) || (Imc <= 29.9))
            {
                Console.WriteLine("Pré-Obesidade");
            }
            else if ((Imc > 30) || (Imc <= 34.5))
            {
                Console.WriteLine("Obesidade Grau I");
            }
            else if ((Imc > 35) || (Imc <= 39.9))
            {
                Console.WriteLine("Obecidade Grau II");
            }
            else if (Imc >= 39.9)
            {
                Console.WriteLine("Obesidade Grau III");
            }
        }
    }
}
