using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaEscolar
{
    public partial class SugestaoBug : Form
    {
        public SugestaoBug()
        {
            InitializeComponent();
        }

        private void txt_Enviar_Click(object sender, EventArgs e)
        {
            GmailEmailService gmail = new GmailEmailService();

            if (ValidarEmailUsuario.validarEmailUsuarios(txt_Email.Text))
            {
                EmailMessage msg = new EmailMessage();
                msg.Body = txt_Menssagem.Text;
                msg.IsHtml = true;
                msg.Subject = txt_Assunto.Text;
                msg.ToEmail = txt_Email.Text;
                gmail.SendEmailMessage(msg);
                MessageBox.Show("E-mail foi enviado");
            }

            else
            {
                MessageBox.Show("E-Mail inválido");
                txt_Email.Focus();
                return;
            }
        }
    }
}
