using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExemploListaWFA
{
    public partial class Exemplo01 : Form
    {
        List<Int32> numeros = new List<Int32>();

        public Exemplo01()
        {
            InitializeComponent();
        }

        private void bnt_Cadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                int numero = Convert.ToInt32(txt_Numero.Text);
                numeros.Add(numero);
                cb_Selecionar.Items.Add(numero);//alimenta um combo box
                txt_Numero.Text = "";
                MessageBox.Show(string.Format("Número {0} cadastrado com sucesso", numero));
                txt_Numero.Focus();
            }
            catch (Exception)
            {
                MessageBox.Show("Preencha corretamente!");
            }


        }

        private void btn_Processar_Click(object sender, EventArgs e)
        {
            rtb_Numero.Clear();
            for (int i = 0; i < numeros.Count; i++)
            {
                rtb_Numero.AppendText(Convert.ToString(numeros[i] + "\n"));
            }
        }

        private void txt_Numero_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Processar.PerformClick();
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DialogResult dialogResulto = MessageBox.Show("Você realmente deseja apagar", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Error
                     );
                if (dialogResulto == DialogResult.Yes)
                {
                    int posicao = Convert.ToInt32(txt_Apagar.Text);
                    numeros.RemoveAt(posicao);
                    btn_Processar.PerformClick();
                    txt_Apagar.Text = "";
                    MessageBox.Show("Registro apagado com sucesso");
                    AtualizarComboBoxParaEditar(); // atualizar depois de excluir
                    txt_Numero.Focus();
                }
                else
                {
                    MessageBox.Show("Tais salvo!");
                }


            }
        }

        private void txt_ValorparaApagar_Leave(object sender, EventArgs e)
        {
            int valor = Convert.ToInt32(txt_ValorparaApagar.Text);

            while (numeros.Contains(valor))
            {
                numeros.Remove(valor);
            }

            txt_ValorparaApagar.Text = "";
            AtualizarComboBoxParaEditar(); // atualiza depois de excluir
            MessageBox.Show(valor + "apagado com sucesso");
            btn_Processar.PerformClick();
        }

        private void AtualizarComboBoxParaEditar()
        {
            //atualiza um combo box
            cb_Selecionar.Items.Clear();
            for (int i = 0; i < numeros.Count; i++)
            {
                cb_Selecionar.Items.Add(numeros[i]);
            }
        }

        private void cb_Selecionar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_Selecionar.SelectedIndex > -1 ) // tem que ser menor que zero
            {
                txt_NumeroEditar.Enabled = true;
                txt_NumeroEditar.Focus();
            }
        }

        private void txt_NumeroEditar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int posicao = cb_Selecionar.SelectedIndex;
                int valorNovo = Convert.ToInt32(txt_NumeroEditar.Text);

                numeros[posicao] = valorNovo;

                txt_NumeroEditar.Text = "";
                txt_NumeroEditar.Enabled = false;
                cb_Selecionar.SelectedIndex = -1;
                AtualizarComboBoxParaEditar();
                MessageBox.Show("Número alterado com sucesso!");

            }
        }
    }
}
