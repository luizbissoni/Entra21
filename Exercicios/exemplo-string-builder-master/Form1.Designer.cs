namespace ExemploStringBuilder
{
    partial class Form1
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
            this.btn_Exemplo2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Exemplo01
            // 
            this.btn_Exemplo01.Location = new System.Drawing.Point(13, 13);
            this.btn_Exemplo01.Name = "btn_Exemplo01";
            this.btn_Exemplo01.Size = new System.Drawing.Size(75, 23);
            this.btn_Exemplo01.TabIndex = 0;
            this.btn_Exemplo01.Text = "Exemplo01";
            this.btn_Exemplo01.UseVisualStyleBackColor = true;
            this.btn_Exemplo01.Click += new System.EventHandler(this.btn_Exemplo01_Click);
            // 
            // btn_Exemplo2
            // 
            this.btn_Exemplo2.Location = new System.Drawing.Point(158, 12);
            this.btn_Exemplo2.Name = "btn_Exemplo2";
            this.btn_Exemplo2.Size = new System.Drawing.Size(75, 23);
            this.btn_Exemplo2.TabIndex = 1;
            this.btn_Exemplo2.Text = "Exemplo02";
            this.btn_Exemplo2.UseVisualStyleBackColor = true;
            this.btn_Exemplo2.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btn_Exemplo2);
            this.Controls.Add(this.btn_Exemplo01);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Exemplo01;
        private System.Windows.Forms.Button btn_Exemplo2;
    }
}

