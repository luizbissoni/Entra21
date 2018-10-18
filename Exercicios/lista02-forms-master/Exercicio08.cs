using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lista_de_Estrutura_Condicional___Forms
{
    public partial class Exercicio08 : Form
    {

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
        double pedido1 = 0, pedido2 = 0, pedido3 = 0, total = 0;


        public Exercicio08()
        {
            InitializeComponent();
            ProdutosTabela();
        }
        public void ProdutosTabela()
        {
            lb_Resultado.Text = @"  
1  Bolos         Bolo Brigadeiro                                                              R$29,50 
2  Bolos         Bolo Floresta Negra                                                       R$30,50
3  Bolos         Bolo Leite Com nutella                                                   R$27,99 
4  Bolos         Bolo Mousse de Chocolate                                            R$25,50
5  Bolos         Bolo Nega Maluca                                                         R$20,65
6  Doces         Bomba de Creme                                                          R$3,50
7  Doces         Bomba de Morango                                                      R$4,99
8  Sanduiches    Filé-Mignon com fritas e Cheddar                              R$25,69
9  Sanduiches    Hambúrguer com Queijo,Champignon e rúcula         R$15,60
10 Sanduiches   Provolone com salame                                              R$10,50
11 Sanduiches   Vegetariano de berinjela                                            R$19,30
12 Pizzas       Calabresa                                                                       R$15,89
13 Pizzas       Napolitana                                                                     R$19,90
14 Pizzas       Peruana                                                                         R$21,75
15 Pizzas       Portuguesa                                                                    R$26,50";


        }
        public void Pedido1()
        {
            try
            {
                if (Convert.ToInt32(txt_Pedido1.Text) == 1)
                {
                    pedido1 = NumeroPedido1;
                }
                else if (Convert.ToInt32(txt_Pedido1.Text) == 2)
                {
                    pedido1 = NumeroPedido2;
                }
                else if (Convert.ToInt32(txt_Pedido1.Text) == 3)
                {
                    pedido1 = NumeroPedido3;
                }
                else if (Convert.ToInt32(txt_Pedido1.Text) == 4)
                {
                    pedido1 = NumeroPedido4;
                }
                else if (Convert.ToInt32(txt_Pedido1.Text) == 5)
                {
                    pedido1 = NumeroPedido5;
                }
                else if (Convert.ToInt32(txt_Pedido1.Text) == 6)
                {
                    pedido1 = NumeroPedido6;
                }
                else if (Convert.ToInt32(txt_Pedido1.Text) == 7)
                {
                    pedido1 = NumeroPedido7;
                }
                else if (Convert.ToInt32(txt_Pedido1.Text) == 8)
                {
                    pedido1 = NumeroPedido8;
                }
                else if (Convert.ToInt32(txt_Pedido1.Text) == 9)
                {
                    pedido1 = NumeroPedido9;
                }
                else if (Convert.ToInt32(txt_Pedido1.Text) == 10)
                {
                    pedido1 = NumeroPedido10;
                }
                else if (Convert.ToInt32(txt_Pedido1.Text) == 11)
                {
                    pedido1 = NumeroPedido11;
                }
                else if (Convert.ToInt32(txt_Pedido1.Text) == 12)
                {
                    pedido1 = NumeroPedido12;
                }
                else if (Convert.ToInt32(txt_Pedido1.Text) == 13)
                {
                    pedido1 = NumeroPedido13;
                }
                else if (Convert.ToInt32(txt_Pedido1.Text) == 14)
                {
                    pedido1 = NumeroPedido14;
                }
                else if (Convert.ToInt32(txt_Pedido1.Text) == 15)
                {
                    pedido1 = NumeroPedido15;
                }
            }

            catch (Exception)
            {
                MessageBox.Show("Preencha corretamente!");
                txt_Pedido1.Focus();
                return;
            }
        }
        public void Pedido2()
        {
            try
            {
                if (Convert.ToInt32(txt_Pedido2.Text) == 1)
                {
                    pedido2 = NumeroPedido1;
                }
                else if (Convert.ToInt32(txt_Pedido2.Text) == 2)
                {
                    pedido2 = NumeroPedido2;
                }
                else if (Convert.ToInt32(txt_Pedido2.Text) == 3)
                {
                    pedido2 = NumeroPedido3;
                }
                else if (Convert.ToInt32(txt_Pedido2.Text) == 4)
                {
                    pedido2 = NumeroPedido4;
                }
                else if (Convert.ToInt32(txt_Pedido2.Text) == 5)
                {
                    pedido2 = NumeroPedido5;
                }
                else if (Convert.ToInt32(txt_Pedido2.Text) == 6)
                {
                    pedido2 = NumeroPedido6;
                }
                else if (Convert.ToInt32(txt_Pedido2.Text) == 7)
                {
                    pedido2 = NumeroPedido7;
                }
                else if (Convert.ToInt32(txt_Pedido2.Text) == 8)
                {
                    pedido2 = NumeroPedido8;
                }
                else if (Convert.ToInt32(txt_Pedido2.Text) == 9)
                {
                    pedido2 = NumeroPedido9;
                }
                else if (Convert.ToInt32(txt_Pedido2.Text) == 10)
                {
                    pedido2 = NumeroPedido10;
                }
                else if (Convert.ToInt32(txt_Pedido2.Text) == 11)
                {
                    pedido2 = NumeroPedido11;
                }
                else if (Convert.ToInt32(txt_Pedido2.Text) == 12)
                {
                    pedido2 = NumeroPedido12;
                }
                else if (Convert.ToInt32(txt_Pedido2.Text) == 13)
                {
                    pedido2 = NumeroPedido13;
                }
                else if (Convert.ToInt32(txt_Pedido2.Text) == 14)
                {
                    pedido2 = NumeroPedido14;
                }
                else if (Convert.ToInt32(txt_Pedido2.Text) == 15)
                {
                    pedido2 = NumeroPedido15;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Preencha corretamente!");
                txt_Pedido2.Focus();
                return;
            }
           
        }
        public void Pedido3()
        {
            try
            {
                if (Convert.ToInt32(txt_Pedido3.Text) == 1)
                {
                    pedido3 = NumeroPedido1;
                }
                else if (Convert.ToInt32(txt_Pedido3.Text) == 2)
                {
                    pedido3 = NumeroPedido2;
                }
                else if (Convert.ToInt32(txt_Pedido3.Text) == 3)
                {
                    pedido3 = NumeroPedido3;
                }
                else if (Convert.ToInt32(txt_Pedido3.Text) == 4)
                {
                    pedido3 = NumeroPedido4;
                }
                else if (Convert.ToInt32(txt_Pedido3.Text) == 5)
                {
                    pedido3 = NumeroPedido5;
                }
                else if (Convert.ToInt32(txt_Pedido3.Text) == 6)
                {
                    pedido3 = NumeroPedido6;
                }
                else if (Convert.ToInt32(txt_Pedido3.Text) == 7)
                {
                    pedido3 = NumeroPedido7;
                }
                else if (Convert.ToInt32(txt_Pedido3.Text) == 8)
                {
                    pedido3 = NumeroPedido8;
                }
                else if (Convert.ToInt32(txt_Pedido3.Text) == 9)
                {
                    pedido3 = NumeroPedido9;
                }
                else if (Convert.ToInt32(txt_Pedido3.Text) == 10)
                {
                    pedido3 = NumeroPedido10;
                }
                else if (Convert.ToInt32(txt_Pedido3.Text) == 11)
                {
                    pedido3 = NumeroPedido11;
                }
                else if (Convert.ToInt32(txt_Pedido3.Text) == 12)
                {
                    pedido3 = NumeroPedido12;
                }
                else if (Convert.ToInt32(txt_Pedido3.Text) == 13)
                {
                    pedido3 = NumeroPedido13;
                }
                else if (Convert.ToInt32(txt_Pedido3.Text) == 14)
                {
                    pedido3 = NumeroPedido14;
                }
                else if (Convert.ToInt32(txt_Pedido3.Text) == 15)
                {
                    pedido3 = NumeroPedido15;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Preencha corretamente!");
                txt_Pedido3.Focus();
                return;
            }                       
        }
        public void Total()
        {
            Pedido1();
            Pedido2();
            Pedido3();

            total = pedido1 + pedido2 + pedido3;
            lb_TotalPedido.Text = string.Format("Valor total do pedido {0:c}", total);
        }
        private void btn_FinalizarCompra_Click(object sender, EventArgs e)
        {
            Total();
        }
        private void txt_Pedido3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_FinalizarCompra.PerformClick();
            }
        }


    }
}

