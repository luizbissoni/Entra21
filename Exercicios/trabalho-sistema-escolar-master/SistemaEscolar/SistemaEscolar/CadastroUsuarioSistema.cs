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
    public partial class CadastroUsuarioSistema : Form
    {

        UsuarioSistema usuarioSistemaCadastro = new UsuarioSistema();
        public static List<UsuarioSistema> usuarioPre = new List<UsuarioSistema>();
        public static List<Aluno> alunospre = new List<Aluno>();
        GmailEmailService gmail = new GmailEmailService();

        public CadastroUsuarioSistema()
        {
            InitializeComponent();
            txt_SenhaUsuario.UseSystemPasswordChar = true;
            txt_ConfirmarSenhaUsuario.UseSystemPasswordChar = true;

        }
        //checkbox para mostrar/ocultar senha
        private void cb_MostrarSenhaCadastroLogin_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_MostrarSenhaCadastroLogin.Checked)
            {
                txt_SenhaUsuario.UseSystemPasswordChar = false;
                txt_ConfirmarSenhaUsuario.UseSystemPasswordChar = false;
            }
            else
            {
                txt_SenhaUsuario.UseSystemPasswordChar = true;
                txt_ConfirmarSenhaUsuario.UseSystemPasswordChar = true;
            }
        }

        private void btn_ConfirmarLoginUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidarEmailUsuario.validarEmailUsuarios(txt_EmailUsuario.Text))
                {
                    usuarioSistemaCadastro.Email = txt_EmailUsuario.Text;
                    EmailMessage msg = new EmailMessage();
                    msg.Body = "Infomações sobre a conta cadastrada no sistema escola." + "<br/><br/>" + "Usuario:" + txt_LoginUsuario.Text + "<br/><br/>" + "Senha:" + txt_SenhaUsuario.Text;
                    msg.IsHtml = true;
                    msg.Subject = "Cadastro Realizado";
                    msg.ToEmail = txt_EmailUsuario.Text;
                    gmail.SendEmailMessage(msg);
                    MessageBox.Show("E-mail foi enviado com suas informações");
                }
               
                else
                {
                    MessageBox.Show("E-Mail inválido!");
                    txt_EmailUsuario.Focus();
                    return;
                }

                if (Tools.IsPasswordStrong(txt_SenhaUsuario.Text))
                {
                    usuarioSistemaCadastro.Senha = txt_SenhaUsuario.Text;
                }
                else
                {
                    MessageBox.Show("Senha inválida!");
                    txt_SenhaUsuario.Focus();
                    return;
                }

                if (txt_SenhaUsuario.Text == txt_ConfirmarSenhaUsuario.Text)
                {
                    usuarioSistemaCadastro.Senha = txt_SenhaUsuario.Text;
                }
                else
                {
                    MessageBox.Show("Senha de confirmação é diferente");
                    txt_ConfirmarSenhaUsuario.Focus();
                    return;
                }
                if (!Tools.IsPasswordStrong(txt_SenhaUsuario.Text))
                {
                    lb_ExemploSenha.Visible = true;
                }
                


                Program.cadastroUsuarioSistemaLogin.Add(usuarioSistemaCadastro);
            }
            catch (Exception)
            {

                MessageBox.Show("Preencha corretamente!");
                return;
            }

        }

        private void btn_CriarUsuario_Click(object sender, EventArgs e)
        {
            if (cb_NomeUsuario.SelectedIndex < 0)
            {
                MessageBox.Show("Selecione um usuário");
                cb_NomeUsuario.DroppedDown = true;
                return;
            }
            if (cb_PrivilegioUsuario.SelectedIndex < 0)
            {
                MessageBox.Show("Selecione um privilegio para o usuário");
                cb_PrivilegioUsuario.DroppedDown = true;
                return;
            }
            if (dt_DataCadastroUsuario.Value.Date == DateTime.Now.Date)
            {
                MessageBox.Show("Data de cadastro tem que ser data atual");
                return;
            }




        }
        static CadastroUsuarioSistema()
        {
            UsuarioSistema usuarioPreCadastro = new UsuarioSistema();

            usuarioPreCadastro.Nome = "Carlos José Silvasaurro";
            usuarioPreCadastro.Privilegio = "Professor";
            usuarioPreCadastro.Login = "carlos";
            usuarioPreCadastro.Senha = "0405";
            usuarioPreCadastro.Email = "labissoni@gmail.com";
            usuarioPre.Add(usuarioPreCadastro);
        }

        

    }
}
