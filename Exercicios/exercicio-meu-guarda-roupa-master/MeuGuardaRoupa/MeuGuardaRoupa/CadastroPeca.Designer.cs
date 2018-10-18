namespace MeuGuardaRoupa
{
    partial class CadastroPeca
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_Nome = new System.Windows.Forms.TextBox();
            this.txt_Valor = new System.Windows.Forms.TextBox();
            this.dtp_DataCompra = new System.Windows.Forms.DateTimePicker();
            this.cb_Tamanho = new System.Windows.Forms.ComboBox();
            this.cb_Marca = new System.Windows.Forms.ComboBox();
            this.cb_Cor = new System.Windows.Forms.ComboBox();
            this.cb_Tecido = new System.Windows.Forms.ComboBox();
            this.cb_Tipo = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.rb_Ativo = new System.Windows.Forms.RadioButton();
            this.rb_Inativo = new System.Windows.Forms.RadioButton();
            this.btn_Salvar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tipo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(471, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tamanho";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(591, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Valor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(486, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Marca";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Cor";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(186, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Data da Compra";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(483, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Tecido";
            // 
            // txt_Nome
            // 
            this.txt_Nome.Location = new System.Drawing.Point(59, 19);
            this.txt_Nome.Name = "txt_Nome";
            this.txt_Nome.Size = new System.Drawing.Size(391, 20);
            this.txt_Nome.TabIndex = 1;
            // 
            // txt_Valor
            // 
            this.txt_Valor.Location = new System.Drawing.Point(628, 23);
            this.txt_Valor.Name = "txt_Valor";
            this.txt_Valor.Size = new System.Drawing.Size(100, 20);
            this.txt_Valor.TabIndex = 4;
            // 
            // dtp_DataCompra
            // 
            this.dtp_DataCompra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_DataCompra.Location = new System.Drawing.Point(276, 77);
            this.dtp_DataCompra.Name = "dtp_DataCompra";
            this.dtp_DataCompra.Size = new System.Drawing.Size(102, 20);
            this.dtp_DataCompra.TabIndex = 7;
            // 
            // cb_Tamanho
            // 
            this.cb_Tamanho.FormattingEnabled = true;
            this.cb_Tamanho.Location = new System.Drawing.Point(529, 19);
            this.cb_Tamanho.Name = "cb_Tamanho";
            this.cb_Tamanho.Size = new System.Drawing.Size(44, 21);
            this.cb_Tamanho.TabIndex = 3;
            // 
            // cb_Marca
            // 
            this.cb_Marca.FormattingEnabled = true;
            this.cb_Marca.Items.AddRange(new object[] {
            "Adidas ",
            "Nike"});
            this.cb_Marca.Location = new System.Drawing.Point(529, 49);
            this.cb_Marca.Name = "cb_Marca";
            this.cb_Marca.Size = new System.Drawing.Size(121, 21);
            this.cb_Marca.TabIndex = 5;
            // 
            // cb_Cor
            // 
            this.cb_Cor.FormattingEnabled = true;
            this.cb_Cor.Items.AddRange(new object[] {
            "azul",
            "preto",
            "amarelo"});
            this.cb_Cor.Location = new System.Drawing.Point(59, 74);
            this.cb_Cor.Name = "cb_Cor";
            this.cb_Cor.Size = new System.Drawing.Size(121, 21);
            this.cb_Cor.TabIndex = 6;
            // 
            // cb_Tecido
            // 
            this.cb_Tecido.FormattingEnabled = true;
            this.cb_Tecido.Items.AddRange(new object[] {
            "seda",
            "lã",
            "algodão"});
            this.cb_Tecido.Location = new System.Drawing.Point(529, 77);
            this.cb_Tecido.Name = "cb_Tecido";
            this.cb_Tecido.Size = new System.Drawing.Size(121, 21);
            this.cb_Tecido.TabIndex = 8;
            // 
            // cb_Tipo
            // 
            this.cb_Tipo.FormattingEnabled = true;
            this.cb_Tipo.Items.AddRange(new object[] {
            "Blusa",
            "Casaco",
            "Camisa",
            "Jaqueta",
            "Meia",
            "Calça",
            "Shorts",
            "Boné",
            "Roupa Intima"});
            this.cb_Tipo.Location = new System.Drawing.Point(59, 47);
            this.cb_Tipo.Name = "cb_Tipo";
            this.cb_Tipo.Size = new System.Drawing.Size(391, 21);
            this.cb_Tipo.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(273, 110);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Status";
            // 
            // rb_Ativo
            // 
            this.rb_Ativo.AutoSize = true;
            this.rb_Ativo.Checked = true;
            this.rb_Ativo.Location = new System.Drawing.Point(316, 110);
            this.rb_Ativo.Name = "rb_Ativo";
            this.rb_Ativo.Size = new System.Drawing.Size(49, 17);
            this.rb_Ativo.TabIndex = 9;
            this.rb_Ativo.TabStop = true;
            this.rb_Ativo.Text = "Ativo";
            this.rb_Ativo.UseVisualStyleBackColor = true;
            // 
            // rb_Inativo
            // 
            this.rb_Inativo.AutoSize = true;
            this.rb_Inativo.Location = new System.Drawing.Point(371, 110);
            this.rb_Inativo.Name = "rb_Inativo";
            this.rb_Inativo.Size = new System.Drawing.Size(57, 17);
            this.rb_Inativo.TabIndex = 10;
            this.rb_Inativo.TabStop = true;
            this.rb_Inativo.Text = "Inativo";
            this.rb_Inativo.UseVisualStyleBackColor = true;
            // 
            // btn_Salvar
            // 
            this.btn_Salvar.Location = new System.Drawing.Point(195, 201);
            this.btn_Salvar.Name = "btn_Salvar";
            this.btn_Salvar.Size = new System.Drawing.Size(100, 23);
            this.btn_Salvar.TabIndex = 17;
            this.btn_Salvar.Text = "Salvar";
            this.btn_Salvar.UseVisualStyleBackColor = true;
            this.btn_Salvar.Click += new System.EventHandler(this.btn_Salvar_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(316, 201);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(100, 23);
            this.btn_Cancelar.TabIndex = 18;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // CadastroPeca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 236);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Salvar);
            this.Controls.Add(this.rb_Inativo);
            this.Controls.Add(this.rb_Ativo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cb_Tipo);
            this.Controls.Add(this.cb_Tecido);
            this.Controls.Add(this.cb_Cor);
            this.Controls.Add(this.cb_Marca);
            this.Controls.Add(this.cb_Tamanho);
            this.Controls.Add(this.dtp_DataCompra);
            this.Controls.Add(this.txt_Valor);
            this.Controls.Add(this.txt_Nome);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CadastroPeca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Peças";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_Nome;
        private System.Windows.Forms.TextBox txt_Valor;
        private System.Windows.Forms.DateTimePicker dtp_DataCompra;
        private System.Windows.Forms.ComboBox cb_Tamanho;
        private System.Windows.Forms.ComboBox cb_Marca;
        private System.Windows.Forms.ComboBox cb_Cor;
        private System.Windows.Forms.ComboBox cb_Tecido;
        private System.Windows.Forms.ComboBox cb_Tipo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton rb_Ativo;
        private System.Windows.Forms.RadioButton rb_Inativo;
        private System.Windows.Forms.Button btn_Salvar;
        private System.Windows.Forms.Button btn_Cancelar;
    }
}