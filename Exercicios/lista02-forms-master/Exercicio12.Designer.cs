namespace Lista_de_Estrutura_Condicional___Forms
{
    partial class Exercicio12
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_Resultado = new System.Windows.Forms.Label();
            this.txt_Numero1 = new System.Windows.Forms.TextBox();
            this.txt_Numero2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Número 2";
            // 
            // lb_Resultado
            // 
            this.lb_Resultado.AutoSize = true;
            this.lb_Resultado.Location = new System.Drawing.Point(12, 135);
            this.lb_Resultado.Name = "lb_Resultado";
            this.lb_Resultado.Size = new System.Drawing.Size(0, 13);
            this.lb_Resultado.TabIndex = 2;
            // 
            // txt_Numero1
            // 
            this.txt_Numero1.Location = new System.Drawing.Point(122, 43);
            this.txt_Numero1.Name = "txt_Numero1";
            this.txt_Numero1.Size = new System.Drawing.Size(100, 20);
            this.txt_Numero1.TabIndex = 3;
            // 
            // txt_Numero2
            // 
            this.txt_Numero2.Location = new System.Drawing.Point(122, 66);
            this.txt_Numero2.Name = "txt_Numero2";
            this.txt_Numero2.Size = new System.Drawing.Size(100, 20);
            this.txt_Numero2.TabIndex = 4;
            this.txt_Numero2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Numero2_KeyDown);
            // 
            // Exercicio12
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.txt_Numero2);
            this.Controls.Add(this.txt_Numero1);
            this.Controls.Add(this.lb_Resultado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Exercicio12";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exercicio12";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_Resultado;
        private System.Windows.Forms.TextBox txt_Numero1;
        private System.Windows.Forms.TextBox txt_Numero2;
    }
}