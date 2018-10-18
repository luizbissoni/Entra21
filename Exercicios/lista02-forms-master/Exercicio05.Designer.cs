namespace Lista_de_Estrutura_Condicional___Forms
{
    partial class Exercicio05
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
            this.btn_Executar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Numero = new System.Windows.Forms.TextBox();
            this.txt_Resultado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_Executar
            // 
            this.btn_Executar.Location = new System.Drawing.Point(89, 180);
            this.btn_Executar.Name = "btn_Executar";
            this.btn_Executar.Size = new System.Drawing.Size(103, 41);
            this.btn_Executar.TabIndex = 0;
            this.btn_Executar.Text = "Executar";
            this.btn_Executar.UseVisualStyleBackColor = true;
            this.btn_Executar.Click += new System.EventHandler(this.btn_Executar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Digite um número";
            // 
            // txt_Numero
            // 
            this.txt_Numero.Location = new System.Drawing.Point(139, 46);
            this.txt_Numero.Name = "txt_Numero";
            this.txt_Numero.Size = new System.Drawing.Size(100, 20);
            this.txt_Numero.TabIndex = 2;
            // 
            // txt_Resultado
            // 
            this.txt_Resultado.Location = new System.Drawing.Point(73, 86);
            this.txt_Resultado.Multiline = true;
            this.txt_Resultado.Name = "txt_Resultado";
            this.txt_Resultado.Size = new System.Drawing.Size(150, 45);
            this.txt_Resultado.TabIndex = 3;
            // 
            // Exercicio05
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.txt_Resultado);
            this.Controls.Add(this.txt_Numero);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Executar);
            this.Name = "Exercicio05";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exercicio05";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Executar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Numero;
        private System.Windows.Forms.TextBox txt_Resultado;
    }
}