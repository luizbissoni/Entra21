using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicios02
{
    class Exercicio03
    {
        static void Main3(string[] args)
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

            Console.WriteLine("\n");

            if (Opcao == 1)
            {
                double Somar = Numero1 + Numero2;
                Console.WriteLine("A soma entre o número: "+ Numero1 +"e "+ Numero2 + " = " + Somar );
            }

            else if (Opcao == 2)
            {
                double Subtrair = Numero1 - Numero2;
                Console.WriteLine("Subtração entre os números: " + Numero1 + " e " + Numero2 + " = " + Subtrair);
            }
            else if (Opcao == 3)
            {
                double Multiplicar = Numero1 * Numero2;
                Console.WriteLine("A Multiplicção entre os Números: " + Numero1 + " e " + Numero2 + " = " + Multiplicar);
            }
            else if (Opcao == 4)
            {
                double Dividir = Numero1 / Numero2;
                Console.WriteLine("A Divição entre os Números: " + Numero1 + " e " + Numero2 + " = " + Dividir + "\n");
            }




            

        }
    }
}
