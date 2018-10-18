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
    public partial class Exercicio02 : Form
    {
        public Exercicio02()
        {
            InitializeComponent();
        }

        private void btn_Executar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(txt_Numero.Text) < 0)
                {
                    txt_Resultado.Text = "Número Negativo";
                }
                else
                {
                    txt_Resultado.Text = "Número não e Negativo";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Preencha corretamente!");
                txt_Numero.Focus();
                return;
            }

        }
    }
}
