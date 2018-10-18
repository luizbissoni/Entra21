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
    public partial class Exercicio11 : Form
    {
        public Exercicio11()
        {
            InitializeComponent();
        }

        private void txt_Nota4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ResultadoMedia();
            }
        }
        private void ResultadoMedia()
        {
            double media = Convert.ToDouble(txt_Nota1.Text) + Convert.ToDouble(txt_Nota2.Text) + Convert.ToDouble(txt_Nota3.Text) + Convert.ToDouble(txt_Nota4.Text) / 4;
            if (media < 5.99)
            {
                lbl_Resultado.Text = "Reprovado";
            }
            else if ((media  <= 6.00)||(media < 7.99))
            {
                lbl_Resultado.Text = "Recuperação";
            }
            else if (media > 7.99)
            {
                lbl_Resultado.Text = "Aprovado";
            }
        }
   
    }
}
