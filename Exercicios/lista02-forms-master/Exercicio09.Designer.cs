namespace Lista_de_Estrutura_Condicional___Forms
{
    partial class Exercicio09
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
            this.txt_Numero1 = new System.Windows.Forms.TextBox();
            this.txt_Numero2 = new System.Windows.Forms.TextBox();
            this.txt_Numero3 = new System.Windows.Forms.TextBox();
            this.txt_Numero4 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lb_Resultado = new System.Windows.Forms.Label();
            this.btn_Executar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_Numero1
            // 
            this.txt_Numero1.Location = new System.Drawing.Point(72, 19);
            this.txt_Numero1.Name = "txt_Numero1";
            this.txt_Numero1.Size = new System.Drawing.Size(29, 20);
            this.txt_Numero1.TabIndex = 1;
            // 
            // txt_Numero2
            // 
            this.txt_Numero2.Location = new System.Drawing.Point(72, 41);
            this.txt_Numero2.Name = "txt_Numero2";
            this.txt_Numero2.Size = new System.Drawing.Size(29, 20);
            this.txt_Numero2.TabIndex = 2;
            // 
            // txt_Numero3
            // 
            this.txt_Numero3.Location = new System.Drawing.Point(72, 64);
            this.txt_Numero3.Name = "txt_Numero3";
            this.txt_Numero3.Size = new System.Drawing.Size(29, 20);
            this.txt_Numero3.TabIndex = 3;
            // 
            // txt_Numero4
            // 
            this.txt_Numero4.Location = new System.Drawing.Point(72, 90);
            this.txt_Numero4.Name = "txt_Numero4";
            this.txt_Numero4.Size = new System.Drawing.Size(29, 20);
            this.txt_Numero4.TabIndex = 4;
            this.txt_Numero4.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Numero4_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Número 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Número 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Número 3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Número 4";
            // 
            // lb_Resultado
            // 
            this.lb_Resultado.AutoSize = true;
            this.lb_Resultado.Location = new System.Drawing.Point(30, 174);
            this.lb_Resultado.Name = "lb_Resultado";
            this.lb_Resultado.Size = new System.Drawing.Size(0, 13);
            this.lb_Resultado.TabIndex = 9;
            // 
            // btn_Executar
            // 
            this.btn_Executar.Location = new System.Drawing.Point(104, 210);
            this.btn_Executar.Name = "btn_Executar";
            this.btn_Executar.Size = new System.Drawing.Size(75, 23);
            this.btn_Executar.TabIndex = 10;
            this.btn_Executar.Text = "Executar";
            this.btn_Executar.UseVisualStyleBackColor = true;
            this.btn_Executar.Click += new System.EventHandler(this.btn_Executar_Click);
            // 
            // Exercicio09
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btn_Executar);
            this.Controls.Add(this.lb_Resultado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Numero4);
            this.Controls.Add(this.txt_Numero3);
            this.Controls.Add(this.txt_Numero2);
            this.Controls.Add(this.txt_Numero1);
            this.Name = "Exercicio09";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exercicio09";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Numero1;
        private System.Windows.Forms.TextBox txt_Numero2;
        private System.Windows.Forms.TextBox txt_Numero3;
        private System.Windows.Forms.TextBox txt_Numero4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lb_Resultado;
        private System.Windows.Forms.Button btn_Executar;
    }
}