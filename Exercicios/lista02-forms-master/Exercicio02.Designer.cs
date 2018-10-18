namespace Lista_de_Estrutura_Condicional___Forms
{
    partial class Exercicio02
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
            this.txt_Resultado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Executar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_Numero
            // 
            this.txt_Numero.Location = new System.Drawing.Point(117, 25);
            this.txt_Numero.Name = "txt_Numero";
            this.txt_Numero.Size = new System.Drawing.Size(54, 20);
            this.txt_Numero.TabIndex = 0;
            // 
            // txt_Resultado
            // 
            this.txt_Resultado.Location = new System.Drawing.Point(22, 51);
            this.txt_Resultado.Multiline = true;
            this.txt_Resultado.Name = "txt_Resultado";
            this.txt_Resultado.Size = new System.Drawing.Size(149, 33);
            this.txt_Resultado.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Digite um número:";
            // 
            // btn_Executar
            // 
            this.btn_Executar.Location = new System.Drawing.Point(52, 114);
            this.btn_Executar.Name = "btn_Executar";
            this.btn_Executar.Size = new System.Drawing.Size(103, 27);
            this.btn_Executar.TabIndex = 3;
            this.btn_Executar.Text = "Executar";
            this.btn_Executar.UseVisualStyleBackColor = true;
            this.btn_Executar.Click += new System.EventHandler(this.btn_Executar_Click);
            // 
            // Exercicio02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(201, 156);
            this.Controls.Add(this.btn_Executar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Resultado);
            this.Controls.Add(this.txt_Numero);
            this.Name = "Exercicio02";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exercicio02";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Numero;
        private System.Windows.Forms.TextBox txt_Resultado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Executar;
    }
}