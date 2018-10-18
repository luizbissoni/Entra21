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
    public partial class Exercicio09 : Form
    {
        public Exercicio09()
        {
            InitializeComponent();
        }

        private void txt_Numero4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Executar.PerformClick();
            }
        }

        private void btn_Executar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(txt_Numero1.Text) == Convert.ToInt32(txt_Numero2.Text) && Convert.ToInt32(txt_Numero3.Text) == Convert.ToInt32(txt_Numero4.Text))
                {
                    lb_Resultado.Text = "É um quadrado";
                }
                else
                {
                    lb_Resultado.Text = "Não é um quadrado";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Preencha corretamente!");
            }

        }
    }
}
