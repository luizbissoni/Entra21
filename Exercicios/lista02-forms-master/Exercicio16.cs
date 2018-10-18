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
    public partial class Exercicio16 : Form
    {
        public Exercicio16()
        {
            InitializeComponent();
        }

        private void btn_Converter_Click(object sender, EventArgs e)
        {
            ConvercaoTemperatura(); 
        }

        private void ConvercaoTemperatura()
        {
            try
            {
                if (rb_Celsius.Checked && rb_Fahrenheit2.Checked)
                {
                    CelsiuParaFahrenheit();
                }
                else if (rb_Celsius.Checked && rb_Kelvin2.Checked)
                {
                    CelsiuParaKelvin();
                }
                else if (rb_Fahrenheit.Checked && rb_Celsius2.Checked)
                {
                    FahrenheitParaCelsiu();
                }
                else if (rb_Fahrenheit.Checked && rb_Kelvin2.Checked)
                {
                    FahrenheitParaKelvin();
                }
                else if (rb_Kelvin.Checked && rb_Celsius2.Checked)
                {
                    KelvinParaCelsiu();
                }
                else if (rb_Kelvin.Checked && rb_Fahrenheit2.Checked)
                {
                    KelvinParaFahrenheit();
                }
                else
                {
                    MessageBox.Show("Selecione um Check box!");
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Preencha corretamente!");
                txt_Numero.Focus();
                return;
            }
        }
        private void rb_Celsius_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_Celsius.Checked)
            {
                rb_Celsius2.Visible = false;
            }
            else
            {
                rb_Celsius2.Visible = true;
            }
        }
        private void rb_Fahrenheit_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_Fahrenheit.Checked)
            {
                rb_Fahrenheit2.Visible = false;
            }
            else
            {
                rb_Fahrenheit2.Visible = true;
            }
        }
        private void rb_Kelvin_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_Kelvin.Checked)
            {
                rb_Kelvin2.Visible = false;
            }
            else
            {
                rb_Kelvin2.Visible = true;
            }
        }

        private void CelsiuParaFahrenheit()
        {
            double convercao = (Convert.ToInt32(txt_Numero.Text) * 9) / 5 + 32;
            lb_Resultado.Text = Convert.ToString(convercao);
        }
        private void CelsiuParaKelvin()
        {
            double convercao = Convert.ToInt32(txt_Numero.Text) + 273;
            lb_Resultado.Text = Convert.ToString(convercao);
        }
        private void FahrenheitParaCelsiu()
        {
            double convercao = (Convert.ToInt32(txt_Numero.Text) - 32) * (5 / 9);
            lb_Resultado.Text = Convert.ToString(convercao);
        }
        private void FahrenheitParaKelvin()
        {
            double convercao = (Convert.ToInt32(txt_Numero.Text) - 32) * (5/9) + 273;
            lb_Resultado.Text = Convert.ToString(convercao);
        }
        private void KelvinParaCelsiu()
        {
            double convercao = Convert.ToInt32(txt_Numero.Text) - 273;
            lb_Resultado.Text = Convert.ToString(convercao);
        }
        private void KelvinParaFahrenheit()
        {
           double convercao = ((Convert.ToInt32(txt_Numero.Text) - 273) * 1.8) + 32;
           lb_Resultado.Text = Convert.ToString(convercao);
        }

        private void txt_Numero_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ConvercaoTemperatura();
            }
        }


    }
}
