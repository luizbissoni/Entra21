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
    public partial class Exercicio12 : Form
    {
        public Exercicio12()
        {
            InitializeComponent();
        }

        private void txt_Numero2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                MaiorNumero();
            }
        }
        private void MaiorNumero()
        {
            try
            {
                int maiorNumero = 0;

                if (Convert.ToInt32(txt_Numero1.Text) > maiorNumero)
                {
                    maiorNumero = Convert.ToInt32(txt_Numero1.Text);
                }
                else if (Convert.ToInt32(txt_Numero2.Text) > maiorNumero)
                {
                    maiorNumero = Convert.ToInt32(txt_Numero2.Text);
                }
                lb_Resultado.Text = string.Format("Maior número {0}", maiorNumero);
            }
            catch (Exception)
            {
                MessageBox.Show("Preencha corretamente!");
                txt_Numero1.Focus();
                return;
            }

        }
    }
}
