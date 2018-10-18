namespace WFA
{
    partial class CadastroAlunoNota
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
            this.txt_Nota = new System.Windows.Forms.TextBox();
            this.btn_Salvar = new System.Windows.Forms.Button();
            this.btn_Calncelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_Nota
            // 
            this.txt_Nota.Location = new System.Drawing.Point(37, 44);
            this.txt_Nota.Name = "txt_Nota";
            this.txt_Nota.Size = new System.Drawing.Size(300, 20);
            this.txt_Nota.TabIndex = 0;
            // 
            // btn_Salvar
            // 
            this.btn_Salvar.Location = new System.Drawing.Point(262, 94);
            this.btn_Salvar.Name = "btn_Salvar";
            this.btn_Salvar.Size = new System.Drawing.Size(75, 23);
            this.btn_Salvar.TabIndex = 1;
            this.btn_Salvar.Text = "Salvar";
            this.btn_Salvar.UseVisualStyleBackColor = true;
            this.btn_Salvar.Click += new System.EventHandler(this.btn_Salvar_Click);
            // 
            // btn_Calncelar
            // 
            this.btn_Calncelar.Location = new System.Drawing.Point(181, 94);
            this.btn_Calncelar.Name = "btn_Calncelar";
            this.btn_Calncelar.Size = new System.Drawing.Size(75, 23);
            this.btn_Calncelar.TabIndex = 2;
            this.btn_Calncelar.Text = "Cancelar";
            this.btn_Calncelar.UseVisualStyleBackColor = true;
            this.btn_Calncelar.Click += new System.EventHandler(this.btn_Calncelar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nota";
            // 
            // CadastroAlunoNota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 133);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Calncelar);
            this.Controls.Add(this.btn_Salvar);
            this.Controls.Add(this.txt_Nota);
            this.Name = "CadastroAlunoNota";
            this.Text = "CadastroAlunoNota";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Nota;
        private System.Windows.Forms.Button btn_Salvar;
        private System.Windows.Forms.Button btn_Calncelar;
        private System.Windows.Forms.Label label1;
    }
}