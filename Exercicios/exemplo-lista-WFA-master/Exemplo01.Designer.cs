namespace ExemploListaWFA
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
            this.bnt_Cadastrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Numero = new System.Windows.Forms.TextBox();
            this.rtb_Numero = new System.Windows.Forms.RichTextBox();
            this.btn_Processar = new System.Windows.Forms.Button();
            this.txt_Apagar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_ValorparaApagar = new System.Windows.Forms.TextBox();
            this.cb_Selecionar = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_NumeroEditar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bnt_Cadastrar
            // 
            this.bnt_Cadastrar.Location = new System.Drawing.Point(184, 24);
            this.bnt_Cadastrar.Name = "bnt_Cadastrar";
            this.bnt_Cadastrar.Size = new System.Drawing.Size(75, 23);
            this.bnt_Cadastrar.TabIndex = 2;
            this.bnt_Cadastrar.Text = "Cadastrar";
            this.bnt_Cadastrar.UseVisualStyleBackColor = true;
            this.bnt_Cadastrar.Click += new System.EventHandler(this.bnt_Cadastrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Número";
            // 
            // txt_Numero
            // 
            this.txt_Numero.Location = new System.Drawing.Point(64, 24);
            this.txt_Numero.Name = "txt_Numero";
            this.txt_Numero.Size = new System.Drawing.Size(100, 20);
            this.txt_Numero.TabIndex = 1;
            this.txt_Numero.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Numero_KeyDown);
            // 
            // rtb_Numero
            // 
            this.rtb_Numero.Location = new System.Drawing.Point(16, 62);
            this.rtb_Numero.Name = "rtb_Numero";
            this.rtb_Numero.Size = new System.Drawing.Size(243, 187);
            this.rtb_Numero.TabIndex = 3;
            this.rtb_Numero.Text = "";
            // 
            // btn_Processar
            // 
            this.btn_Processar.Location = new System.Drawing.Point(137, 259);
            this.btn_Processar.Name = "btn_Processar";
            this.btn_Processar.Size = new System.Drawing.Size(122, 23);
            this.btn_Processar.TabIndex = 3;
            this.btn_Processar.Text = "Processar";
            this.btn_Processar.UseVisualStyleBackColor = true;
            this.btn_Processar.Click += new System.EventHandler(this.btn_Processar_Click);
            // 
            // txt_Apagar
            // 
            this.txt_Apagar.Location = new System.Drawing.Point(348, 51);
            this.txt_Apagar.Name = "txt_Apagar";
            this.txt_Apagar.Size = new System.Drawing.Size(100, 20);
            this.txt_Apagar.TabIndex = 4;
            this.txt_Apagar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(361, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "posição";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(361, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "valor para apagar";
            // 
            // txt_ValorparaApagar
            // 
            this.txt_ValorparaApagar.Location = new System.Drawing.Point(348, 97);
            this.txt_ValorparaApagar.Name = "txt_ValorparaApagar";
            this.txt_ValorparaApagar.Size = new System.Drawing.Size(100, 20);
            this.txt_ValorparaApagar.TabIndex = 7;
            this.txt_ValorparaApagar.Leave += new System.EventHandler(this.txt_ValorparaApagar_Leave);
            // 
            // cb_Selecionar
            // 
            this.cb_Selecionar.FormattingEnabled = true;
            this.cb_Selecionar.Location = new System.Drawing.Point(289, 146);
            this.cb_Selecionar.Name = "cb_Selecionar";
            this.cb_Selecionar.Size = new System.Drawing.Size(211, 21);
            this.cb_Selecionar.TabIndex = 9;
            this.cb_Selecionar.SelectedIndexChanged += new System.EventHandler(this.cb_Selecionar_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(297, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "selecione para editar";
            // 
            // txt_NumeroEditar
            // 
            this.txt_NumeroEditar.Enabled = false;
            this.txt_NumeroEditar.Location = new System.Drawing.Point(289, 192);
            this.txt_NumeroEditar.Name = "txt_NumeroEditar";
            this.txt_NumeroEditar.Size = new System.Drawing.Size(211, 20);
            this.txt_NumeroEditar.TabIndex = 11;
            this.txt_NumeroEditar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_NumeroEditar_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(286, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Número";
            // 
            // Exemplo01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 294);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_NumeroEditar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cb_Selecionar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_ValorparaApagar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Apagar);
            this.Controls.Add(this.btn_Processar);
            this.Controls.Add(this.rtb_Numero);
            this.Controls.Add(this.txt_Numero);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bnt_Cadastrar);
            this.Name = "Exemplo01";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exemplo01";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bnt_Cadastrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Numero;
        private System.Windows.Forms.RichTextBox rtb_Numero;
        private System.Windows.Forms.Button btn_Processar;
        private System.Windows.Forms.TextBox txt_Apagar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_ValorparaApagar;
        private System.Windows.Forms.ComboBox cb_Selecionar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_NumeroEditar;
        private System.Windows.Forms.Label label5;
    }
}