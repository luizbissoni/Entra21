using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaEstruturaCondicional
{
    class Exercicio016
    {
        public Exercicio016()
        {

            double TemperaturaConvertida = 0;

            Console.Write("Temperatura a ser convertida: ");
            double Temperatura1 = Convert.ToDouble(Console.ReadLine());

            Console.Clear();

            Console.WriteLine(
                          "Tabela de converção" + "\n" +
                          "1: Celsius" + "\n" +
                          "2: Fahrenheit" + "\n" +
                          "3: Kelvin" + "\n"
                          );

            Console.Write("converter Temperatura: ");
            double TemperaturaOpcao = Convert.ToDouble(Console.ReadLine());

            Console.Clear();

            Console.WriteLine(
                          "Tabela de converção" + "\n" +
                          "1: Celsius" + "\n" +
                          "2: Fahrenheit" + "\n" +
                          "3: Kelvin" + "\n"
                          );

            Console.Write("converter Temperatura: ");
            double TemperaturaOpcao2 = Convert.ToDouble(Console.ReadLine());

            Console.Clear();

            if ((TemperaturaOpcao == 1) && (TemperaturaOpcao2 == 2))
            {
                TemperaturaConvertida = (Temperatura1 * 9) / 5 + 32;
                Console.WriteLine(string.Format("{0}C Convertido para Fahrenheit {1}F", Temperatura1, TemperaturaConvertida));
            }
            else if ((TemperaturaOpcao == 1) && (TemperaturaOpcao2 == 3))
            {
                TemperaturaConvertida = Temperatura1 + 273;
                Console.WriteLine(string.Format("{0}C Convertido para Kelvin {1}", Temperatura1, TemperaturaConvertida));
            }
            else if ((TemperaturaOpcao == 2) && (TemperaturaOpcao2 == 1))
            {
                TemperaturaConvertida = (Temperatura1 - 32) * (5 / 9);
                Console.WriteLine(string.Format("{0}F Convertido para Celsius {1}", Temperatura1, TemperaturaConvertida));
            }
            else if ((TemperaturaOpcao == 2) && (TemperaturaOpcao2 == 3))
            {
                TemperaturaConvertida = (Temperatura1 - 32) * (5 / 9) + 273;
                Console.WriteLine(string.Format("{0}F Convertido para Kelvin {1}", Temperatura1, TemperaturaConvertida));
            }
            else if ((TemperaturaOpcao == 3) && (TemperaturaOpcao2 == 1))
            {
                TemperaturaConvertida = Temperatura1 - 273;
                Console.WriteLine(string.Format("{0}K Convertido para Celsius {1}", Temperatura1, TemperaturaConvertida));
            }
            else if ((TemperaturaOpcao == 3) && (TemperaturaOpcao2 == 2))
            {
                TemperaturaConvertida = ((Temperatura1 - 273) * 1.8) + 32;
                Console.WriteLine(string.Format("{0}K Convertido para Fahrenheit {1}", Temperatura1, TemperaturaConvertida));
            }
            else if ((TemperaturaOpcao == 1) && (TemperaturaOpcao2 == 1))
            {
                TemperaturaConvertida = Temperatura1;
                Console.WriteLine("{0} C");
            }






        }
    }
}
