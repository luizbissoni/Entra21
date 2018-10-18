using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gerenciador_DePoneisOO
{
    public partial class Form1 : Form
    {
        List<Poney> poneys = new List<Poney>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //add as outras exceçoes igual a do metodo LimparCampos(); + try/catch
            if (cb_CorCrista.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione a cor da crista");
                return;
            }



            Poney poney = new Poney();
            poney.Apelido = txt_Apelido.Text;
            poney.CorCrista = cb_CorCrista.SelectedItem.ToString();
            poney.Dancarino = cb_Dancarino.Checked;
            poney.Localidade = cb_Localidade.SelectedItem.ToString();
            poney.Nivelfofura = tb_NivelFofura.Value;
            poney.Descricao = rtb_Descricao.Text;
            poney.VendaVivo = rb_Vivo.Checked;
            poney.Raca = cb_Raca.SelectedItem.ToString();
            poneys.Add(poney);
            dgv_Poneys.Rows.Add(new Object[]{poney.Apelido,poney.Raca}); //add a colunas do dataGrid
            LimparCampos();
        }
        private void LimparCampos()
        {
            txt_Apelido.Text = "";
            rtb_Descricao.Text = "";
            cb_CorCrista.SelectedItem = -1;
            cb_Localidade.SelectedIndex = -1;
            cb_Dancarino.Checked = false;
            rb_Vivo.Checked = false;
            rb_Morto.Checked = false;
            tb_NivelFofura.Value = tb_NivelFofura.Minimum;
        }
    }
}
