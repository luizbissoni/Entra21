using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoMercado
{
    class Compras
    {

        Limpeza ComprasLimpeza = new Limpeza();
        Frios ComprasFrios = new Frios();
        

        /// <summary>
        /// Metodo que inicia a compra 
        /// </summary>
        /// <param name="limp">objeto de limpeza</param>
        /// <param name="padaria">objeto de padaria</param>
        /// 

        public void compras(Limpeza limp, Padaria padaria, Frios frios, Feira feira)
        {
            MenuCompras(limp,padaria,frios,feira);
        }
        public void MenuEscolha()
        {
            Console.Clear();
            Console.WriteLine(@"
MENU COMPRAS 
1 - Limpeza
2 - Padaria
3 - Frios
4 - Feira

8 - Voltar
9 - SAIR");
        }
        public void MenuCompras(Limpeza limp,Padaria padaria,Frios frios, Feira feira)
        {
            MenuEscolha();
            int menuCompras = Convert.ToInt32(Console.ReadLine().Trim());

            switch (menuCompras)
            {
                case 1:
                    limp.Comprar();
                    break;
                case 2:
                    padaria.comprar(); 
                    break;
                case 3:
                    frios.comprar();
                    break;
                case 4:
                    feira.compras();
                    break;
                case 8: return;

                default:
                    break;
            }


        }
      
    }


}



