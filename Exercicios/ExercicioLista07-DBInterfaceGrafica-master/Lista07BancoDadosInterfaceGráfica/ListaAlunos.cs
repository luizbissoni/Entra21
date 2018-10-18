using Lista07BancoDadosInterfaceGráfica.Model;
using Lista07BancoDadosInterfaceGráfica.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lista07BancoDadosInterfaceGráfica
{
    public partial class ListaAlunos : Form
    {
        public ListaAlunos()
        {
            InitializeComponent();
        }

        private void btn_Cadastrar_Click(object sender, EventArgs e)
        {
            new CadastroAlunos().ShowDialog();
        }

        private void dgv_ListaAlunos_DoubleClick(object sender, EventArgs e)
        {
            int linhaSelecionada = dgv_ListaAlunos.CurrentRow.Index;
            int codigo = Convert.ToInt32(dgv_ListaAlunos.Rows[linhaSelecionada].Cells[0].Value.ToString());
            new CadastroAlunos(codigo).ShowDialog();
        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            int linhaSelecionada = dgv_ListaAlunos.CurrentRow.Index;
            int codigo = Convert.ToInt32(dgv_ListaAlunos.Rows[linhaSelecionada].Cells[0].Value.ToString());
            bool apagado = new AlunosRepository().Apagar(codigo);
            if (apagado)
            {
                dgv_ListaAlunos.Rows.RemoveAt(linhaSelecionada);
                MessageBox.Show("Registro apagado com sucesso");
            }
            else
            {
                MessageBox.Show("Não foi possivel apagar");
            }
        }

        private void ListaAlunos_Load(object sender, EventArgs e)
        {
            AtualizarLista();
        }

        private void AtualizarLista()
        {
            string coluna = "nome";
            
            string tipoOrdenacao = "ASC";

            if (rb_Frequencia.Checked)
            {
                coluna = "frequencia";
            }
            if (rb_DESC.Checked)
            {
                tipoOrdenacao = "DESC";
            }

            dgv_ListaAlunos.Rows.Clear();
            List<AlunosModel> alunos = new AlunosRepository().obeterTodos(txt_Busca.Text, coluna, tipoOrdenacao);

            foreach (AlunosModel aluno in alunos)
            {
                
                dgv_ListaAlunos.Rows.Add(new object[] { aluno.Id, aluno.Nome, aluno.Nota_1, aluno.Nota_2, aluno.Nota_3, aluno.Frequencia, aluno.SituacaoAluno });
            }
        }

        private void btn_Atualizar_Click(object sender, EventArgs e)
        {
            AtualizarLista();
        }
    }
}
