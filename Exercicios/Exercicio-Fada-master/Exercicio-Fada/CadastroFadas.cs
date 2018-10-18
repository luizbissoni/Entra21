using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio_Fada
{
    public partial class CadastroFadas : Form
    {
        string nomeAntigo = string.Empty;
        List<Fada> fadas = new List<Fada>();


        public CadastroFadas()
        {
            InitializeComponent();
        }

        private void btn_Cadastro_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            try
            {
                Fada fada = new Fada(txt_Nome.Text, cb_Familia.SelectedItem.ToString(),
                    cb_Masculino.Checked ? true : false, cb_Cor.SelectedItem.ToString(), cb_CorAsa.SelectedItem.ToString(), Convert.ToDouble(txt_TamanhoAsa.Text),
                   cb_AsaQuebrada.Checked ? true : false, cb_FazBarulho.Checked ? true : false, cb_Elemento.SelectedItem.ToString());

                if (nomeAntigo == string.Empty)
                {
                    MessageBox.Show("Salvo com sucesso.");
                    fadas.Add(fada);
                    tabControl1.SelectedIndex = 0;
                    ListaFadaCadastradas(fada);
                }

                else
                {
                    int linhaEditarCadastroRapido = fadas.FindIndex(x => x.Nome == nomeAntigo);
                    fadas[linhaEditarCadastroRapido] = fada;
                    EditarCadastro(fada, linhaEditarCadastroRapido);
                    MessageBox.Show("Alterado com sucesso.");
                    nomeAntigo = string.Empty;
                    tabControl1.SelectedIndex = 0;
                }


                LimpaCampos();
            }
            catch (Exception)
            {
                MessageBox.Show("Preencha corretamente.");
                return;
            }

        }

        private void EditarCadastro(Fada fada, int linhaEditarCadastro)
        {
            dgv_ListaFada.Rows[linhaEditarCadastro].Cells[0].Value = fada.Nome;
            dgv_ListaFada.Rows[linhaEditarCadastro].Cells[1].Value = fada.Familia;
            dgv_ListaFada.Rows[linhaEditarCadastro].Cells[2].Value = fada.Sexo;
            dgv_ListaFada.Rows[linhaEditarCadastro].Cells[3].Value = fada.TamanhoAsa;
            dgv_ListaFada.Rows[linhaEditarCadastro].Cells[4].Value = fada.CorAsa;
            dgv_ListaFada.Rows[linhaEditarCadastro].Cells[5].Value = fada.Elemento;

        }

        public void ListaFadaCadastradas(Fada fada)
        {
            string cadastroRapidoTrue = string.Empty, sexo = string.Empty;

            dgv_ListaFada.Rows.Add(new Object[] {fada.Nome,fada.Familia,sexo = fada.Sexo ? "Masculino":"Feminino",fada.TamanhoAsa,
                fada.CorAsa,fada.Elemento, cadastroRapidoTrue = fada.CadastroRapido ? "SIM":"NÃO" });

        }

        private void LimpaCampos()
        {
            txt_Nome.Text = string.Empty;
            txt_TamanhoAsa.Text = string.Empty;
            cb_AsaNaoQuebrada.Checked = false;
            cb_AsaQuebrada.Checked = false;
            cb_Cor.SelectedIndex = -1;
            cb_CorAsa.SelectedIndex = -1;
            cb_Elemento.SelectedIndex = -1;
            cb_Familia.SelectedIndex = -1;
            cb_FazBarulho.Checked = false;
            cb_Feminino.Checked = false;
            cb_Masculino.Checked = false;
            cb_NaoFazBarulho.Checked = false;
        }

        private void dgv_ListaFada_DoubleClick(object sender, EventArgs e)
        {

            int linhaSelecionada = dgv_ListaFada.CurrentRow.Index, numero = 0;
            string nome = dgv_ListaFada.Rows[linhaSelecionada].Cells[0].Value.ToString();
            foreach (Fada fada in fadas)
            {
                if (fada.CadastroRapido)
                {
                    txt_NomeRapido1.Text = fada.Nome;
                    cb_FamiliaRapida1.Text = fada.Familia;
                    cb_ElementoRapido1.Text = fada.Elemento;
                    cb_MasculinoRapido1.Checked = fada.Sexo ? true : cb_FemininoRapido1.Checked;
                    numero = 2;
                    break;
                }
                else if (fada.Nome == nome)
                {
                    txt_Nome.Text = fada.Nome;
                    txt_TamanhoAsa.Text = Convert.ToString(fada.TamanhoAsa);
                    cb_AsaQuebrada.Checked = fada.AsaQuebrada ? true : cb_AsaNaoQuebrada.Checked;
                    cb_Cor.Text = fada.Cor;
                    cb_CorAsa.Text = fada.CorAsa;
                    cb_Elemento.Text = fada.Elemento;
                    cb_Familia.Text = fada.Familia;
                    cb_FazBarulho.Checked = fada.FazBarulho ? true : cb_NaoFazBarulho.Checked;
                    cb_Masculino.Checked = fada.Sexo ? true : cb_Feminino.Checked;
                    nomeAntigo = fada.Nome;
                    numero = 1;
                    break;
                }
            }
            tabControl1.SelectedIndex = numero; 
        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            if (dgv_ListaFada.Rows.Count == 0)
            {
                MessageBox.Show("Cadastre uma fada.");
                return;
            }
            if (dgv_ListaFada.CurrentRow == null)
            {
                MessageBox.Show("Selecione algo no grid.");
                return;
            }
            int linhaSelecionada = dgv_ListaFada.CurrentRow.Index;
            string nome = dgv_ListaFada.Rows[linhaSelecionada].Cells[0].ToString();
            DialogResult resultado = MessageBox.Show("Deseja apagar registro ?", "AVISO", MessageBoxButtons.YesNo);
            if (resultado == DialogResult.Yes)
            {
                for (int i = 0; i < fadas.Count(); i++)
                {
                    Fada fada = fadas[i];
                    if (fada.Nome == nome)
                    {
                        fadas.RemoveAt(i);
                    }
                }
            }

            dgv_ListaFada.Rows.RemoveAt(linhaSelecionada);

        }

        private void btn_CadastroRapido_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2;
        }

        private void btn_SalvarRapido_Click(object sender, EventArgs e)
        {
            try
            {
                Fada fada = new Fada(txt_NomeRapido1.Text, cb_FamiliaRapida1.SelectedItem.ToString(),
                    cb_ElementoRapido1.SelectedItem.ToString(), true);
                MessageBox.Show("Cadastro Rapido salvo com sucesso.");
                fadas.Add(fada);
                ListaFadaCadastradas(fada);
                LimpaCampoRapido();
                tabControl1.SelectedIndex = 0;
            }
            catch (Exception)
            {
                MessageBox.Show("Preencha corretamente.");
                return;
            }
           
        }

        private void LimpaCampoRapido()
        {
            txt_NomeRapido1.Text = string.Empty;
            cb_ElementoRapido1.SelectedIndex = -1;
            cb_FamiliaRapida1.SelectedIndex = -1;
            cb_FemininoRapido1.Checked = false;
            cb_MasculinoRapido1.Checked = false;
        }

        private void txt_Nome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar)||(char.IsSymbol(e.KeyChar))||(char.IsWhiteSpace(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void txt_TamanhoAsa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || (char.IsSymbol(e.KeyChar)) || (char.IsWhiteSpace(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void txt_NomeRapido1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || (char.IsSymbol(e.KeyChar)) || (char.IsWhiteSpace(e.KeyChar)))
            {
                e.Handled = true;
            }
        }







    }
}
