using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeuGuardaRoupa
{
    public partial class CadastroPeca : Form
    {
        public int posicao = -1;

        public CadastroPeca()
        {
            InitializeComponent();
            for (int i = 0; i <= 60; i++)
            {
                cb_Tamanho.Items.Add(i);
            }
        }

        public CadastroPeca(Peca peca, int posicao)
        {
            InitializeComponent();
            txt_Nome.Text = peca.Nome;
            txt_Valor.Text = Convert.ToString(peca.Valor);
            cb_Cor.SelectedItem = peca.Cor;
            cb_Marca.SelectedItem = peca.Marca;
            cb_Tamanho.Text = peca.Tamanho;
            cb_Tecido.SelectedItem = peca.Tecido;
            cb_Tipo.SelectedItem = peca.Tipo;
            dtp_DataCompra.Value = peca.DataCompra;
        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            if (txt_Nome.Text.Length <4)
            {
                MessageBox.Show("Nome deve conter no minimo 4 caratceres");
                txt_Nome.Focus();
                return;
            }
            if (cb_Tipo.SelectedIndex <0)
            {
                MessageBox.Show("selecione o tipo da peça");
                cb_Tipo.DroppedDown = true;
                return;
            }
            if (cb_Tamanho.SelectedIndex <0)
            {
                MessageBox.Show("Selecione o tamanho");
                cb_Tamanho.DroppedDown = true;
                return;
            }
            if (txt_Valor.Text.Length == 0)
            {
                MessageBox.Show("Valor deve ser preenchido");
                txt_Valor.Focus();
                return;
            }
            try
            {
                double valor = Convert.ToDouble(txt_Valor.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Valor deve conter somente numeros reais");
                txt_Valor.Focus();
                return;
            }
            if (cb_Marca.SelectedIndex < 0 )
            {
                MessageBox.Show("Selecione a marca");
                cb_Marca.DroppedDown = true;
                return;
            }
            if (cb_Cor.SelectedIndex < 0)
            {
                MessageBox.Show("Selecione a cor");
                cb_Cor.DroppedDown = true;
                return;
            }
            if (cb_Tecido.SelectedIndex <0)
            {
                MessageBox.Show("Selecione o tecido");
                cb_Tecido.DroppedDown = true;
                return;
            }
            if (dtp_DataCompra.Value.Date > DateTime.Now.Date)
            {
                MessageBox.Show("Data da compra deve ser hoje ou uma data anterior");
                return;
            }
            Peca peca = new Peca()
            {
                Nome = txt_Nome.Text,
                Cor = cb_Cor.SelectedItem.ToString(),
                Tipo = cb_Tipo.SelectedItem.ToString(),
                Tamanho = cb_Tamanho.SelectedItem.ToString(),
                Valor = Convert.ToDouble(txt_Valor.Text),
                Tecido = cb_Tecido.SelectedItem.ToString(),
                DataCompra = dtp_DataCompra.Value,
                Marca = cb_Marca.SelectedItem.ToString(),
                Ativo = rb_Ativo.Checked
            };
            Program.pecas.Add(peca);
            LimparCampos();
        }

        private void LimparCampos()
        {
            txt_Nome.Text = "";
            txt_Valor.Text = "";
            cb_Cor.SelectedIndex = -1;
            cb_Marca.SelectedIndex = -1;
            cb_Tamanho.SelectedIndex = -1;
            cb_Tecido.SelectedIndex = -1;
            cb_Tipo.SelectedIndex = -1;
            dtp_DataCompra.Value = DateTime.Now;

        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        public void Editar(Peca peca, int posicao)
        {
            InitializeComponent();
            for (int i = 0; i <= 60; i++)
            {
                cb_Tamanho.Items.Add(i);
            }

            this.posicao = posicao;
            txt_Nome.Text = peca.Nome;
            txt_Valor.Text = Convert.ToString(peca.Valor);
            cb_Cor.SelectedItem = peca.Cor;
            cb_Marca.SelectedItem = peca.Marca;
            cb_Tamanho.SelectedItem = peca.Tamanho;
            cb_Tecido.SelectedItem = peca.Tecido;
            cb_Tipo.SelectedItem = peca.Tipo;
            dtp_DataCompra.Value = peca.DataCompra;
        }

        
    }
}
