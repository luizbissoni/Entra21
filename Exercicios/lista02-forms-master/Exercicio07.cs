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
    public partial class Exercicio07 : Form
    {
        int numero = 0; 
        public Exercicio07()
        {
            InitializeComponent();
        }

        private void btn_Executar_Click(object sender, EventArgs e)
        {
            Impar_Par();
            Negativo_Positivo();
            Maior10();
            MenorIgual30();
            MenorIgual50();
            MenorMenos10();
            Diferente1();

        }
        private void Numero()
        {

            try
            {
            numero = Convert.ToInt32(txt_Numero.Text);
           
            }
            catch (Exception)
            {
                MessageBox.Show("Preencha corretamente!");
                txt_Numero.Focus();
                return;
            }
        }
        private void Impar_Par()
        {
            Numero();

            string impar_par = "";

            if (numero % 2 == 0)
            {
                impar_par = "\n\rO número é par\n\r";
            }
            else if (numero % 2 == 1)
            {
                impar_par = "\n\rO número é impar\n\r";
            }
            else
            {
                impar_par = "\n\rO número é neutro\n\r";
            }
            lb_Total.Text += impar_par;
        }
        private void Negativo_Positivo()
        {
            Numero();

            string negativo_positivo = "";

            if (numero > 0)
            {
                negativo_positivo = "\n\rNúmero e Positivo\n\r";
            }
            else if (numero < 0)
            {
                negativo_positivo = "\n\rNúmero e Negativo\n\r";
            }
            else if (numero == 0)
            {
                negativo_positivo = "\n\rNúmero é igual a Zero\n\r";
            }
            lb_Total.Text += negativo_positivo;
        }
        private void Maior10()
        {
            Numero();

            string maior10 = "";

            if (numero > 10)
            {
                maior10 = "\n\rNúmero é maior que 10\n\r";
            }
            lb_Total.Text += maior10;
        }
        private void MenorMenos10()
        {
            Numero();
            string menorMenos10 = "";

            if (numero < -10)
            {
                menorMenos10 = "\n\rNúmero é menor que -10\n\r";
            }
            lb_Total.Text += menorMenos10;
        }
        private void MenorIgual50()
        {
            Numero();
            string menorIgual50 = "";
            if (numero == 50)
            {
                menorIgual50 = "\n\rNúmero é igual a 50\n\r";
            }
            else if(numero < 50)
            {
                menorIgual50 = "\n\rNúmero é menor que 50\n\r";
            }
            lb_Total.Text += menorIgual50;

        }
        private void MenorIgual30()
        {
            Numero();

            string menorIgual30 = "";

            if (numero == 30)
            {
                menorIgual30 = "\n\rNúmero é igual a 30\n\r";
            }
            else if (numero < 30) 
            {
                menorIgual30 = "\n\rNúmero é menor que 30\n\r";
            }
            lb_Total.Text += menorIgual30;
        }
        private void Diferente1()
        {
            Numero();

            string diferente1 = "";

            if (numero != 1)
            {
                diferente1 = "\n\rNúmero é diferente de 1\n\r";
            }
            lb_Total.Text += diferente1;
        }

        private void txt_Numero_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Executar.PerformClick();
            }
            
        }

      

    
    }
}
