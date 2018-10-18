using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExemploStringBuilder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Exemplo01_Click(object sender, EventArgs e)
        {
            Exemplo01 exemplo01 = new Exemplo01();
            exemplo01.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Exemplo02 exemplo02 = new Exemplo02();
            exemplo02.Show();
        }
    }
}
