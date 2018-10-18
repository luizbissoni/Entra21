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
    public partial class Exercicio06 : Form
    {
        public Exercicio06()
        {
            InitializeComponent();
        }

        private void btn_Executar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(txt_Numero.Text) != 1)
                {
                    txt_Resultado.Text = string.Format("Número {0} é diferente de 1",txt_Numero.Text);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Preencha corretamente!");
            }
        }
    }
}
