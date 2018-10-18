using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicios02
{
    class Exercicio16
    {
        static void Main16(string[] args)
        {
            double Opcao1 = 0;
            //double Opcao2 = 0;
            double TemperaturaConvertida = 0;
            double Celsius = 0;
            double Fahrenheit = 32;
            double Kelvin = 273.15;

            Console.WriteLine(
                          "Tabela de converção"+"\n"+
                          "1: Celsius" + "\n" +
                          "2: Fahrenheit" + "\n" + 
                          "3: Kelvin" + "\n"  
                
                          );

            Console.Write("converter Temperatura: ");
            double TemperaturaOpcao = Convert.ToDouble(Console.ReadLine());

            if (TemperaturaOpcao == 1)
            {
                Opcao1 = Celsius;
            }
            else if (TemperaturaOpcao == 2)
            {
                Opcao1 = Fahrenheit; 
            }
            else if (TemperaturaOpcao == 3)
            {
                Opcao1 = Kelvin;
            }

            Console.Write("Temperatura a ser convertida: ");
            double Temperatura = Convert.ToDouble(Console.ReadLine());

            if (Temperatura == 2)
            {
                TemperaturaConvertida = (1.8 * Opcao1) + 32;
            }
           


           
        }
    }
}
