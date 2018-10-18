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
    public partial class Exemplo02 : Form
    {
        public Exemplo02()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text.Trim();
            int quantidadeHoras = Convert.ToInt32(txtQuantidadeHoras.Text);
            double valorHora = Convert.ToDouble(txtValorHora.Text);
            double salario = valorHora * quantidadeHoras;

            string cidade = txb_Cidade.Text.Trim();
            string bairro = txb_Bairro.Text.Trim();
            string complemento = txb_Complemento.Text.Trim();
            string uf = cb_UF.SelectedItem.ToString();
            string numero = txb_Numero.Text.Trim();
            bool Feminino = rbFeminino.Checked;
            string dataNascimento = dtpDataNascimento.Text;

            if (salario < 1000)
            {
                MessageBox.Show("Professor");
            }
            else if (salario < 100000)
            {
                MessageBox.Show("Professor de Fortnite");
            }
            else if (salario < 1000000)
            {
                MessageBox.Show("Professor de Dota2");
            }
            else if (salario <500000)
            {
                MessageBox.Show("Professor de Tibia");
            }
            else
            {
                MessageBox.Show("Mestre pleno de tibia");
            }

        }

       


       
       

      
      
    }
}
