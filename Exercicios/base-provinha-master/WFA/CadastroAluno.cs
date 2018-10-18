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
    public partial class CadastroAluno : Form
    {
        private Aluno aluno;
        private int codigo;

        public CadastroAluno()
        {
            InitializeComponent();
        }

        public CadastroAluno(int codigo)
        {
            InitializeComponent();

            this.codigo = codigo;
            for (int i = 0; i < Program.alunos.Count(); i++)
            {
                Aluno aluno = Program.alunos[i];
                if (aluno.GetCodigo() == codigo)
                {
                    txt_Nome.Text = aluno.GetNome();
                    txt_Matricula.Text =  Convert.ToString(aluno.GetMatricula());
                    txt_Turma.Text = aluno.GetTurma();
                    txt_Turno.Text = aluno.GetTurno();
                    txt_Idade.Text = Convert.ToString(aluno.GetIdade());
                    this.aluno = aluno;
                    btn_AdicionarNota.Enabled = true;
                    btn_ApagarAluno.Enabled = true;
                    btn_EditarAluno.Enabled = true;
                    AtualizaDataGridViewDasNotas();
                    return;
                }
            }
        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            try
            {
                bool novo = aluno == null;
                if (aluno == null)
                {
                    aluno = new Aluno();
                }

                aluno.SetNome(txt_Nome.Text);
                aluno.SetTurma(txt_Turma.Text);
                aluno.SetIdade(Convert.ToInt32(txt_Idade.Text));
                aluno.SetMatricula(Convert.ToInt32(txt_Turma.Text));
                aluno.SetTurno(txt_Turno.Text);
                if (novo)
                {
                    Program.alunos.Add(aluno);
                    MessageBox.Show("Cadastro ralizado com sucesso");
                }
                else
                {
                    for (int i = 0; i < Program.alunos.Count(); i++)
                    {
                        Aluno alunoAux = Program.alunos[i];
                        if (aluno.GetCodigo() == alunoAux.GetCodigo())
                        {
                            Program.alunos[i] = aluno;
                            MessageBox.Show("Alterado com sucesso");
                            return;
                        }
                    }
                }
                btn_AdicionarNota.Enabled = true;
                btn_ApagarAluno.Enabled = true;
                btn_EditarAluno.Enabled = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }

        private void btn_Adicionar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = new CadastroAlunoNota(aluno).ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                AtualizaDataGridViewDasNotas();
            }

        }

        private void AtualizaDataGridViewDasNotas()
        {
            dgv_CadastroAlunosNotas.Rows.Clear();
            for (int i = 0; i < aluno.GetNotas().Count(); i++)
            {
                double nota = aluno.GetNotas()[i];
                dgv_CadastroAlunosNotas.Rows.Add(new Object[] { nota });
            }
        }

        
    }
}
