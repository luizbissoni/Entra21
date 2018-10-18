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
    public partial class AjudaRecuperarSenha : Form
    {
        GmailEmailService gmail = new GmailEmailService();
        public AjudaRecuperarSenha()
        {
            InitializeComponent();
        }

        private void btn_EnviarEmail_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < CadastroUsuarioSistema.usuarioPre.Count(); i++)
            {
                UsuarioSistema usuarioSistema = CadastroUsuarioSistema.usuarioPre[i];
                try
                {
                    if (txt_EmailRecuperarSenha.Text == usuarioSistema.Email)
                    {
                        EmailMessage msg = new EmailMessage();
                        msg.Body = "Suas informações conforme solicitado <br/><br/>" + "Nome:" + usuarioSistema.Nome + "<br/>" + "Login:" + usuarioSistema.Login + "<br/>" + "Senha:" + usuarioSistema.Senha;
                        msg.IsHtml = true;
                        msg.Subject = "Recuperação de senha";
                        msg.ToEmail = txt_EmailRecuperarSenha.Text;
                        gmail.SendEmailMessage(msg);
                        MessageBox.Show("E-mail foi enviado com suas informações");
                    }
                    else
                    {
                        MessageBox.Show("E-Mail não cadastrado no sistema");
                        txt_EmailRecuperarSenha.Focus();
                        return;
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Preencha corretamente!");
                    return;
                   
                }
               
            }
        }

        private void txt_EmailRecuperarSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_EnviarEmail.PerformClick();
            }
        } 
    }
}
