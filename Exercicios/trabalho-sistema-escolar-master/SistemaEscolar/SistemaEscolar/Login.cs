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
    public partial class Login : Form
    {
        UsuarioSistema loginUsuario = new UsuarioSistema();
        
        bool validarErro = true;

        public Login()
        {
            InitializeComponent();
            txt_Senha.MaxLength = 12; 
            txt_Senha.UseSystemPasswordChar = true;  //deixa os caracteres digitados em *  
        }

        private void btn_Entrar_Click(object sender, EventArgs e)
        {
            if (txt_Usuario.Text == "admin" && txt_Senha.Text == "123")  // evento para fechar o foms de login 
            {
                this.Hide();
                var form2 = new TelaPrincipal();
                form2.Closed += (s, args) => this.Close();
                form2.Show();
                validarErro = false;
            }

            for (int i = 0; i < CadastroUsuarioSistema.usuarioPre.Count(); i++)
            {
                UsuarioSistema usuarioSistema = CadastroUsuarioSistema.usuarioPre[i];
                if (txt_Usuario.Text == usuarioSistema.Login && txt_Senha.Text == usuarioSistema.Senha)
                {
                    this.Hide();
                    var form2 = new TelaPrincipal();
                    form2.Closed += (s, args) => this.Close();
                    form2.Show();
                }    
            }
            
            if (validarErro == true || Tools.IsPasswordStrong(txt_Senha.Text)) 
            {
                lb_AvisoSenhaLogin.Visible = true;
            }
            else
            {
                lb_AvisoSenhaLogin.Visible = false;
            }
            
        }

        private void cb_MostrarSenhaLogin_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_MostrarSenhaLogin.Checked)
            {
                txt_Senha.UseSystemPasswordChar = false;
            }
            else
            {
                txt_Senha.UseSystemPasswordChar = true;  //deixa os caracteres digitados em *
            }
        }

        private void txt_Senha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Entrar.PerformClick();
            }
        }

        private void btn_Ajuda_Click(object sender, EventArgs e)
        {
            Ajuda telaAjuda = new Ajuda();
            telaAjuda.ShowDialog();
        }

    }
}
