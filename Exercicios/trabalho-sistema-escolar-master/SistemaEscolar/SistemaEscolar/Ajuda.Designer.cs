namespace SistemaEscolar
{
    partial class Ajuda
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
            this.btn_SugestaoBug = new System.Windows.Forms.Button();
            this.btn_RecuperarSenha = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_SugestaoBug
            // 
            this.btn_SugestaoBug.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SugestaoBug.Location = new System.Drawing.Point(193, 39);
            this.btn_SugestaoBug.Name = "btn_SugestaoBug";
            this.btn_SugestaoBug.Size = new System.Drawing.Size(146, 45);
            this.btn_SugestaoBug.TabIndex = 0;
            this.btn_SugestaoBug.Text = "Sugestão ou Bug";
            this.btn_SugestaoBug.UseVisualStyleBackColor = true;
            this.btn_SugestaoBug.Click += new System.EventHandler(this.btn_SugestaoBug_Click);
            // 
            // btn_RecuperarSenha
            // 
            this.btn_RecuperarSenha.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RecuperarSenha.Location = new System.Drawing.Point(12, 39);
            this.btn_RecuperarSenha.Name = "btn_RecuperarSenha";
            this.btn_RecuperarSenha.Size = new System.Drawing.Size(128, 45);
            this.btn_RecuperarSenha.TabIndex = 1;
            this.btn_RecuperarSenha.Text = "Recuperar Senha";
            this.btn_RecuperarSenha.UseVisualStyleBackColor = true;
            this.btn_RecuperarSenha.Click += new System.EventHandler(this.btn_RecuperarSenha_Click);
            // 
            // Ajuda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(5F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 108);
            this.Controls.Add(this.btn_RecuperarSenha);
            this.Controls.Add(this.btn_SugestaoBug);
            this.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Ajuda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ajuda";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_SugestaoBug;
        private System.Windows.Forms.Button btn_RecuperarSenha;

    }
}