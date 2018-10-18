namespace ExemploStringBuilder
{
    partial class Exemplo01
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
            this.txt_Nome1 = new System.Windows.Forms.TextBox();
            this.txt_Nome2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Nome3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Processar = new System.Windows.Forms.Button();
            this.lb_Resultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // txt_Nome1
            // 
            this.txt_Nome1.Location = new System.Drawing.Point(53, 25);
            this.txt_Nome1.Name = "txt_Nome1";
            this.txt_Nome1.Size = new System.Drawing.Size(184, 20);
            this.txt_Nome1.TabIndex = 1;
            // 
            // txt_Nome2
            // 
            this.txt_Nome2.Location = new System.Drawing.Point(53, 51);
            this.txt_Nome2.Name = "txt_Nome2";
            this.txt_Nome2.Size = new System.Drawing.Size(184, 20);
            this.txt_Nome2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome";
            // 
            // txt_Nome3
            // 
            this.txt_Nome3.Location = new System.Drawing.Point(53, 77);
            this.txt_Nome3.Name = "txt_Nome3";
            this.txt_Nome3.Size = new System.Drawing.Size(184, 20);
            this.txt_Nome3.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nome";
            // 
            // btn_Processar
            // 
            this.btn_Processar.Location = new System.Drawing.Point(162, 103);
            this.btn_Processar.Name = "btn_Processar";
            this.btn_Processar.Size = new System.Drawing.Size(75, 23);
            this.btn_Processar.TabIndex = 6;
            this.btn_Processar.Text = "Processar";
            this.btn_Processar.UseVisualStyleBackColor = true;
            this.btn_Processar.Click += new System.EventHandler(this.btn_Processar_Click);
            // 
            // lb_Resultado
            // 
            this.lb_Resultado.AutoSize = true;
            this.lb_Resultado.Location = new System.Drawing.Point(11, 169);
            this.lb_Resultado.Name = "lb_Resultado";
            this.lb_Resultado.Size = new System.Drawing.Size(0, 13);
            this.lb_Resultado.TabIndex = 7;
            // 
            // Exemplo01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lb_Resultado);
            this.Controls.Add(this.btn_Processar);
            this.Controls.Add(this.txt_Nome3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Nome2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Nome1);
            this.Controls.Add(this.label1);
            this.Name = "Exemplo01";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exemplo01";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Nome1;
        private System.Windows.Forms.TextBox txt_Nome2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Nome3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Processar;
        private System.Windows.Forms.Label lb_Resultado;
    }
}