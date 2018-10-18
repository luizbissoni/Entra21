namespace Gerenciador_DePoneisOO
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
            this.txt_Apelido = new System.Windows.Forms.TextBox();
            this.cb_Raca = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_NivelFofura = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_CorCrista = new System.Windows.Forms.ComboBox();
            this.rb_Vivo = new System.Windows.Forms.RadioButton();
            this.rb_Morto = new System.Windows.Forms.RadioButton();
            this.cb_Dancarino = new System.Windows.Forms.CheckBox();
            this.cb_Localidade = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.rtb_Descricao = new System.Windows.Forms.RichTextBox();
            this.btn_CadastrarFofura = new System.Windows.Forms.Button();
            this.dgv_Poneys = new System.Windows.Forms.DataGridView();
            this.ColumnApelido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnRaca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tb_NivelFofura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Poneys)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Apelido";
            // 
            // txt_Apelido
            // 
            this.txt_Apelido.Location = new System.Drawing.Point(99, 16);
            this.txt_Apelido.Name = "txt_Apelido";
            this.txt_Apelido.Size = new System.Drawing.Size(185, 20);
            this.txt_Apelido.TabIndex = 1;
            // 
            // cb_Raca
            // 
            this.cb_Raca.FormattingEnabled = true;
            this.cb_Raca.Items.AddRange(new object[] {
            "Fofo níbel Estágiario",
            "Fofo nível Master",
            "Fofo nível Senior",
            "Fofo nível Pleno"});
            this.cb_Raca.Location = new System.Drawing.Point(99, 43);
            this.cb_Raca.Name = "cb_Raca";
            this.cb_Raca.Size = new System.Drawing.Size(185, 21);
            this.cb_Raca.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Raça";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nivel de Fofura";
            // 
            // tb_NivelFofura
            // 
            this.tb_NivelFofura.LargeChange = 3;
            this.tb_NivelFofura.Location = new System.Drawing.Point(99, 66);
            this.tb_NivelFofura.Maximum = 100;
            this.tb_NivelFofura.Minimum = 25;
            this.tb_NivelFofura.Name = "tb_NivelFofura";
            this.tb_NivelFofura.Size = new System.Drawing.Size(185, 45);
            this.tb_NivelFofura.TabIndex = 5;
            this.tb_NivelFofura.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tb_NivelFofura.Value = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Cor Crista";
            // 
            // cb_CorCrista
            // 
            this.cb_CorCrista.FormattingEnabled = true;
            this.cb_CorCrista.Items.AddRange(new object[] {
            "Rosê",
            "Pink",
            "Fuschia",
            "Magenta"});
            this.cb_CorCrista.Location = new System.Drawing.Point(99, 98);
            this.cb_CorCrista.Name = "cb_CorCrista";
            this.cb_CorCrista.Size = new System.Drawing.Size(185, 21);
            this.cb_CorCrista.TabIndex = 7;
            // 
            // rb_Vivo
            // 
            this.rb_Vivo.AutoSize = true;
            this.rb_Vivo.Location = new System.Drawing.Point(99, 122);
            this.rb_Vivo.Name = "rb_Vivo";
            this.rb_Vivo.Size = new System.Drawing.Size(46, 17);
            this.rb_Vivo.TabIndex = 8;
            this.rb_Vivo.TabStop = true;
            this.rb_Vivo.Text = "Vivo";
            this.rb_Vivo.UseVisualStyleBackColor = true;
            // 
            // rb_Morto
            // 
            this.rb_Morto.AutoSize = true;
            this.rb_Morto.Location = new System.Drawing.Point(168, 122);
            this.rb_Morto.Name = "rb_Morto";
            this.rb_Morto.Size = new System.Drawing.Size(52, 17);
            this.rb_Morto.TabIndex = 9;
            this.rb_Morto.TabStop = true;
            this.rb_Morto.Text = "Morto";
            this.rb_Morto.UseVisualStyleBackColor = true;
            // 
            // cb_Dancarino
            // 
            this.cb_Dancarino.AutoSize = true;
            this.cb_Dancarino.Location = new System.Drawing.Point(226, 125);
            this.cb_Dancarino.Name = "cb_Dancarino";
            this.cb_Dancarino.Size = new System.Drawing.Size(75, 17);
            this.cb_Dancarino.TabIndex = 10;
            this.cb_Dancarino.Text = "Dançarino";
            this.cb_Dancarino.UseVisualStyleBackColor = true;
            // 
            // cb_Localidade
            // 
            this.cb_Localidade.FormattingEnabled = true;
            this.cb_Localidade.Items.AddRange(new object[] {
            "MetroPoney",
            "PoneyCity",
            "NovaPoney"});
            this.cb_Localidade.Location = new System.Drawing.Point(99, 169);
            this.cb_Localidade.Name = "cb_Localidade";
            this.cb_Localidade.Size = new System.Drawing.Size(185, 21);
            this.cb_Localidade.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Localidade";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 241);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Descrição";
            // 
            // rtb_Descricao
            // 
            this.rtb_Descricao.Location = new System.Drawing.Point(99, 197);
            this.rtb_Descricao.Name = "rtb_Descricao";
            this.rtb_Descricao.Size = new System.Drawing.Size(185, 104);
            this.rtb_Descricao.TabIndex = 14;
            this.rtb_Descricao.Text = "";
            // 
            // btn_CadastrarFofura
            // 
            this.btn_CadastrarFofura.Location = new System.Drawing.Point(132, 336);
            this.btn_CadastrarFofura.Name = "btn_CadastrarFofura";
            this.btn_CadastrarFofura.Size = new System.Drawing.Size(152, 23);
            this.btn_CadastrarFofura.TabIndex = 15;
            this.btn_CadastrarFofura.Text = "Cadastrar essa fofura";
            this.btn_CadastrarFofura.UseVisualStyleBackColor = true;
            this.btn_CadastrarFofura.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgv_Poneys
            // 
            this.dgv_Poneys.AllowUserToAddRows = false;
            this.dgv_Poneys.AllowUserToDeleteRows = false;
            this.dgv_Poneys.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Poneys.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnApelido,
            this.ColumnRaca});
            this.dgv_Poneys.Location = new System.Drawing.Point(307, 66);
            this.dgv_Poneys.Name = "dgv_Poneys";
            this.dgv_Poneys.ReadOnly = true;
            this.dgv_Poneys.Size = new System.Drawing.Size(250, 289);
            this.dgv_Poneys.TabIndex = 16;
            // 
            // ColumnApelido
            // 
            this.ColumnApelido.HeaderText = "Apelido";
            this.ColumnApelido.Name = "ColumnApelido";
            this.ColumnApelido.ReadOnly = true;
            // 
            // ColumnRaca
            // 
            this.ColumnRaca.HeaderText = "Raça";
            this.ColumnRaca.Name = "ColumnRaca";
            this.ColumnRaca.ReadOnly = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(304, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Poneys cadastrados";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 389);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgv_Poneys);
            this.Controls.Add(this.btn_CadastrarFofura);
            this.Controls.Add(this.rtb_Descricao);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cb_Localidade);
            this.Controls.Add(this.cb_Dancarino);
            this.Controls.Add(this.rb_Morto);
            this.Controls.Add(this.rb_Vivo);
            this.Controls.Add(this.cb_CorCrista);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_NivelFofura);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_Raca);
            this.Controls.Add(this.txt_Apelido);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Cadastrar essa Fofura";
            ((System.ComponentModel.ISupportInitialize)(this.tb_NivelFofura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Poneys)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Apelido;
        private System.Windows.Forms.ComboBox cb_Raca;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar tb_NivelFofura;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_CorCrista;
        private System.Windows.Forms.RadioButton rb_Vivo;
        private System.Windows.Forms.RadioButton rb_Morto;
        private System.Windows.Forms.CheckBox cb_Dancarino;
        private System.Windows.Forms.ComboBox cb_Localidade;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox rtb_Descricao;
        private System.Windows.Forms.Button btn_CadastrarFofura;
        private System.Windows.Forms.DataGridView dgv_Poneys;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnApelido;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnRaca;
        private System.Windows.Forms.Label label7;
    }
}

