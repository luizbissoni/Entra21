namespace Lista_de_Estrutura_Condicional___Forms
{
    partial class Exercicio11
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
            this.txt_Nota1 = new System.Windows.Forms.TextBox();
            this.txt_Nota2 = new System.Windows.Forms.TextBox();
            this.txt_Nota3 = new System.Windows.Forms.TextBox();
            this.txt_Nota4 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_Resultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_Nota1
            // 
            this.txt_Nota1.Location = new System.Drawing.Point(150, 42);
            this.txt_Nota1.Name = "txt_Nota1";
            this.txt_Nota1.Size = new System.Drawing.Size(100, 20);
            this.txt_Nota1.TabIndex = 1;
            // 
            // txt_Nota2
            // 
            this.txt_Nota2.Location = new System.Drawing.Point(150, 69);
            this.txt_Nota2.Name = "txt_Nota2";
            this.txt_Nota2.Size = new System.Drawing.Size(100, 20);
            this.txt_Nota2.TabIndex = 2;
            // 
            // txt_Nota3
            // 
            this.txt_Nota3.Location = new System.Drawing.Point(150, 96);
            this.txt_Nota3.Name = "txt_Nota3";
            this.txt_Nota3.Size = new System.Drawing.Size(100, 20);
            this.txt_Nota3.TabIndex = 3;
            // 
            // txt_Nota4
            // 
            this.txt_Nota4.Location = new System.Drawing.Point(150, 123);
            this.txt_Nota4.Name = "txt_Nota4";
            this.txt_Nota4.Size = new System.Drawing.Size(100, 20);
            this.txt_Nota4.TabIndex = 4;
            this.txt_Nota4.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Nota4_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nota 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nota 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nota 3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nota 4";
            // 
            // lbl_Resultado
            // 
            this.lbl_Resultado.AutoSize = true;
            this.lbl_Resultado.Location = new System.Drawing.Point(100, 189);
            this.lbl_Resultado.Name = "lbl_Resultado";
            this.lbl_Resultado.Size = new System.Drawing.Size(0, 13);
            this.lbl_Resultado.TabIndex = 8;
            // 
            // Exercicio11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lbl_Resultado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Nota4);
            this.Controls.Add(this.txt_Nota3);
            this.Controls.Add(this.txt_Nota2);
            this.Controls.Add(this.txt_Nota1);
            this.Name = "Exercicio11";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exercicio11";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Nota1;
        private System.Windows.Forms.TextBox txt_Nota2;
        private System.Windows.Forms.TextBox txt_Nota3;
        private System.Windows.Forms.TextBox txt_Nota4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_Resultado;
    }
}