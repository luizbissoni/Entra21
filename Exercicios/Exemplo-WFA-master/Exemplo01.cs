using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExemploWFA
{
    public partial class Exemplo01 : Form
    {
        public Exemplo01()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Boa tarde "+ txtNome.Text + txtSobreNome.Text);
           

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            double nota1 = 0;
            double nota2 = 0;
            double nota3 = 0;
            double nota4 = 0;
            double nota5 = 0;
            try
            {
            nota1 = Convert.ToDouble(txtNota1.Text);
            }
            catch 
            {
                MessageBox.Show("nota 1 Somente números!");
                txtNota1.Focus();
                return;
            }
            try
            {
            nota2 = Convert.ToDouble(txtNota2.Text);
            }
            catch 
            {
                MessageBox.Show("nota 2 Somente números!");
                txtNota2.Focus();
                return;
            }
            try
            {
            nota3 = Convert.ToDouble(txtNota3.Text);
            }
            catch
            {
                MessageBox.Show("nota 3 Somente números!");
                txtNota3.Focus();
                return;
            }
            try
            {
            nota4 = Convert.ToDouble(txtNota4.Text);

            }
            catch 
            {
                MessageBox.Show(" nota 4 Somente números!");
                txtNota4.Focus();
                return;
            }
            try
            {
            nota5 = Convert.ToDouble(txtNota5.Text);
            }
            catch
            {
                MessageBox.Show("nota 5 Somente números!");
                txtNota5.Focus();
                return;
            }

            double mediaNotas = (nota1 + nota2 + nota3 + nota4 + nota5) / 5;
            string textao = string.Format("\r\n nota 1 {0}\r\n nota 2 {1}\r\n nota 3 {2} \r\n nota 4 {3}\r\n\n nota 5 {4} \r\nMedia {5:n}", nota1,nota2,nota3,nota4,nota5,mediaNotas);

            txtResultado.Text = textao;
            //MessageBox.Show(string.Format("A média é: {0:n}", mediaNotas));

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            try
            {
                int idade = Convert.ToInt32(txtIdade.Text);
                if (idade < 0)
                {
                    MessageBox.Show("Idade não pode ser menor que zero");
                    txtIdade.Focus();
                    return;
                }
                if (idade > 150)
                {
                    MessageBox.Show("Idade não pode ser maior que 150");
                    txtIdade.Focus();
                    return;
                }
            }
            catch 
            {

                MessageBox.Show("Idade deve conter somente numeros inteiros");
                txtIdade.Focus();
            }
        }
    }
}
