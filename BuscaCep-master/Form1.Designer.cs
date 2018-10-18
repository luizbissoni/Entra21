namespace PesquisaPorCep
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_PesquisaCep = new System.Windows.Forms.Button();
            this.txt_CepDigitado = new System.Windows.Forms.TextBox();
            this.dgv_Resultado = new System.Windows.Forms.DataGridView();
            this.txt_Bairro = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Resultado)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite um CEP";
            // 
            // btn_PesquisaCep
            // 
            this.btn_PesquisaCep.Location = new System.Drawing.Point(229, 19);
            this.btn_PesquisaCep.Name = "btn_PesquisaCep";
            this.btn_PesquisaCep.Size = new System.Drawing.Size(75, 23);
            this.btn_PesquisaCep.TabIndex = 1;
            this.btn_PesquisaCep.Text = "Pesquisar";
            this.btn_PesquisaCep.UseVisualStyleBackColor = true;
            this.btn_PesquisaCep.Click += new System.EventHandler(this.btn_PesquisaCep_Click);
            // 
            // txt_CepDigitado
            // 
            this.txt_CepDigitado.Location = new System.Drawing.Point(110, 19);
            this.txt_CepDigitado.Name = "txt_CepDigitado";
            this.txt_CepDigitado.Size = new System.Drawing.Size(100, 20);
            this.txt_CepDigitado.TabIndex = 2;
            // 
            // dgv_Resultado
            // 
            this.dgv_Resultado.AllowUserToAddRows = false;
            this.dgv_Resultado.AllowUserToDeleteRows = false;
            this.dgv_Resultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Resultado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgv_Resultado.Location = new System.Drawing.Point(12, 62);
            this.dgv_Resultado.Name = "dgv_Resultado";
            this.dgv_Resultado.ReadOnly = true;
            this.dgv_Resultado.Size = new System.Drawing.Size(547, 204);
            this.dgv_Resultado.TabIndex = 3;
            // 
            // txt_Bairro
            // 
            this.txt_Bairro.Location = new System.Drawing.Point(477, 12);
            this.txt_Bairro.Name = "txt_Bairro";
            this.txt_Bairro.Size = new System.Drawing.Size(100, 20);
            this.txt_Bairro.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(434, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Bairro:";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Municipio";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Bairro";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Complemento";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Logradouro";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "UF";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 278);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Bairro);
            this.Controls.Add(this.dgv_Resultado);
            this.Controls.Add(this.txt_CepDigitado);
            this.Controls.Add(this.btn_PesquisaCep);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Resultado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_PesquisaCep;
        private System.Windows.Forms.TextBox txt_CepDigitado;
        private System.Windows.Forms.DataGridView dgv_Resultado;
        private System.Windows.Forms.TextBox txt_Bairro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}

