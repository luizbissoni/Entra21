namespace Lista_de_Estrutura_Condicional___Forms
{
    partial class Exercicio03
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
            this.rb_Somar = new System.Windows.Forms.RadioButton();
            this.rb_Subtrair = new System.Windows.Forms.RadioButton();
            this.rb_Multiplicar = new System.Windows.Forms.RadioButton();
            this.rb_Dividir = new System.Windows.Forms.RadioButton();
            this.txt_Numero1 = new System.Windows.Forms.TextBox();
            this.txt_Resultado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Executar = new System.Windows.Forms.Button();
            this.txt_Numero2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rb_Somar
            // 
            this.rb_Somar.AutoSize = true;
            this.rb_Somar.Location = new System.Drawing.Point(20, 88);
            this.rb_Somar.Name = "rb_Somar";
            this.rb_Somar.Size = new System.Drawing.Size(55, 17);
            this.rb_Somar.TabIndex = 0;
            this.rb_Somar.TabStop = true;
            this.rb_Somar.Text = "Somar";
            this.rb_Somar.UseVisualStyleBackColor = true;
            // 
            // rb_Subtrair
            // 
            this.rb_Subtrair.AutoSize = true;
            this.rb_Subtrair.Location = new System.Drawing.Point(81, 88);
            this.rb_Subtrair.Name = "rb_Subtrair";
            this.rb_Subtrair.Size = new System.Drawing.Size(61, 17);
            this.rb_Subtrair.TabIndex = 1;
            this.rb_Subtrair.TabStop = true;
            this.rb_Subtrair.Text = "Subtrair";
            this.rb_Subtrair.UseVisualStyleBackColor = true;
            // 
            // rb_Multiplicar
            // 
            this.rb_Multiplicar.AutoSize = true;
            this.rb_Multiplicar.Location = new System.Drawing.Point(148, 88);
            this.rb_Multiplicar.Name = "rb_Multiplicar";
            this.rb_Multiplicar.Size = new System.Drawing.Size(72, 17);
            this.rb_Multiplicar.TabIndex = 2;
            this.rb_Multiplicar.TabStop = true;
            this.rb_Multiplicar.Text = "Multiplicar";
            this.rb_Multiplicar.UseVisualStyleBackColor = true;
            // 
            // rb_Dividir
            // 
            this.rb_Dividir.AutoSize = true;
            this.rb_Dividir.Location = new System.Drawing.Point(226, 88);
            this.rb_Dividir.Name = "rb_Dividir";
            this.rb_Dividir.Size = new System.Drawing.Size(54, 17);
            this.rb_Dividir.TabIndex = 3;
            this.rb_Dividir.TabStop = true;
            this.rb_Dividir.Text = "Dividir";
            this.rb_Dividir.UseVisualStyleBackColor = true;
            // 
            // txt_Numero1
            // 
            this.txt_Numero1.Location = new System.Drawing.Point(108, 23);
            this.txt_Numero1.Name = "txt_Numero1";
            this.txt_Numero1.Size = new System.Drawing.Size(72, 20);
            this.txt_Numero1.TabIndex = 4;
            // 
            // txt_Resultado
            // 
            this.txt_Resultado.Location = new System.Drawing.Point(52, 111);
            this.txt_Resultado.Multiline = true;
            this.txt_Resultado.Name = "txt_Resultado";
            this.txt_Resultado.Size = new System.Drawing.Size(168, 39);
            this.txt_Resultado.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Número 1";
            // 
            // btn_Executar
            // 
            this.btn_Executar.Location = new System.Drawing.Point(68, 193);
            this.btn_Executar.Name = "btn_Executar";
            this.btn_Executar.Size = new System.Drawing.Size(136, 47);
            this.btn_Executar.TabIndex = 7;
            this.btn_Executar.Text = "Executar";
            this.btn_Executar.UseVisualStyleBackColor = true;
            this.btn_Executar.Click += new System.EventHandler(this.btn_Executar_Click);
            // 
            // txt_Numero2
            // 
            this.txt_Numero2.Location = new System.Drawing.Point(108, 49);
            this.txt_Numero2.Name = "txt_Numero2";
            this.txt_Numero2.Size = new System.Drawing.Size(72, 20);
            this.txt_Numero2.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Número 2";
            // 
            // Exercicio03
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Numero2);
            this.Controls.Add(this.btn_Executar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Resultado);
            this.Controls.Add(this.txt_Numero1);
            this.Controls.Add(this.rb_Dividir);
            this.Controls.Add(this.rb_Multiplicar);
            this.Controls.Add(this.rb_Subtrair);
            this.Controls.Add(this.rb_Somar);
            this.Name = "Exercicio03";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exercicio03";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rb_Somar;
        private System.Windows.Forms.RadioButton rb_Subtrair;
        private System.Windows.Forms.RadioButton rb_Multiplicar;
        private System.Windows.Forms.RadioButton rb_Dividir;
        private System.Windows.Forms.TextBox txt_Numero1;
        private System.Windows.Forms.TextBox txt_Resultado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Executar;
        private System.Windows.Forms.TextBox txt_Numero2;
        private System.Windows.Forms.Label label2;
    }
}