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
    public partial class Exemplo04 : Form
    {
        public Exemplo04()
        {
            InitializeComponent();
        }

        private void rbSim_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSim.Checked)
            {
                rbSim.ForeColor = Color.Green;
                rbNao.ForeColor = Color.Black;
                gb2.Visible = true;
            }
            else
            {
                rbSim.ForeColor = Color.Black;
                rbNao.ForeColor = Color.Red;
                gb2.Visible = false;
            }
        }
    }
}
