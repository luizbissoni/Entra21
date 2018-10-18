using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ListaEstruturaCondicionalWhile
{
    class Exercicio06
    {
        public Exercicio06()
        {
            int Contador = 0;
            double NumeroPedido1 = 29.50;
            double NumeroPedido2 = 30.50;
            double NumeroPedido3 = 27.99;
            double NumeroPedido4 = 25.90;
            double NumeroPedido5 = 20.65;
            double NumeroPedido6 = 3.50;
            double NumeroPedido7 = 4.99;
            double NumeroPedido8 = 25.69;
            double NumeroPedido9 = 15.60;
            double NumeroPedido10 = 10.50;
            double NumeroPedido11 = 19.30;
            double NumeroPedido12 = 15.89;
            double NumeroPedido13 = 19.90;
            double NumeroPedido14 = 21.75;
            double NumeroPedido15 = 26.50;
            double Opcao = 0, ValorTotal = 0;
            int Bolos = 0, Doces = 0, Sanduiches = 0, Pizzas = 0;
            bool ValidarOpcao = true;


            Console.WriteLine("\nCodigo | Tipo        | Nome                                     | Valor" +
                                "\n1     |Bolos       |Bolo Brigadeiro                           |R$ 29,50" +
                                "\n2     |Bolos       |Bolo Floresta Negra                       |R$20,50" +
                                "\n3     |Bolos       |Bolo leite com Nutella                    |R$29,23" +
                                "\n4     |Bolos       |Mousse de chocolate                       |R$21,99" +
                                "\n5     |Bolos       |Bolo Nega Maluca                          |R$19,33" +
                                "\n6     |Doces       |Bomba de creme                            |R$17,71" +
                                "\n7     |Doces       |Bomba de morango                          |R$4,82" +
                                "\n8     |Sanduiches  |File-Mignon com fritas e cheddar          |R$21,16" +
                                "\n9     |Sanduiches  |Hambúrguer com Queijo,Champignon e rúcula |R$15,60" +
                                "\n10    |Sanduiches  |Provolone com salame                      |R$10,50" +
                                "\n11    |Sanduiches  |Vegetariano de berinjela                  |R$19,30" +
                                "\n12    |Pizzas      |Calabresa                                 |R$15,89" +
                                "\n13    |Pizzas      |Napolitana                                |R$19,90" +
                                "\n14    |Pizzas      |Peruana                                   |R$21,75" +
                                "\n15    |Pizzas      |Portuguesa                                |R$26,50" +
                                "\n                >>>>>>>>>> 16 - SAIR <<<<<<<<<<                 ");

            while (ValidarOpcao == true)
            {
                try
                {
                    Console.WriteLine("Selecione um Pedido: ");
                    Opcao = Convert.ToDouble(Console.ReadLine());
                    ValidarOpcao = false;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Somente Números! ");
                }
            }

            while (Opcao != 16)
            {
                Console.Write("Selecione um Pedido: ");
                Opcao = Convert.ToDouble(Console.ReadLine());

                if (Opcao == 1)
                {
                    Opcao = NumeroPedido1;
                    Bolos = Bolos + 1;
                }
                else if (Opcao == 2)
                {
                    Opcao = NumeroPedido2;
                    Bolos = Bolos + 1;
                }
                else if (Opcao == 3)
                {
                    Opcao = NumeroPedido3;
                    Bolos = Bolos + 1;
                }
                else if (Opcao == 4)
                {
                    Opcao = NumeroPedido4;
                    Bolos = Bolos + 1;
                }
                else if (Opcao == 5)
                {
                    Opcao = NumeroPedido5;
                    Bolos = Bolos + 1;
                }
                else if (Opcao == 6)
                {
                    Opcao = NumeroPedido6;
                    Doces = Doces + 1;
                }
                else if (Opcao == 7)
                {
                    Opcao = NumeroPedido7;
                    Doces = Doces + 1;
                }
                else if (Opcao == 8)
                {
                    Opcao = NumeroPedido8;
                    Sanduiches = Sanduiches + 1;
                }
                else if (Opcao == 9)
                {
                    Opcao = NumeroPedido9;
                    Sanduiches = Sanduiches + 1;
                }
                else if (Opcao == 10)
                {
                    Opcao = NumeroPedido10;
                    Sanduiches = Sanduiches + 1;
                }
                else if (Opcao == 11)
                {
                    Opcao = NumeroPedido11;
                    Sanduiches = Sanduiches + 1;
                }
                else if (Opcao == 12)
                {
                    Opcao = NumeroPedido12;
                    Pizzas = Pizzas + 1;
                }
                else if (Opcao == 13)
                {
                    Opcao = NumeroPedido13;
                    Pizzas = Pizzas + 1;
                }
                else if (Opcao == 14)
                {
                    Opcao = NumeroPedido14;
                    Pizzas = Pizzas + 1;
                }
                else if (Opcao == 15)
                {
                    Opcao = NumeroPedido15;
                    Pizzas = Pizzas + 1;
                }

                Contador = Contador + 1;
                ValorTotal = Opcao * Contador;
            }
                Console.WriteLine(Bolos + " Bolos");
                Console.WriteLine(Doces + " Doces");
                Console.WriteLine(Sanduiches + " Sanduiches");
                Console.WriteLine(Pizzas + " Pizzas");
                Console.WriteLine("Total a pagar: R$" + ValorTotal);


        }
    }
}