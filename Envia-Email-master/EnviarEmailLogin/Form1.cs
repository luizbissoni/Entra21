using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Net;
using System.Net.Mail;

namespace EnviarEmailLogin
{
    public partial class Form1 : Form
    {
            GmailEmailService gmail = new GmailEmailService();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Enviar_Click(object sender, EventArgs e)
        {
            EmailMessage msg = new EmailMessage();
            msg.Body = "Infomações sobre a conta cadastrada no sistema escola."+ "<br/><br/>"+ "Usuario:" + txt_Usuario.Text + "<br/><br/>" + "Senha:" + txt_Senha.Text;
            msg.IsHtml = true;
            msg.Subject = "Cadastro Realizado";
            msg.ToEmail = txt_Email.Text;
            gmail.SendEmailMessage(msg);
            MessageBox.Show("E-mail foi enviado com suas informações");
        }
    }
}
