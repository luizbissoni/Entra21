using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaEstruturaCondicional
{
    class Exercicio003
    {
        public Exercicio003()
        {
            Console.Write("Digite um Número: ");
            double Numero1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite um Número: ");
            double Numero2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n");

            Console.Write
                          (
                            "Escolha umas das Opções: " + "\n" +
                            "1: Somar" + "\n" +
                            "2: Subtrair" + "\n" +
                            "3: Multiplicar" + "\n" +
                            "4: Dividir "

                           );

            int Opcao = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            if (Opcao == 1)
            {
                double Somar = Numero1 + Numero2;
                Console.WriteLine(string.Format("A soma entre o número: {0} e {1} = {2}",Numero1,Numero2,Somar));
            }

            else if (Opcao == 2)
            {
                double Subtrair = Numero1 - Numero2;
                Console.WriteLine(string.Format("Subtração entre os números: {0} e {1} = {2}",Numero1,Numero2,Subtrair));
            }
            else if (Opcao == 3)
            {
                double Multiplicar = Numero1 * Numero2;
                Console.WriteLine(string.Format("A Multiplicção entre os Números: {0} e {1} = {2}",Numero1,Numero2,Multiplicar));
            }
            else if (Opcao == 4)
            {
                double Dividir = Numero1 / Numero2;
                Console.WriteLine(string.Format("A Divição entre os Números: {0} e {1} = {2}",Numero1,Numero2,Dividir));
            }






        }
    }
}
