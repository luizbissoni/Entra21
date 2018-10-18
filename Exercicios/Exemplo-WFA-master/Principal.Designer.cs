namespace ExemploWFA
{
    partial class Principal
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
            this.btn_Exemplo01 = new System.Windows.Forms.Button();
            this.btn_Exemplo02 = new System.Windows.Forms.Button();
            this.btn_Exemplo03 = new System.Windows.Forms.Button();
            this.btn_Exemplo04 = new System.Windows.Forms.Button();
            this.btn_Exemplo05 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Exemplo01
            // 
            this.btn_Exemplo01.Location = new System.Drawing.Point(12, 62);
            this.btn_Exemplo01.Name = "btn_Exemplo01";
            this.btn_Exemplo01.Size = new System.Drawing.Size(75, 23);
            this.btn_Exemplo01.TabIndex = 0;
            this.btn_Exemplo01.Text = "Exercicio 01";
            this.btn_Exemplo01.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Exemplo01.UseVisualStyleBackColor = true;
            this.btn_Exemplo01.Click += new System.EventHandler(this.btn_Exemplo01_Click);
            // 
            // btn_Exemplo02
            // 
            this.btn_Exemplo02.Location = new System.Drawing.Point(93, 62);
            this.btn_Exemplo02.Name = "btn_Exemplo02";
            this.btn_Exemplo02.Size = new System.Drawing.Size(75, 23);
            this.btn_Exemplo02.TabIndex = 1;
            this.btn_Exemplo02.Text = "Exercicio 02";
            this.btn_Exemplo02.UseVisualStyleBackColor = true;
            this.btn_Exemplo02.Click += new System.EventHandler(this.btn_Exemplo02_Click);
            // 
            // btn_Exemplo03
            // 
            this.btn_Exemplo03.Location = new System.Drawing.Point(174, 62);
            this.btn_Exemplo03.Name = "btn_Exemplo03";
            this.btn_Exemplo03.Size = new System.Drawing.Size(75, 23);
            this.btn_Exemplo03.TabIndex = 2;
            this.btn_Exemplo03.Text = "Exemplo 03";
            this.btn_Exemplo03.UseVisualStyleBackColor = true;
            this.btn_Exemplo03.Click += new System.EventHandler(this.btn_Exemplo03_Click);
            // 
            // btn_Exemplo04
            // 
            this.btn_Exemplo04.Location = new System.Drawing.Point(12, 91);
            this.btn_Exemplo04.Name = "btn_Exemplo04";
            this.btn_Exemplo04.Size = new System.Drawing.Size(75, 23);
            this.btn_Exemplo04.TabIndex = 3;
            this.btn_Exemplo04.Text = "Exemplo 04";
            this.btn_Exemplo04.UseVisualStyleBackColor = true;
            this.btn_Exemplo04.Click += new System.EventHandler(this.btn_Exemplo04_Click);
            // 
            // btn_Exemplo05
            // 
            this.btn_Exemplo05.Location = new System.Drawing.Point(93, 91);
            this.btn_Exemplo05.Name = "btn_Exemplo05";
            this.btn_Exemplo05.Size = new System.Drawing.Size(75, 23);
            this.btn_Exemplo05.TabIndex = 4;
            this.btn_Exemplo05.Text = "Exemplo 05";
            this.btn_Exemplo05.UseVisualStyleBackColor = true;
            this.btn_Exemplo05.Click += new System.EventHandler(this.btn_Exemplo05_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Menu Exercicios";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 142);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Exemplo05);
            this.Controls.Add(this.btn_Exemplo04);
            this.Controls.Add(this.btn_Exemplo03);
            this.Controls.Add(this.btn_Exemplo02);
            this.Controls.Add(this.btn_Exemplo01);
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Exemplo01;
        private System.Windows.Forms.Button btn_Exemplo02;
        private System.Windows.Forms.Button btn_Exemplo03;
        private System.Windows.Forms.Button btn_Exemplo04;
        private System.Windows.Forms.Button btn_Exemplo05;
        private System.Windows.Forms.Label label1;
    }
}