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

namespace WFA
{
    public partial class ListaAlunosAdd : Form
    {
        public ListaAlunosAdd()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new CadastroAluno().ShowDialog();
        }

        private void ListaAlunosAdd_Activated(object sender, EventArgs e)
        {
            PopularListaAlunos();
        }

        private void PopularListaAlunos()
        {
            dgv_ListaAlunos.Rows.Clear();
            for (int i = 0; i < Program.alunos.Count(); i++)
            {
                Aluno aluno = Program.alunos[i];

                dgv_ListaAlunos.Rows.Add(new Object[] 
                { 
                    aluno.GetCodigo(),
                    aluno.GetNome(),
                    aluno.GetTurma(),
                    aluno.GetTurno()
                });
            }
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            if (dgv_ListaAlunos.CurrentRow == null)
            {
                MessageBox.Show("Selecione um registro para que seja possivel editar.");
                return;
            }
            int codigo = Convert.ToInt32(dgv_ListaAlunos.Rows[dgv_ListaAlunos.CurrentRow.Index].Cells[0].Value.ToString());
            new CadastroAluno(codigo).ShowDialog();
        }

        private void bnt_Apagar_Click(object sender, EventArgs e)
        {
            if (dgv_ListaAlunos.CurrentRow == null)
            {
                MessageBox.Show("Selecione um registro para que seja possivel apagar.");
                return;
            }
            int codigo = Convert.ToInt32(dgv_ListaAlunos.Rows[dgv_ListaAlunos.CurrentRow.Index].Cells[0].Value.ToString());

            for (int i = 0; i < Program.alunos.Count(); i++)
            {
                Aluno aluno = Program.alunos[i];
                if (aluno.GetCodigo() == codigo)
                {
                    Program.alunos.Remove(aluno);
                    PopularListaAlunos();
                    MessageBox.Show(aluno.GetNome() + "Apagado com sucesso.");
                    return;
                }
            }
        }
    }
}
