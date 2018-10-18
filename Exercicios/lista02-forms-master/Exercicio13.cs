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
    public partial class Exercicio13 : Form
    {
        public Exercicio13()
        {
            InitializeComponent();
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                MenorNumero();
            }
        }
        private void MenorNumero()
        {
            try
            {
                int numero1 = Convert.ToInt32(txt_Numero1.Text), numero2 = Convert.ToInt16(txt_Numero2.Text), menorNumero = int.MaxValue;

                if (numero1 < menorNumero)
                {
                    menorNumero = numero1;
                }
                else if (numero2 < menorNumero)
                {
                    menorNumero = numero2;
                }

                lb_Resultado.Text = string.Format("Menor número {0}", menorNumero);

            }
            catch (Exception)
            {
                MessageBox.Show("Preencha corretamente!");
            }

        }
    }
}
