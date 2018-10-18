namespace SistemaEscolar
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Entrar = new System.Windows.Forms.Button();
            this.btn_Ajuda = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Usuario = new System.Windows.Forms.TextBox();
            this.txt_Senha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_MostrarSenhaLogin = new System.Windows.Forms.CheckBox();
            this.lb_AvisoSenhaLogin = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // btn_Entrar
            // 
            this.btn_Entrar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Entrar.Location = new System.Drawing.Point(208, 181);
            this.btn_Entrar.Name = "btn_Entrar";
            this.btn_Entrar.Size = new System.Drawing.Size(75, 35);
            this.btn_Entrar.TabIndex = 3;
            this.btn_Entrar.Text = "Entrar";
            this.btn_Entrar.UseVisualStyleBackColor = true;
            this.btn_Entrar.Click += new System.EventHandler(this.btn_Entrar_Click);
            // 
            // btn_Ajuda
            // 
            this.btn_Ajuda.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Ajuda.Location = new System.Drawing.Point(65, 181);
            this.btn_Ajuda.Name = "btn_Ajuda";
            this.btn_Ajuda.Size = new System.Drawing.Size(75, 35);
            this.btn_Ajuda.TabIndex = 5;
            this.btn_Ajuda.TabStop = false;
            this.btn_Ajuda.Text = "Ajuda";
            this.btn_Ajuda.UseVisualStyleBackColor = true;
            this.btn_Ajuda.Click += new System.EventHandler(this.btn_Ajuda_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(330, 41);
            this.label1.TabIndex = 2;
            this.label1.Text = "Área de Login";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_Usuario
            // 
            this.txt_Usuario.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Usuario.Location = new System.Drawing.Point(92, 71);
            this.txt_Usuario.Name = "txt_Usuario";
            this.txt_Usuario.Size = new System.Drawing.Size(165, 26);
            this.txt_Usuario.TabIndex = 1;
            // 
            // txt_Senha
            // 
            this.txt_Senha.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Senha.Location = new System.Drawing.Point(92, 121);
            this.txt_Senha.Name = "txt_Senha";
            this.txt_Senha.Size = new System.Drawing.Size(165, 26);
            this.txt_Senha.TabIndex = 2;
            this.txt_Senha.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Senha_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(80, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Usuário";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(80, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Senha";
            // 
            // cb_MostrarSenhaLogin
            // 
            this.cb_MostrarSenhaLogin.AutoSize = true;
            this.cb_MostrarSenhaLogin.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_MostrarSenhaLogin.Location = new System.Drawing.Point(83, 153);
            this.cb_MostrarSenhaLogin.Name = "cb_MostrarSenhaLogin";
            this.cb_MostrarSenhaLogin.Size = new System.Drawing.Size(129, 22);
            this.cb_MostrarSenhaLogin.TabIndex = 4;
            this.cb_MostrarSenhaLogin.TabStop = false;
            this.cb_MostrarSenhaLogin.Text = "Mostrar Senha";
            this.cb_MostrarSenhaLogin.UseVisualStyleBackColor = true;
            this.cb_MostrarSenhaLogin.CheckedChanged += new System.EventHandler(this.cb_MostrarSenhaLogin_CheckedChanged);
            // 
            // lb_AvisoSenhaLogin
            // 
            this.lb_AvisoSenhaLogin.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_AvisoSenhaLogin.ForeColor = System.Drawing.Color.Red;
            this.lb_AvisoSenhaLogin.Location = new System.Drawing.Point(12, 235);
            this.lb_AvisoSenhaLogin.Name = "lb_AvisoSenhaLogin";
            this.lb_AvisoSenhaLogin.Size = new System.Drawing.Size(330, 18);
            this.lb_AvisoSenhaLogin.TabIndex = 9;
            this.lb_AvisoSenhaLogin.Text = "Usuário e/ou Senha incorretos!";
            this.lb_AvisoSenhaLogin.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lb_AvisoSenhaLogin.Visible = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 262);
            this.Controls.Add(this.btn_Entrar);
            this.Controls.Add(this.lb_AvisoSenhaLogin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_MostrarSenhaLogin);
            this.Controls.Add(this.txt_Senha);
            this.Controls.Add(this.btn_Ajuda);
            this.Controls.Add(this.txt_Usuario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Entrar;
        private System.Windows.Forms.Button btn_Ajuda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Usuario;
        private System.Windows.Forms.TextBox txt_Senha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cb_MostrarSenhaLogin;
        private System.Windows.Forms.Label lb_AvisoSenhaLogin;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

