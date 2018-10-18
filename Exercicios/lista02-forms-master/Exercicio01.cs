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
    public partial class Exercicio01 : Form
    {
        public Exercicio01()
        {
            InitializeComponent();
        }

        private void btn_Executar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(txt_Numero.Text) > 1)
                {
                    txt_Resultado.Text = "Número é Positivo";
                }
                else
                {
                    txt_Resultado.Text ="Número não é Positivo";
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
