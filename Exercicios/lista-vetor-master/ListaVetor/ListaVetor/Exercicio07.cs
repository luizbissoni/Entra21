using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ListaVetor
{
    class Exercicio07
    {
        public Exercicio07()
        {
        
            double maiorAltura = 0;
            int menorIdade = 128;
            double[] altura = new double[4];
            int[] idade = new int[4];

            Console.Write("ALtura 1: ");
            altura[0] = Convert.ToDouble(Console.ReadLine());
            Console.Write("Idade 1: ");
            idade[0] = Convert.ToInt32(Console.ReadLine());

            Console.Write("Altura 2: ");
            altura[1] = Convert.ToDouble(Console.ReadLine());
            Console.Write("Idade 2: ");
            idade[1] = Convert.ToInt32(Console.ReadLine());

            Console.Write("Altura 3: ");
            altura[2] = Convert.ToDouble(Console.ReadLine());
            Console.Write("Idade 3: ");
            idade[3] = Convert.ToInt32(Console.ReadLine());

            Console.Write("Altura 4: ");
            altura[3] = Convert.ToDouble(Console.ReadLine());
            Console.Write("Idade 4: ");
            idade[3] = Convert.ToInt32(Console.ReadLine());

            if (altura[0]>maiorAltura)
            {
                maiorAltura = altura[0];
            }
            if (altura[1] > maiorAltura)
            {
                maiorAltura = altura[1];
            }
            if (altura[2] > maiorAltura)
            {
                maiorAltura = altura[2];
            }
            if (altura[3] > maiorAltura)
            {
                maiorAltura = altura[3];
            }
            //Menor Idade
            if (idade[0] < menorIdade)
            {
                menorIdade = idade[0];
            }
            if (idade[1] < menorIdade)
            {
                menorIdade = idade[1];
            }
            if (idade[2] < menorIdade)
            {
                menorIdade = idade[2];
            }
            if (idade[3] < menorIdade)
            {
                menorIdade = idade[3];
            }

            Console.WriteLine(string.Format("{0:n} maior Altura, {1} Menor Idade",maiorAltura,menorIdade));

        }
    }
}
