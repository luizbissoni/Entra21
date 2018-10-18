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
    public partial class Exercicio03 : Form
    {
        public Exercicio03()
        {
            InitializeComponent();
        }

        private void btn_Executar_Click(object sender, EventArgs e)
        {
            try
            {
                if (rb_Somar.Checked)
                {
                    txt_Resultado.Text = string.Format("Número {0} + Numero {1} = {2}", txt_Numero1.Text, txt_Numero2.Text, (Convert.ToInt32(txt_Numero1.Text) + Convert.ToInt32(txt_Numero2.Text)));
                }
                if (rb_Subtrair.Checked)
                {
                    txt_Resultado.Text = string.Format("Número {0} - Número {1} = {2}", txt_Numero1.Text, txt_Numero2.Text, (Convert.ToInt32(txt_Numero1.Text) - Convert.ToInt32(txt_Numero2.Text)));
                }
                if (rb_Multiplicar.Checked)
                {
                    txt_Resultado.Text = string.Format("Número {0} X Número {1} = {2}", txt_Numero1.Text, txt_Numero2.Text, (Convert.ToInt32(txt_Numero1.Text) * Convert.ToInt32(txt_Numero2.Text)));
                }
                if (rb_Dividir.Checked)
                {
                    txt_Resultado.Text = string.Format("Número {0} / Número {1} = {2}", txt_Numero1.Text, txt_Numero2.Text, (Convert.ToDouble(txt_Numero1.Text) / Convert.ToDouble(txt_Numero2.Text)));
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Preencha corretamente!");
                return;
            }
        }
    }
}
