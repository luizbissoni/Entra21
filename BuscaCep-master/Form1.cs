using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PesquisaPorCep
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_PesquisaCep_Click(object sender, EventArgs e)
        {
            CEP cep = new CEP(txt_CepDigitado.Text);
           

            dgv_Resultado.Rows.Add(new object[] { cep.localidade, cep.bairro, cep.complemento,cep.logradouro,cep.uf });

            txt_Bairro.Text = cep.bairro;


        }

      
    }
}
