using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExemploWFA
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void btn_Exemplo01_Click(object sender, EventArgs e)
        {
            Exemplo01 form1 = new Exemplo01();
            form1.Show();
        }
        private void btn_Exemplo02_Click(object sender, EventArgs e)
        {
            Exemplo02 form2 = new Exemplo02();
            form2.Show();
        }
        private void btn_Exemplo03_Click(object sender, EventArgs e)
        {
            Exemplo03 form3 = new Exemplo03();
            form3.Show();
        }
        private void btn_Exemplo04_Click(object sender, EventArgs e)
        {
            Exemplo04 form4 = new Exemplo04();
            form4.Show();
        }
        private void btn_Exemplo05_Click(object sender, EventArgs e)
        {
            Exemplo05 form5 = new Exemplo05();
            form5.Show();
        }

    }
}
