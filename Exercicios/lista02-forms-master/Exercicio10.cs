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
    public partial class Exercicio10 : Form
    {
        public Exercicio10()
        {
            InitializeComponent();
        }

        private void txt_Numero4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    if (Convert.ToInt32(txt_Numero1.Text) == Convert.ToInt32(txtNumero2.Text) || Convert.ToInt32(txt_Numero1.Text) == Convert.ToInt32(txt_Numero4.Text))
                    {
                        lb_Resultado.Text = "É um retangulo";
                    }
                    else if (Convert.ToInt32(txtNumero2.Text) == Convert.ToInt32(txt_Numero3.Text) || Convert.ToInt32(txtNumero2.Text) == Convert.ToInt32(txt_Numero4.Text))
                    {
                        lb_Resultado.Text = "É um retangulo";
                    }

                    else
                    {
                        lb_Resultado.Text = "Não é um retangulo";
                    }
                }
                catch (Exception)
                {

                    MessageBox.Show("Preencha corretamente!");
                }
            }
        }
    }
}
