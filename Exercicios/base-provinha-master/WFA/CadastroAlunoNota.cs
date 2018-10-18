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
    public partial class CadastroAlunoNota : Form
    {
        public Aluno aluno;

        public CadastroAlunoNota(Aluno aluno)
        {
            InitializeComponent();
            this.aluno = aluno;
        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            try
            {
                double nota = Convert.ToDouble(txt_Nota.Text);
                aluno.AdicionarNota(nota);
                this.DialogResult = DialogResult.OK;
                Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }
            

        }

        private void btn_Calncelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Dispose();
        }
          

    }
}
