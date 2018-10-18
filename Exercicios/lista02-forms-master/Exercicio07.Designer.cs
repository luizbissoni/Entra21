namespace Lista_de_Estrutura_Condicional___Forms
{
    partial class Exercicio07
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
            this.txt_Numero = new System.Windows.Forms.TextBox();
            this.btn_Executar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_Total = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_Numero
            // 
            this.txt_Numero.Location = new System.Drawing.Point(121, 24);
            this.txt_Numero.Name = "txt_Numero";
            this.txt_Numero.Size = new System.Drawing.Size(100, 20);
            this.txt_Numero.TabIndex = 1;
            this.txt_Numero.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Numero_KeyDown);
            // 
            // btn_Executar
            // 
            this.btn_Executar.Location = new System.Drawing.Point(78, 214);
            this.btn_Executar.Name = "btn_Executar";
            this.btn_Executar.Size = new System.Drawing.Size(100, 35);
            this.btn_Executar.TabIndex = 2;
            this.btn_Executar.Text = "Executar";
            this.btn_Executar.UseVisualStyleBackColor = true;
            this.btn_Executar.Click += new System.EventHandler(this.btn_Executar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Digite um número";
            // 
            // lb_Total
            // 
            this.lb_Total.AutoSize = true;
            this.lb_Total.Location = new System.Drawing.Point(29, 67);
            this.lb_Total.Name = "lb_Total";
            this.lb_Total.Size = new System.Drawing.Size(0, 13);
            this.lb_Total.TabIndex = 4;
            // 
            // Exercicio07
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 261);
            this.Controls.Add(this.lb_Total);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Executar);
            this.Controls.Add(this.txt_Numero);
            this.Name = "Exercicio07";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exercicio07";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Numero;
        private System.Windows.Forms.Button btn_Executar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_Total;
    }
}