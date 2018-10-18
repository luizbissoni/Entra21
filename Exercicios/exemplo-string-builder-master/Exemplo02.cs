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
    public partial class Exemplo02 : Form
    {
        public Exemplo02()
        {
            InitializeComponent();
        }

        private void btn_Processar_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("1\t\t\tQboa\t\t\tR$20,00");
            sb.AppendLine("2\t\t\tAmaciante\t\t\tR$15,69");
            sb.AppendLine("3\t\t\tSopa\t\t\tR$5,60");
            txt_Resultado.Text = sb.ToString();

        }
    }
}
