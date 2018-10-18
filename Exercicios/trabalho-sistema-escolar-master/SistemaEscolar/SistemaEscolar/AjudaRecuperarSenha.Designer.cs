namespace SistemaEscolar
{
    partial class AjudaRecuperarSenha
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
            this.btn_EnviarEmail = new System.Windows.Forms.Button();
            this.txt_EmailRecuperarSenha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_EnviarEmail
            // 
            this.btn_EnviarEmail.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_EnviarEmail.Location = new System.Drawing.Point(188, 119);
            this.btn_EnviarEmail.Name = "btn_EnviarEmail";
            this.btn_EnviarEmail.Size = new System.Drawing.Size(75, 29);
            this.btn_EnviarEmail.TabIndex = 0;
            this.btn_EnviarEmail.Text = "Enviar";
            this.btn_EnviarEmail.UseVisualStyleBackColor = true;
            this.btn_EnviarEmail.Click += new System.EventHandler(this.btn_EnviarEmail_Click);
            // 
            // txt_EmailRecuperarSenha
            // 
            this.txt_EmailRecuperarSenha.Location = new System.Drawing.Point(76, 80);
            this.txt_EmailRecuperarSenha.Name = "txt_EmailRecuperarSenha";
            this.txt_EmailRecuperarSenha.Size = new System.Drawing.Size(177, 20);
            this.txt_EmailRecuperarSenha.TabIndex = 1;
            this.txt_EmailRecuperarSenha.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_EmailRecuperarSenha_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "E-Mail";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(259, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Digite seu E-Mail para recuperação da senha";
            // 
            // AjudaRecuperarSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 156);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_EmailRecuperarSenha);
            this.Controls.Add(this.btn_EnviarEmail);
            this.Name = "AjudaRecuperarSenha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AjudaRecuperarSenha";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_EnviarEmail;
        private System.Windows.Forms.TextBox txt_EmailRecuperarSenha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}