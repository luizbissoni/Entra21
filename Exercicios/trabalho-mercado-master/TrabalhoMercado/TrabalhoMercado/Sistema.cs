using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TrabalhoMercado
{
    class Sistema
    {
        Compras compras = new Compras();
        Padaria _padaria = new Padaria();
        Feira _feira = new Feira();
        Frios _frios = new Frios();
        Limpeza _limpeza = new Limpeza();
        


        public Sistema()
        {
            MenuPrincipal();
        }
        public void MenuSistema()
        {

            Console.Write(
@"  |==========================|
  |                          |                           
  |      MENU PRINCIPAL      |
  |                          |
  |==========================|

1 - Compras
2 - Listar
3 - Editar
4 - Cadastro
5 - SAIR
OPÇÃO:");
        }
        public void MenuPrincipal()
        {
            MenuSistema();
            int menuPrincipal = Convert.ToInt32(Utils.ReturnPressKeyIntCode(Console.ReadLine()));

            switch (menuPrincipal)
            {
                case 1:
                    compras.compras(_limpeza, _padaria, _frios,_feira); // passa os objetos pra poder editar eles
                    break;
                case 2:
                    listar();
                    break;
                case 3:
                    Editar();
                    break;
                case 4:
                    Cadastrar();
                    break;
                case 5: return;
                default:
                    Console.WriteLine("Opção invalida!");
                    break;
            }

            MenuPrincipal();
        }
        private void listar() 
        {
            Console.Clear();
            Console.WriteLine(@"
LISTAR

1 - Feira
2 - Frios
3 - Limpeza
4 - Padaria
8 - Sair
9 - Voltar");
            int listarProdutos = Convert.ToInt32(Utils.ReturnPressKeyIntCode(Console.ReadLine()));
            switch (listarProdutos)
            {
                case 1:
                    _feira.ListaFeira();
                    break;
                case 2:
                    _frios.ListarFrios();
                    break;
                case 3:
                    _limpeza.Listarlimpeza();
                    break;
                case 4:
                    _padaria.Listarpadaria();
                    break;
                
                case 9: return;
                default:
                    Console.WriteLine("Opção invalida!");
                    break;
            }
                    
        }
        private void Editar()
        {
            Console.Clear();
            Console.WriteLine(@"
EDITAR

1 - Padaria
2 - Feira
3 - Frios
4 - Limpeza
9 - voltar menu principal");
            int editorProdutos = Convert.ToInt32(Utils.ReturnPressKeyIntCode(Console.ReadLine()));
            switch (editorProdutos)
            {
                case 1:
                    _padaria.EditarProdutosPadaria();
                    break;
                case 2:
                    _feira.EditarProdutosFeira();
                    break;
                case 3:
                    _frios.EditarProdutosFrios();
                    break;
                case 4:
                    _limpeza.EditarProdutoslimpeza();
                    break;
                
                case 9: return;
                default:
                    Console.WriteLine("Opção invalida!");
                    break;
            }
            Console.Clear();
        }
        private void Cadastrar()
        {
            Console.Clear();
            Console.WriteLine("MENU CADASTRO");
          Console.WriteLine(@"
1 - Feira
2 - Frios
3 - Limpeza
4 - Padaria


9 - Voltar");
            int _menuCadastro = Convert.ToInt32(Console.ReadLine());
            switch (_menuCadastro)
            {
                case 1:
                    _feira.CadastroFeira();
                    break;
                case 2:
                    _frios.cadastroFrios();
                    break;
                case 3:
                    _limpeza.cadastro();
                    break;
                case 4:
                    _padaria.cadastro();
                    break;
                
                case 9: return;
                default:
                    Console.WriteLine("Opção invalida!");
                    break;
            }
        }
    }
}
