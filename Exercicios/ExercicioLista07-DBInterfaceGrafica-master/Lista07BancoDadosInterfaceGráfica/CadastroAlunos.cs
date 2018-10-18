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
    public partial class CadastroAlunos : Form
    {
        private int codigo;

        public CadastroAlunos()
        {
            InitializeComponent();
            
        }

        public CadastroAlunos(int codigo)
        {
            InitializeComponent();
            // TODO: Complete member initialization
            this.codigo = codigo;
            AlunosModel aluno = new AlunosRepository().ObterCodigo(codigo);
            PreencherCampos(aluno);
        }

        private void PreencherCampos(AlunosModel aluno)
        {
            txt_Nome.Text = aluno.Nome;
            txt_CodigoAluno.Text = aluno.Id.ToString();
            txt_MatriculaAluno.Text = aluno.Matricula.ToString();
            txt_Nota_1.Text = aluno.Nota_1.ToString();
            txt_Nota_2.Text = aluno.Nota_2.ToString();
            txt_Nota_3.Text = aluno.Nota_3.ToString();
            txt_Frequencia.Text = aluno.Frequencia.ToString();

            if (aluno.SituacaoAluno.ToLower() == "aprovado")
            {
                lbl_SituacaoAluno.ForeColor = Color.Green;
                lbl_SituacaoAluno.Text = aluno.SituacaoAluno.ToString();
            }
            else if (aluno.SituacaoAluno.ToLower() == "recuperação")
            {
                lbl_SituacaoAluno.ForeColor = Color.DarkKhaki;
                lbl_SituacaoAluno.Text = aluno.SituacaoAluno.ToString();
            }
            else
            {
                lbl_SituacaoAluno.ForeColor = Color.Red;
                lbl_SituacaoAluno.Text = aluno.SituacaoAluno.ToString();
            }

        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            AlunosModel aluno = new AlunosModel();
            try
            {

                if (Utils.Exeption(Utils.ValidarMatricula(Convert.ToInt16(txt_MatriculaAluno.Text))))
                {
                    MessageBox.Show(Utils.ValidarMatricula(Convert.ToInt16(txt_MatriculaAluno.Text)));
                    txt_MatriculaAluno.Focus();
                    txt_MatriculaAluno.SelectionStart = 0;
                    txt_MatriculaAluno.SelectionLength = txt_MatriculaAluno.Text.Length;
                    return;
                }

                else if (Utils.Exeption(Utils.ValidarNome(txt_Nome.Text)))
                {
                    MessageBox.Show(Utils.ValidarNome(txt_Nome.Text));
                    txt_Nome.Focus();
                    return;
                }
                else if (Utils.Exeption(Utils.ValidarNota(Convert.ToDouble(txt_Nota_1.Text))))
                {
                    MessageBox.Show(Utils.ValidarNota(Convert.ToDouble(txt_Nota_1.Text)));
                    txt_Nota_1.Focus();
                    txt_Nota_1.SelectionStart = 0;
                    txt_Nota_1.SelectionLength = txt_Nota_1.Text.Length;
                    return;
                }
                else if (Utils.Exeption(Utils.ValidarNota(Convert.ToDouble(txt_Nota_2.Text))))
                {
                    MessageBox.Show(Utils.ValidarNota(Convert.ToDouble(txt_Nota_2.Text)));
                    txt_Nota_2.Focus();
                    txt_Nota_2.SelectionStart = 0;
                    txt_Nota_2.SelectionLength = txt_Nota_2.Text.Length;

                    return;
                }
                else if (Utils.Exeption(Utils.ValidarNota(Convert.ToDouble(txt_Nota_3.Text))))
                {
                    MessageBox.Show(Utils.ValidarNota(Convert.ToDouble(txt_Nota_3.Text)));
                    txt_Nota_3.Focus();
                    txt_Nota_3.SelectionStart = 0;
                    txt_Nota_3.SelectionLength = txt_Nota_3.Text.Length;
                    return;
                }
                else if (Utils.Exeption(Utils.ValidarFrequencia(Convert.ToInt16(txt_Frequencia.Text))))
                {
                    MessageBox.Show(Utils.ValidarFrequencia(Convert.ToInt16(txt_Frequencia.Text)));
                    txt_Frequencia.Focus();
                    txt_Frequencia.SelectionStart = 0;
                    txt_Frequencia.SelectionLength = txt_Frequencia.Text.Length;
                    return;
                }
                else if (Utils.Exeption(Utils.ValidarMatricula(Convert.ToInt16(txt_MatriculaAluno.Text))))
                {
                    MessageBox.Show(Utils.ValidarMatricula(Convert.ToInt16(txt_MatriculaAluno.Text)));
                    txt_MatriculaAluno.Focus();
                    txt_MatriculaAluno.SelectionStart = 0;
                    txt_MatriculaAluno.SelectionLength = txt_MatriculaAluno.Text.Length;
                    return;
                }


                aluno.Matricula = Convert.ToInt16(txt_MatriculaAluno.Text);
                aluno.Nome = txt_Nome.Text;
                aluno.Nota_1 = Convert.ToDouble(txt_Nota_1.Text);
                aluno.Nota_2 = Convert.ToDouble(txt_Nota_2.Text);
                aluno.Nota_3 = Convert.ToDouble(txt_Nota_3.Text);
                aluno.Frequencia = Convert.ToInt16(txt_Frequencia.Text);
                aluno.MediaNotas = Utils.MediaNotas(Convert.ToDouble(txt_Nota_1.Text), Convert.ToDouble(txt_Nota_2.Text), Convert.ToDouble(txt_Nota_3.Text));
                aluno.SituacaoAluno = Utils.SituacaoMedia(Utils.MediaNotas(Convert.ToDouble(txt_Nota_1.Text), Convert.ToDouble(txt_Nota_2.Text), Convert.ToDouble(txt_Nota_3.Text)));

            }
            catch (Exception)
            {
                MessageBox.Show("ERRO ao Salvar.");
                return;
            }


            if (string.IsNullOrEmpty(txt_CodigoAluno.Text))
            {
                int id = new AlunosRepository().Inserir(aluno);
                txt_CodigoAluno.Text = id.ToString();
                MessageBox.Show("Cadastrado com sucesso!");
            }
            else
            {
                int id = Convert.ToInt32(txt_CodigoAluno.Text);
                aluno.Id = id;
                bool alterou = new AlunosRepository().Alterar(aluno);
                if (alterou)
                {
                    MessageBox.Show("Alterado com sucesso!");
                }
                else
                {
                    MessageBox.Show("Não foi possível Alterar");
                }

            }
        }

        private void txt_CodigoAluno_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_CodigoAluno.Text))
            {
                try
                {
                    int id = Convert.ToInt32(txt_CodigoAluno.Text);
                    AlunosModel aluno = new AlunosRepository().ObterCodigo(id);
                    if (aluno != null)
                    {
                        PreencherCampos(aluno);
                    }
                    else
                    {
                        MessageBox.Show("Registro não existente");
                        txt_CodigoAluno.Focus();
                        txt_CodigoAluno.SelectionStart = 0;
                        txt_CodigoAluno.SelectionLength = txt_CodigoAluno.Text.Length;
                    }
                }
                catch (NotFiniteNumberException ex)
                {
                    MessageBox.Show("Digite um codigo valido" + ex.Message);
                }

            }
        }

        private void txt_MatriculaAluno_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_MatriculaAluno.Text))
            {
                MessageBox.Show("Preencha a matricula.");
                txt_MatriculaAluno.Focus();
                return;
                
            }
        }

       



    }
}
