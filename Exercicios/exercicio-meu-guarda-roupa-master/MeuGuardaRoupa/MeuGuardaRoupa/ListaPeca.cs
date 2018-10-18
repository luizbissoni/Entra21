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
    public partial class ListaPeca : Form
    {
        public ListaPeca()
        {
            InitializeComponent();
        }

        private void ListaPeca_Load(object sender, EventArgs e)
        {
            AtualizarLista();
        }

        private void AtualizarLista()
        {
            dgv_ListaPeca.Rows.Clear();
            string busca = txt_Busca.Text.ToLower();

            for (int i = 0; i < Program.pecas.Count; i++)
            {
                Peca peca = Program.pecas[i];
                if (peca.Ativo == true && (peca.Nome.Contains(busca) || peca.Marca.Contains(busca))) //busca com filtro
                {
                    dgv_ListaPeca.Rows.Add(new object[] { peca.Nome, peca.Cor, peca.Marca, 
                    peca.Valor, peca.Tipo, peca.Tecido, peca.DataCompra });
                }
            }

        }

        private void btn_Cadastrar_Click(object sender, EventArgs e)
        {
            new CadastroPeca().ShowDialog();
        }

        private void btn_Atualizar_Click(object sender, EventArgs e)
        {
            AtualizarLista();
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            if (dgv_ListaPeca.CurrentRow == null)
            {
                MessageBox.Show("Não tem nenhuma peça selecionada");
                return;
            }

            int linhaSelecionada = dgv_ListaPeca.CurrentRow.Index;
            Peca peca = Program.pecas[linhaSelecionada];
            new CadastroPeca(peca, linhaSelecionada).ShowDialog();
        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            if (dgv_ListaPeca.CurrentRow == null)
            {
                MessageBox.Show("Não tem nenhuma peça selecionada");
                return;
            }

            int linhaSelecionada = dgv_ListaPeca.CurrentRow.Index;
            Peca peca = Program.pecas[linhaSelecionada];
            DialogResult resultado = MessageBox.Show("Deseja apagar" + peca.Nome + "do registro ?", "AVISO", MessageBoxButtons.YesNo);

            if (resultado == DialogResult.Yes)
            {
                Program.pecas.RemoveAt(linhaSelecionada);
                AtualizarLista();
                MessageBox.Show("Registro apagado com sucesso");

            }
        }

        private void ListaPeca_Activated(object sender, EventArgs e)
        {
            AtualizarLista();
        }

        private void txt_Busca_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.Enter )
            {
                AtualizarLista();
            }
        }

        private void txt_Busca_Leave(object sender, EventArgs e)
        {
            AtualizarLista();
        }






    }
}
