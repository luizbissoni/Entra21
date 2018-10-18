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
    public partial class Exemplo03 : Form
    {
        int quantidade1 = 0, quantidade2 = 0, quantidade3 = 0;
        double valor1 = 0, valor2 = 0, valor3 = 0, total = 0;
        public Exemplo03()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {

            ArmazenarInformacoes();

            if (rb_Somar.Checked)
            {
                Somar();
            }
            else if (rb_Media.Checked)
            {
                Media();
            }
            else if (rb_Maior.Checked)
            {
                Maior();
            }
            else if (rb_Menor.Checked)
            {
                Menor();
            }
            else
            {
                MessageBox.Show("Selecione um dos check box");
            }
        }
        public void Somar()
        {
            MessageBox.Show("Soma: " + total);
        }
        public void Media()
        {
            double mediaTotal = total / 3;
            MessageBox.Show(string.Format("Média:{0:n}", mediaTotal));
        }
        public void Maior()
        {

            int maior = 0;
            double maiorValor = 0, maiorQuantidade = 0;
            string _nome1 = txb_Nome1.Text;
            string _nome2 = txb_Nome2.Text;
            string _nome3 = txb_Nome3.Text;

            if (_nome1.Length > maior)
            {
                maior = _nome1.Length;
            }
            if (_nome2.Length > maior)
            {
                maior = _nome2.Length;
            }
            if (_nome3.Length > maior)
            {
                maior = _nome3.Length;
            }
            if (valor1 > maiorValor)
            {
                maiorValor = valor1;
            }
            if (valor2 > maiorValor)
            {
                maiorValor = valor2;
            }
            if (valor3 > maiorValor)
            {
                maiorValor = valor3;
            }
            if (quantidade1 > maiorQuantidade)
            {
                maiorQuantidade = quantidade1;
            }
            if (quantidade2 > maiorQuantidade)
            {
                maiorQuantidade = quantidade2;
            }
            if (quantidade3 > maiorQuantidade)
            {
                maiorQuantidade = quantidade3;
            }
            MessageBox.Show("Maior nome: ");
            MessageBox.Show("Maior Quantidade: " + maiorQuantidade);
            MessageBox.Show("Maior Valor: " + maiorValor);



        }
        public void Menor()
        {
            int menor = int.MaxValue;
            int menorQuantidade = int.MaxValue;
            double menorValor = int.MaxValue;

            if (txb_Nome1.Text.Length < menor)
            {
                menor = txb_Nome1.Text.Length;
                MessageBox.Show("Menor nome: " + txb_Nome1.Text);
            }
            if (txb_Nome2.Text.Length < menor)
            {
                menor = txb_Nome2.Text.Length;
                MessageBox.Show("Menor nome: " + txb_Nome2.Text);
            }
            if (txb_Nome3.Text.Length < menor)
            {
                MessageBox.Show("Menor nome: " + txb_Nome3.Text);
            }
            if (valor1 < menorValor)
            {
                menorValor = valor1;
            }
            if (valor2 < menorValor)
            {
                menorValor = valor2;
            }
            if (valor3 < menorValor)
            {
                menorValor = valor3;
            }
            if (quantidade1 < menorQuantidade)
            {
                menorQuantidade = quantidade1;
            }
            if (quantidade2 < menorQuantidade)
            {
                menorQuantidade = quantidade2;
            }

        }
        private void ArmazenarInformacoes()
        {
            quantidade1 = Convert.ToInt32(nud_Quantidade1.Value);
            valor1 = Convert.ToDouble(mtb_Valor1.Text);

            quantidade2 = Convert.ToInt32(nud_Quantidade2.Value);
            valor2 = Convert.ToDouble(mtb_Valor2.Text);

            quantidade3 = Convert.ToInt32(nud_Quantidade3.Value);
            valor3 = Convert.ToDouble(mtb_Valor3.Text);

            total = (quantidade1 * valor1) + (quantidade2 * valor2) + (quantidade3 * valor3);
        }


    }
}
