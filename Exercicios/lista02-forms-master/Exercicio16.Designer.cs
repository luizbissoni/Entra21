namespace Lista_de_Estrutura_Condicional___Forms
{
    partial class Exercicio16
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
            this.rb_Celsius = new System.Windows.Forms.RadioButton();
            this.rb_Fahrenheit = new System.Windows.Forms.RadioButton();
            this.rb_Kelvin = new System.Windows.Forms.RadioButton();
            this.rb_Celsius2 = new System.Windows.Forms.RadioButton();
            this.rb_Fahrenheit2 = new System.Windows.Forms.RadioButton();
            this.rb_Kelvin2 = new System.Windows.Forms.RadioButton();
            this.txt_Numero = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_Resultado = new System.Windows.Forms.Label();
            this.btn_Converter = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.gb_Group1 = new System.Windows.Forms.GroupBox();
            this.gb_Group2 = new System.Windows.Forms.GroupBox();
            this.gb_Group1.SuspendLayout();
            this.gb_Group2.SuspendLayout();
            this.SuspendLayout();
            // 
            // rb_Celsius
            // 
            this.rb_Celsius.AutoSize = true;
            this.rb_Celsius.Location = new System.Drawing.Point(6, 21);
            this.rb_Celsius.Name = "rb_Celsius";
            this.rb_Celsius.Size = new System.Drawing.Size(58, 17);
            this.rb_Celsius.TabIndex = 0;
            this.rb_Celsius.TabStop = true;
            this.rb_Celsius.Text = "Celsius";
            this.rb_Celsius.UseVisualStyleBackColor = true;
            this.rb_Celsius.CheckedChanged += new System.EventHandler(this.rb_Celsius_CheckedChanged);
            // 
            // rb_Fahrenheit
            // 
            this.rb_Fahrenheit.AutoSize = true;
            this.rb_Fahrenheit.Location = new System.Drawing.Point(6, 44);
            this.rb_Fahrenheit.Name = "rb_Fahrenheit";
            this.rb_Fahrenheit.Size = new System.Drawing.Size(75, 17);
            this.rb_Fahrenheit.TabIndex = 1;
            this.rb_Fahrenheit.TabStop = true;
            this.rb_Fahrenheit.Text = "Fahrenheit";
            this.rb_Fahrenheit.UseVisualStyleBackColor = true;
            this.rb_Fahrenheit.CheckedChanged += new System.EventHandler(this.rb_Fahrenheit_CheckedChanged);
            // 
            // rb_Kelvin
            // 
            this.rb_Kelvin.AutoSize = true;
            this.rb_Kelvin.Location = new System.Drawing.Point(6, 67);
            this.rb_Kelvin.Name = "rb_Kelvin";
            this.rb_Kelvin.Size = new System.Drawing.Size(54, 17);
            this.rb_Kelvin.TabIndex = 2;
            this.rb_Kelvin.TabStop = true;
            this.rb_Kelvin.Text = "Kelvin";
            this.rb_Kelvin.UseVisualStyleBackColor = true;
            this.rb_Kelvin.CheckedChanged += new System.EventHandler(this.rb_Kelvin_CheckedChanged);
            // 
            // rb_Celsius2
            // 
            this.rb_Celsius2.AutoSize = true;
            this.rb_Celsius2.Location = new System.Drawing.Point(6, 21);
            this.rb_Celsius2.Name = "rb_Celsius2";
            this.rb_Celsius2.Size = new System.Drawing.Size(58, 17);
            this.rb_Celsius2.TabIndex = 3;
            this.rb_Celsius2.TabStop = true;
            this.rb_Celsius2.Text = "Celsius";
            this.rb_Celsius2.UseVisualStyleBackColor = true;
            // 
            // rb_Fahrenheit2
            // 
            this.rb_Fahrenheit2.AutoSize = true;
            this.rb_Fahrenheit2.Location = new System.Drawing.Point(6, 44);
            this.rb_Fahrenheit2.Name = "rb_Fahrenheit2";
            this.rb_Fahrenheit2.Size = new System.Drawing.Size(75, 17);
            this.rb_Fahrenheit2.TabIndex = 4;
            this.rb_Fahrenheit2.TabStop = true;
            this.rb_Fahrenheit2.Text = "Fahrenheit";
            this.rb_Fahrenheit2.UseVisualStyleBackColor = true;
            // 
            // rb_Kelvin2
            // 
            this.rb_Kelvin2.AutoSize = true;
            this.rb_Kelvin2.Location = new System.Drawing.Point(6, 67);
            this.rb_Kelvin2.Name = "rb_Kelvin2";
            this.rb_Kelvin2.Size = new System.Drawing.Size(54, 17);
            this.rb_Kelvin2.TabIndex = 5;
            this.rb_Kelvin2.TabStop = true;
            this.rb_Kelvin2.Text = "Kelvin";
            this.rb_Kelvin2.UseVisualStyleBackColor = true;
            // 
            // txt_Numero
            // 
            this.txt_Numero.Location = new System.Drawing.Point(196, 30);
            this.txt_Numero.Name = "txt_Numero";
            this.txt_Numero.Size = new System.Drawing.Size(42, 20);
            this.txt_Numero.TabIndex = 8;
            this.txt_Numero.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Numero_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Temperatura:";
            // 
            // lb_Resultado
            // 
            this.lb_Resultado.AutoSize = true;
            this.lb_Resultado.Location = new System.Drawing.Point(113, 176);
            this.lb_Resultado.Name = "lb_Resultado";
            this.lb_Resultado.Size = new System.Drawing.Size(0, 13);
            this.lb_Resultado.TabIndex = 10;
            // 
            // btn_Converter
            // 
            this.btn_Converter.Location = new System.Drawing.Point(116, 227);
            this.btn_Converter.Name = "btn_Converter";
            this.btn_Converter.Size = new System.Drawing.Size(124, 46);
            this.btn_Converter.TabIndex = 11;
            this.btn_Converter.Text = "Converter";
            this.btn_Converter.UseVisualStyleBackColor = true;
            this.btn_Converter.Click += new System.EventHandler(this.btn_Converter_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(106, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Conversão da temperatura";
            // 
            // gb_Group1
            // 
            this.gb_Group1.Controls.Add(this.rb_Kelvin);
            this.gb_Group1.Controls.Add(this.rb_Fahrenheit);
            this.gb_Group1.Controls.Add(this.rb_Celsius);
            this.gb_Group1.Location = new System.Drawing.Point(26, 60);
            this.gb_Group1.Name = "gb_Group1";
            this.gb_Group1.Size = new System.Drawing.Size(128, 100);
            this.gb_Group1.TabIndex = 13;
            this.gb_Group1.TabStop = false;
            this.gb_Group1.Text = "Sua Temperatura";
            // 
            // gb_Group2
            // 
            this.gb_Group2.Controls.Add(this.rb_Kelvin2);
            this.gb_Group2.Controls.Add(this.rb_Fahrenheit2);
            this.gb_Group2.Controls.Add(this.rb_Celsius2);
            this.gb_Group2.Location = new System.Drawing.Point(182, 60);
            this.gb_Group2.Name = "gb_Group2";
            this.gb_Group2.Size = new System.Drawing.Size(114, 100);
            this.gb_Group2.TabIndex = 14;
            this.gb_Group2.TabStop = false;
            this.gb_Group2.Text = "Converter para ";
            // 
            // Exercicio16
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 285);
            this.Controls.Add(this.gb_Group2);
            this.Controls.Add(this.gb_Group1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Converter);
            this.Controls.Add(this.lb_Resultado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Numero);
            this.Name = "Exercicio16";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exercicio16";
            this.gb_Group1.ResumeLayout(false);
            this.gb_Group1.PerformLayout();
            this.gb_Group2.ResumeLayout(false);
            this.gb_Group2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rb_Celsius;
        private System.Windows.Forms.RadioButton rb_Fahrenheit;
        private System.Windows.Forms.RadioButton rb_Kelvin;
        private System.Windows.Forms.RadioButton rb_Celsius2;
        private System.Windows.Forms.RadioButton rb_Fahrenheit2;
        private System.Windows.Forms.RadioButton rb_Kelvin2;
        private System.Windows.Forms.TextBox txt_Numero;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_Resultado;
        private System.Windows.Forms.Button btn_Converter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gb_Group1;
        private System.Windows.Forms.GroupBox gb_Group2;
    }
}