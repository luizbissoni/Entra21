using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketDesktop
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btn_AdicionarCadastro_Click(object sender, EventArgs e)
        {
            dgv_CadastroFeira.Rows.Add(txtb_Produto.Text, txtb_Quantidade.Text,txtb_valorUnitario.Text);
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (dgv_CadastroFeira.CanSelect)
            {
                dgv_CadastroFeira.Rows.Remove(dgv_CadastroFeira.CurrentRow);
            }
  
            //if (dgv_CadastroFeira.Rows.Count > 0)
            //{
            //    dgv_CadastroFeira.Rows.Remove(dgv_CadastroFeira.CurrentRow);
            //}
           
        }

        private void dgv_CadastroProdutos_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            //Add um Id autoincremento no grid view
            this.dgv_CadastroFeira.Rows[e.RowIndex].Cells["ID"].Value = (e.RowIndex + 1).ToString();
        }

        

        

        
    }
}
