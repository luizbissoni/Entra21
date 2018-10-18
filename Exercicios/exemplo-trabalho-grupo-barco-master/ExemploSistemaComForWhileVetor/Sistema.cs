using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExemploSistemaComForWhileVetor
{
    class Sistema
    {
        Barco barco = new Barco();
        public Sistema()
        {
            GerirMenu();

        }
        // Apresentar menu para o usuario 
        public void Menu()
        {
            Console.WriteLine(@"1 - Cadastro de Barco 
2 - Editar Barco
3 - Listar Barcos
4 - Buscar Barco
20 Sair");
        }

        public void GerirMenu()
        {
            //Chama método para apresentar o menu para o usuário
            Menu();
            int menuEscolha = Convert.ToInt32(Console.ReadLine());

            while (menuEscolha != 20)
            {
                switch (menuEscolha)
                {
                    case 1:
                        barco.CadastrarBarco();
                        break;
                    case 2:
                        barco.EditarBarco();
                        break;
                    case 3:
                        barco.ListarBarcos();
                        break;
                    case 4:
                        barco.BuscaBarco();
                        break;
                }

                Menu();
                menuEscolha = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}
