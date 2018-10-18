using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ListaVetor
{
    class Exercicio05
    {
        public Exercicio05()
        {
            double[] Peso = new double[5];

            Console.Write("Peso 1: ");
            Peso[0] = Convert.ToDouble(Console.ReadLine());

            Console.Write("Peso 2: ");
            Peso[1] = Convert.ToDouble(Console.ReadLine());

            Console.Write("Peso 3: ");
            Peso[2] = Convert.ToDouble(Console.ReadLine());

            Console.Write("Peso 4: ");
            Peso[3] = Convert.ToDouble(Console.ReadLine());

            Console.Write("Peso 5: ");
            Peso[4] = Convert.ToDouble(Console.ReadLine());

            double somaTotalPeso = Peso[0] + Peso[1] + Peso[2] + Peso[3] + Peso[4];
            double mediaPeso = (Peso[0] + Peso[1] + Peso[2] + Peso[3] + Peso[4]) / 5;

            Console.WriteLine(string.Format("{0} Soma total dos pesos, {1} media total dos pesos ", somaTotalPeso, mediaPeso));
        }
    }
}
