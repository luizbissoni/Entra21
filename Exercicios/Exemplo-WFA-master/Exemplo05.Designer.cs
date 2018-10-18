namespace ExemploWFA
{
    partial class Exemplo05
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
            this.cb_Leu = new System.Windows.Forms.CheckBox();
            this.cb_Comprou = new System.Windows.Forms.CheckBox();
            this.btn_Salvar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cb_Leu
            // 
            this.cb_Leu.AutoSize = true;
            this.cb_Leu.Location = new System.Drawing.Point(12, 36);
            this.cb_Leu.Name = "cb_Leu";
            this.cb_Leu.Size = new System.Drawing.Size(141, 17);
            this.cb_Leu.TabIndex = 0;
            this.cb_Leu.Text = "Confirmar que leu tudo ?";
            this.cb_Leu.UseVisualStyleBackColor = true;
            // 
            // cb_Comprou
            // 
            this.cb_Comprou.AutoSize = true;
            this.cb_Comprou.Location = new System.Drawing.Point(12, 60);
            this.cb_Comprou.Name = "cb_Comprou";
            this.cb_Comprou.Size = new System.Drawing.Size(143, 17);
            this.cb_Comprou.TabIndex = 1;
            this.cb_Comprou.Text = "Você comprou o WinRar";
            this.cb_Comprou.UseVisualStyleBackColor = true;
            // 
            // btn_Salvar
            // 
            this.btn_Salvar.Location = new System.Drawing.Point(46, 113);
            this.btn_Salvar.Name = "btn_Salvar";
            this.btn_Salvar.Size = new System.Drawing.Size(75, 23);
            this.btn_Salvar.TabIndex = 2;
            this.btn_Salvar.Text = "Salvar";
            this.btn_Salvar.UseVisualStyleBackColor = true;
            this.btn_Salvar.Click += new System.EventHandler(this.btn_Salvar_Click);
            // 
            // Exemplo05
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(177, 154);
            this.Controls.Add(this.btn_Salvar);
            this.Controls.Add(this.cb_Comprou);
            this.Controls.Add(this.cb_Leu);
            this.Name = "Exemplo05";
            this.Text = "Exemplo05";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cb_Leu;
        private System.Windows.Forms.CheckBox cb_Comprou;
        private System.Windows.Forms.Button btn_Salvar;
    }
}