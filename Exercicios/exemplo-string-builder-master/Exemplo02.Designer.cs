namespace ExemploStringBuilder
{
    partial class Exemplo02
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
            this.btn_Processar = new System.Windows.Forms.Button();
            this.txt_Resultado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_Processar
            // 
            this.btn_Processar.Location = new System.Drawing.Point(164, 226);
            this.btn_Processar.Name = "btn_Processar";
            this.btn_Processar.Size = new System.Drawing.Size(75, 23);
            this.btn_Processar.TabIndex = 0;
            this.btn_Processar.Text = "Processar";
            this.btn_Processar.UseVisualStyleBackColor = true;
            this.btn_Processar.Click += new System.EventHandler(this.btn_Processar_Click);
            // 
            // txt_Resultado
            // 
            this.txt_Resultado.Location = new System.Drawing.Point(13, 13);
            this.txt_Resultado.Multiline = true;
            this.txt_Resultado.Name = "txt_Resultado";
            this.txt_Resultado.Size = new System.Drawing.Size(648, 198);
            this.txt_Resultado.TabIndex = 1;
            // 
            // Exemplo02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 275);
            this.Controls.Add(this.txt_Resultado);
            this.Controls.Add(this.btn_Processar);
            this.Name = "Exemplo02";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exemplo02";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Processar;
        private System.Windows.Forms.TextBox txt_Resultado;
    }
}