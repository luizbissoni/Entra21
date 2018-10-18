namespace SistemaEscolar
{
    partial class SugestaoBug
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
            this.txt_Enviar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.txt_Assunto = new System.Windows.Forms.TextBox();
            this.txt_Menssagem = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txt_Enviar
            // 
            this.txt_Enviar.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Enviar.Location = new System.Drawing.Point(155, 439);
            this.txt_Enviar.Name = "txt_Enviar";
            this.txt_Enviar.Size = new System.Drawing.Size(97, 37);
            this.txt_Enviar.TabIndex = 4;
            this.txt_Enviar.Text = "Enviar";
            this.txt_Enviar.UseVisualStyleBackColor = true;
            this.txt_Enviar.Click += new System.EventHandler(this.txt_Enviar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(91, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sujestão ou Bug envie um E-Mail ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "E-Mail";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Assunto";
            // 
            // txt_Email
            // 
            this.txt_Email.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Email.Location = new System.Drawing.Point(95, 68);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(217, 25);
            this.txt_Email.TabIndex = 1;
            // 
            // txt_Assunto
            // 
            this.txt_Assunto.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Assunto.Location = new System.Drawing.Point(95, 122);
            this.txt_Assunto.Name = "txt_Assunto";
            this.txt_Assunto.Size = new System.Drawing.Size(217, 25);
            this.txt_Assunto.TabIndex = 2;
            // 
            // txt_Menssagem
            // 
            this.txt_Menssagem.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Menssagem.Location = new System.Drawing.Point(95, 187);
            this.txt_Menssagem.Multiline = true;
            this.txt_Menssagem.Name = "txt_Menssagem";
            this.txt_Menssagem.Size = new System.Drawing.Size(217, 207);
            this.txt_Menssagem.TabIndex = 3;
            // 
            // SugestaoBug
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 488);
            this.Controls.Add(this.txt_Menssagem);
            this.Controls.Add(this.txt_Assunto);
            this.Controls.Add(this.txt_Email);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Enviar);
            this.Name = "SugestaoBug";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SugestaoBug";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button txt_Enviar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.TextBox txt_Assunto;
        private System.Windows.Forms.TextBox txt_Menssagem;
    }
}