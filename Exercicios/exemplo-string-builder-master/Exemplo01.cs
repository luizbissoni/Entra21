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
    public partial class Exemplo01 : Form
    {
        public Exemplo01()
        {
            InitializeComponent();
        }

        private void btn_Processar_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < 100000; i++)
            {
                sb.Append(i).Append("/ 2 = ").AppendLine(Convert.ToString(i / 2.0));
                lb_Resultado.Text = sb.ToString();
            }
        }
    }
}
