namespace Exercicio_Fada
{
    partial class CadastroFadas
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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn_CadastroRapido = new System.Windows.Forms.Button();
            this.btn_Excluir = new System.Windows.Forms.Button();
            this.btn_Cadastro = new System.Windows.Forms.Button();
            this.dgv_ListaFada = new System.Windows.Forms.DataGridView();
            this.ColumnNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFamilia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTamanhoAsa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCorAsa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnElemento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCadastroRapido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cb_CorAsa = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_Elemento = new System.Windows.Forms.ComboBox();
            this.gb_Sexo = new System.Windows.Forms.GroupBox();
            this.cb_Feminino = new System.Windows.Forms.CheckBox();
            this.cb_Masculino = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cb_AsaQuebrada = new System.Windows.Forms.CheckBox();
            this.cb_AsaNaoQuebrada = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_FazBarulho = new System.Windows.Forms.CheckBox();
            this.cb_NaoFazBarulho = new System.Windows.Forms.CheckBox();
            this.btn_Salvar = new System.Windows.Forms.Button();
            this.cb_Cor = new System.Windows.Forms.ComboBox();
            this.cb_Familia = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_TamanhoAsa = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Nome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.cb_ElementoRapido1 = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cb_FemininoRapido1 = new System.Windows.Forms.CheckBox();
            this.cb_MasculinoRapido1 = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_NomeRapido1 = new System.Windows.Forms.TextBox();
            this.cb_FamiliaRapida1 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_SalvarRapido = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListaFada)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.gb_Sexo.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(749, 486);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btn_CadastroRapido);
            this.tabPage1.Controls.Add(this.btn_Excluir);
            this.tabPage1.Controls.Add(this.btn_Cadastro);
            this.tabPage1.Controls.Add(this.dgv_ListaFada);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(741, 460);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Lista Fada";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btn_CadastroRapido
            // 
            this.btn_CadastroRapido.Location = new System.Drawing.Point(6, 14);
            this.btn_CadastroRapido.Name = "btn_CadastroRapido";
            this.btn_CadastroRapido.Size = new System.Drawing.Size(103, 23);
            this.btn_CadastroRapido.TabIndex = 3;
            this.btn_CadastroRapido.Text = "Cadastro Rapido";
            this.btn_CadastroRapido.UseVisualStyleBackColor = true;
            this.btn_CadastroRapido.Click += new System.EventHandler(this.btn_CadastroRapido_Click);
            // 
            // btn_Excluir
            // 
            this.btn_Excluir.Location = new System.Drawing.Point(6, 423);
            this.btn_Excluir.Name = "btn_Excluir";
            this.btn_Excluir.Size = new System.Drawing.Size(103, 31);
            this.btn_Excluir.TabIndex = 2;
            this.btn_Excluir.Text = "Excluir";
            this.btn_Excluir.UseVisualStyleBackColor = true;
            this.btn_Excluir.Click += new System.EventHandler(this.btn_Excluir_Click);
            // 
            // btn_Cadastro
            // 
            this.btn_Cadastro.Location = new System.Drawing.Point(632, 6);
            this.btn_Cadastro.Name = "btn_Cadastro";
            this.btn_Cadastro.Size = new System.Drawing.Size(103, 31);
            this.btn_Cadastro.TabIndex = 1;
            this.btn_Cadastro.Text = "Cadastro";
            this.btn_Cadastro.UseVisualStyleBackColor = true;
            this.btn_Cadastro.Click += new System.EventHandler(this.btn_Cadastro_Click);
            // 
            // dgv_ListaFada
            // 
            this.dgv_ListaFada.AllowUserToAddRows = false;
            this.dgv_ListaFada.AllowUserToDeleteRows = false;
            this.dgv_ListaFada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ListaFada.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnNome,
            this.ColumnFamilia,
            this.ColumnSexo,
            this.ColumnTamanhoAsa,
            this.ColumnCorAsa,
            this.ColumnElemento,
            this.ColumnCadastroRapido});
            this.dgv_ListaFada.Location = new System.Drawing.Point(6, 43);
            this.dgv_ListaFada.Name = "dgv_ListaFada";
            this.dgv_ListaFada.ReadOnly = true;
            this.dgv_ListaFada.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgv_ListaFada.Size = new System.Drawing.Size(729, 374);
            this.dgv_ListaFada.TabIndex = 0;
            this.dgv_ListaFada.DoubleClick += new System.EventHandler(this.dgv_ListaFada_DoubleClick);
            // 
            // ColumnNome
            // 
            this.ColumnNome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnNome.HeaderText = "Nome";
            this.ColumnNome.Name = "ColumnNome";
            this.ColumnNome.ReadOnly = true;
            // 
            // ColumnFamilia
            // 
            this.ColumnFamilia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnFamilia.HeaderText = "Familia";
            this.ColumnFamilia.Name = "ColumnFamilia";
            this.ColumnFamilia.ReadOnly = true;
            // 
            // ColumnSexo
            // 
            this.ColumnSexo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnSexo.HeaderText = "Sexo";
            this.ColumnSexo.Name = "ColumnSexo";
            this.ColumnSexo.ReadOnly = true;
            // 
            // ColumnTamanhoAsa
            // 
            this.ColumnTamanhoAsa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnTamanhoAsa.HeaderText = "Tamanho Asa";
            this.ColumnTamanhoAsa.Name = "ColumnTamanhoAsa";
            this.ColumnTamanhoAsa.ReadOnly = true;
            // 
            // ColumnCorAsa
            // 
            this.ColumnCorAsa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnCorAsa.HeaderText = "Cor Asa";
            this.ColumnCorAsa.Name = "ColumnCorAsa";
            this.ColumnCorAsa.ReadOnly = true;
            // 
            // ColumnElemento
            // 
            this.ColumnElemento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnElemento.HeaderText = "Elemento";
            this.ColumnElemento.Name = "ColumnElemento";
            this.ColumnElemento.ReadOnly = true;
            // 
            // ColumnCadastroRapido
            // 
            this.ColumnCadastroRapido.HeaderText = "Cadastro Rápido";
            this.ColumnCadastroRapido.Name = "ColumnCadastroRapido";
            this.ColumnCadastroRapido.ReadOnly = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cb_CorAsa);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.cb_Elemento);
            this.tabPage2.Controls.Add(this.gb_Sexo);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.btn_Salvar);
            this.tabPage2.Controls.Add(this.cb_Cor);
            this.tabPage2.Controls.Add(this.cb_Familia);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.txt_TamanhoAsa);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.txt_Nome);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(741, 460);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Cadastro Fada";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // cb_CorAsa
            // 
            this.cb_CorAsa.FormattingEnabled = true;
            this.cb_CorAsa.Items.AddRange(new object[] {
            "Rosa",
            "Amarela",
            "Azul",
            "Verde",
            "Vermelha",
            "Laranja"});
            this.cb_CorAsa.Location = new System.Drawing.Point(486, 63);
            this.cb_CorAsa.Name = "cb_CorAsa";
            this.cb_CorAsa.Size = new System.Drawing.Size(121, 21);
            this.cb_CorAsa.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(436, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Cor Asa";
            // 
            // cb_Elemento
            // 
            this.cb_Elemento.FormattingEnabled = true;
            this.cb_Elemento.Items.AddRange(new object[] {
            "Terra",
            "Água",
            "Fogo",
            "Ar"});
            this.cb_Elemento.Location = new System.Drawing.Point(296, 59);
            this.cb_Elemento.Name = "cb_Elemento";
            this.cb_Elemento.Size = new System.Drawing.Size(121, 21);
            this.cb_Elemento.TabIndex = 20;
            // 
            // gb_Sexo
            // 
            this.gb_Sexo.Controls.Add(this.cb_Feminino);
            this.gb_Sexo.Controls.Add(this.cb_Masculino);
            this.gb_Sexo.Location = new System.Drawing.Point(402, 101);
            this.gb_Sexo.Name = "gb_Sexo";
            this.gb_Sexo.Size = new System.Drawing.Size(184, 56);
            this.gb_Sexo.TabIndex = 19;
            this.gb_Sexo.TabStop = false;
            this.gb_Sexo.Text = "Sexo";
            // 
            // cb_Feminino
            // 
            this.cb_Feminino.AutoSize = true;
            this.cb_Feminino.Location = new System.Drawing.Point(105, 32);
            this.cb_Feminino.Name = "cb_Feminino";
            this.cb_Feminino.Size = new System.Drawing.Size(68, 17);
            this.cb_Feminino.TabIndex = 1;
            this.cb_Feminino.Text = "Feminino";
            this.cb_Feminino.UseVisualStyleBackColor = true;
            // 
            // cb_Masculino
            // 
            this.cb_Masculino.AutoSize = true;
            this.cb_Masculino.Location = new System.Drawing.Point(19, 32);
            this.cb_Masculino.Name = "cb_Masculino";
            this.cb_Masculino.Size = new System.Drawing.Size(74, 17);
            this.cb_Masculino.TabIndex = 0;
            this.cb_Masculino.Text = "Masculino";
            this.cb_Masculino.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cb_AsaQuebrada);
            this.groupBox2.Controls.Add(this.cb_AsaNaoQuebrada);
            this.groupBox2.Location = new System.Drawing.Point(225, 100);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(156, 57);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Asa Quebrada";
            // 
            // cb_AsaQuebrada
            // 
            this.cb_AsaQuebrada.AutoSize = true;
            this.cb_AsaQuebrada.Location = new System.Drawing.Point(6, 19);
            this.cb_AsaQuebrada.Name = "cb_AsaQuebrada";
            this.cb_AsaQuebrada.Size = new System.Drawing.Size(45, 17);
            this.cb_AsaQuebrada.TabIndex = 15;
            this.cb_AsaQuebrada.Text = "SIM";
            this.cb_AsaQuebrada.UseVisualStyleBackColor = true;
            // 
            // cb_AsaNaoQuebrada
            // 
            this.cb_AsaNaoQuebrada.AutoSize = true;
            this.cb_AsaNaoQuebrada.Location = new System.Drawing.Point(93, 19);
            this.cb_AsaNaoQuebrada.Name = "cb_AsaNaoQuebrada";
            this.cb_AsaNaoQuebrada.Size = new System.Drawing.Size(49, 17);
            this.cb_AsaNaoQuebrada.TabIndex = 16;
            this.cb_AsaNaoQuebrada.Text = "NÂO";
            this.cb_AsaNaoQuebrada.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_FazBarulho);
            this.groupBox1.Controls.Add(this.cb_NaoFazBarulho);
            this.groupBox1.Location = new System.Drawing.Point(30, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(156, 57);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Faz Barulho?";
            // 
            // cb_FazBarulho
            // 
            this.cb_FazBarulho.AutoSize = true;
            this.cb_FazBarulho.Location = new System.Drawing.Point(6, 19);
            this.cb_FazBarulho.Name = "cb_FazBarulho";
            this.cb_FazBarulho.Size = new System.Drawing.Size(45, 17);
            this.cb_FazBarulho.TabIndex = 15;
            this.cb_FazBarulho.Text = "SIM";
            this.cb_FazBarulho.UseVisualStyleBackColor = true;
            // 
            // cb_NaoFazBarulho
            // 
            this.cb_NaoFazBarulho.AutoSize = true;
            this.cb_NaoFazBarulho.Location = new System.Drawing.Point(93, 19);
            this.cb_NaoFazBarulho.Name = "cb_NaoFazBarulho";
            this.cb_NaoFazBarulho.Size = new System.Drawing.Size(49, 17);
            this.cb_NaoFazBarulho.TabIndex = 16;
            this.cb_NaoFazBarulho.Text = "NÂO";
            this.cb_NaoFazBarulho.UseVisualStyleBackColor = true;
            // 
            // btn_Salvar
            // 
            this.btn_Salvar.Location = new System.Drawing.Point(25, 196);
            this.btn_Salvar.Name = "btn_Salvar";
            this.btn_Salvar.Size = new System.Drawing.Size(134, 54);
            this.btn_Salvar.TabIndex = 12;
            this.btn_Salvar.Text = "Salvar";
            this.btn_Salvar.UseVisualStyleBackColor = true;
            this.btn_Salvar.Click += new System.EventHandler(this.btn_Salvar_Click);
            // 
            // cb_Cor
            // 
            this.cb_Cor.FormattingEnabled = true;
            this.cb_Cor.Items.AddRange(new object[] {
            "Rosa",
            "Amarela",
            "Azul",
            "Verde",
            "Vermelha",
            "Laranja"});
            this.cb_Cor.Location = new System.Drawing.Point(481, 29);
            this.cb_Cor.Name = "cb_Cor";
            this.cb_Cor.Size = new System.Drawing.Size(121, 21);
            this.cb_Cor.TabIndex = 11;
            // 
            // cb_Familia
            // 
            this.cb_Familia.FormattingEnabled = true;
            this.cb_Familia.Items.AddRange(new object[] {
            "AGUANE",
            "AINE",
            "ANNA",
            "ANJANA",
            "ARAPTES ",
            "ARGAY"});
            this.cb_Familia.Location = new System.Drawing.Point(325, 28);
            this.cb_Familia.Name = "cb_Familia";
            this.cb_Familia.Size = new System.Drawing.Size(121, 21);
            this.cb_Familia.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(239, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Elemento";
            // 
            // txt_TamanhoAsa
            // 
            this.txt_TamanhoAsa.Location = new System.Drawing.Point(120, 55);
            this.txt_TamanhoAsa.Name = "txt_TamanhoAsa";
            this.txt_TamanhoAsa.Size = new System.Drawing.Size(100, 20);
            this.txt_TamanhoAsa.TabIndex = 7;
            this.txt_TamanhoAsa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_TamanhoAsa_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tamanho Asa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(452, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(280, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Familia";
            // 
            // txt_Nome
            // 
            this.txt_Nome.Location = new System.Drawing.Point(63, 29);
            this.txt_Nome.Name = "txt_Nome";
            this.txt_Nome.Size = new System.Drawing.Size(213, 20);
            this.txt_Nome.TabIndex = 1;
            this.txt_Nome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Nome_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.cb_ElementoRapido1);
            this.tabPage3.Controls.Add(this.groupBox3);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.txt_NomeRapido1);
            this.tabPage3.Controls.Add(this.cb_FamiliaRapida1);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.btn_SalvarRapido);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(741, 460);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Cadastro Rápido";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(178, 212);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "Elemento";
            // 
            // cb_ElementoRapido1
            // 
            this.cb_ElementoRapido1.FormattingEnabled = true;
            this.cb_ElementoRapido1.Items.AddRange(new object[] {
            "",
            "Terra",
            "Água",
            "Fogo",
            "Ar"});
            this.cb_ElementoRapido1.Location = new System.Drawing.Point(235, 209);
            this.cb_ElementoRapido1.Name = "cb_ElementoRapido1";
            this.cb_ElementoRapido1.Size = new System.Drawing.Size(121, 21);
            this.cb_ElementoRapido1.TabIndex = 29;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cb_FemininoRapido1);
            this.groupBox3.Controls.Add(this.cb_MasculinoRapido1);
            this.groupBox3.Location = new System.Drawing.Point(393, 121);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(184, 56);
            this.groupBox3.TabIndex = 28;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sexo";
            // 
            // cb_FemininoRapido1
            // 
            this.cb_FemininoRapido1.AutoSize = true;
            this.cb_FemininoRapido1.Location = new System.Drawing.Point(105, 32);
            this.cb_FemininoRapido1.Name = "cb_FemininoRapido1";
            this.cb_FemininoRapido1.Size = new System.Drawing.Size(68, 17);
            this.cb_FemininoRapido1.TabIndex = 1;
            this.cb_FemininoRapido1.Text = "Feminino";
            this.cb_FemininoRapido1.UseVisualStyleBackColor = true;
            // 
            // cb_MasculinoRapido1
            // 
            this.cb_MasculinoRapido1.AutoSize = true;
            this.cb_MasculinoRapido1.Location = new System.Drawing.Point(19, 32);
            this.cb_MasculinoRapido1.Name = "cb_MasculinoRapido1";
            this.cb_MasculinoRapido1.Size = new System.Drawing.Size(74, 17);
            this.cb_MasculinoRapido1.TabIndex = 0;
            this.cb_MasculinoRapido1.Text = "Masculino";
            this.cb_MasculinoRapido1.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(178, 170);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "Familia";
            // 
            // txt_NomeRapido1
            // 
            this.txt_NomeRapido1.Location = new System.Drawing.Point(204, 121);
            this.txt_NomeRapido1.Name = "txt_NomeRapido1";
            this.txt_NomeRapido1.Size = new System.Drawing.Size(157, 20);
            this.txt_NomeRapido1.TabIndex = 26;
            this.txt_NomeRapido1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_NomeRapido1_KeyPress);
            // 
            // cb_FamiliaRapida1
            // 
            this.cb_FamiliaRapida1.FormattingEnabled = true;
            this.cb_FamiliaRapida1.Items.AddRange(new object[] {
            "",
            "AGUANE",
            "AINE",
            "ANNA",
            "ANJANA",
            "ARAPTES ",
            "ARGAY"});
            this.cb_FamiliaRapida1.Location = new System.Drawing.Point(223, 167);
            this.cb_FamiliaRapida1.Name = "cb_FamiliaRapida1";
            this.cb_FamiliaRapida1.Size = new System.Drawing.Size(121, 21);
            this.cb_FamiliaRapida1.TabIndex = 25;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(163, 124);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "Nome";
            // 
            // btn_SalvarRapido
            // 
            this.btn_SalvarRapido.Location = new System.Drawing.Point(295, 304);
            this.btn_SalvarRapido.Name = "btn_SalvarRapido";
            this.btn_SalvarRapido.Size = new System.Drawing.Size(128, 35);
            this.btn_SalvarRapido.TabIndex = 23;
            this.btn_SalvarRapido.Text = "Salvar";
            this.btn_SalvarRapido.UseVisualStyleBackColor = true;
            this.btn_SalvarRapido.Click += new System.EventHandler(this.btn_SalvarRapido_Click);
            // 
            // CadastroFadas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 510);
            this.Controls.Add(this.tabControl1);
            this.Name = "CadastroFadas";
            this.Text = "Gerenciador de Fadas";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListaFada)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.gb_Sexo.ResumeLayout(false);
            this.gb_Sexo.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btn_Excluir;
        private System.Windows.Forms.Button btn_Cadastro;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFamilia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTamanhoAsa;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCorAsa;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnElemento;
        private System.Windows.Forms.TextBox txt_Nome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_TamanhoAsa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_Cor;
        private System.Windows.Forms.ComboBox cb_Familia;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cb_FazBarulho;
        private System.Windows.Forms.CheckBox cb_NaoFazBarulho;
        private System.Windows.Forms.Button btn_Salvar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox cb_AsaQuebrada;
        private System.Windows.Forms.CheckBox cb_AsaNaoQuebrada;
        private System.Windows.Forms.GroupBox gb_Sexo;
        private System.Windows.Forms.CheckBox cb_Feminino;
        private System.Windows.Forms.CheckBox cb_Masculino;
        private System.Windows.Forms.ComboBox cb_Elemento;
        private System.Windows.Forms.Button btn_CadastroRapido;
        private System.Windows.Forms.ComboBox cb_CorAsa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCadastroRapido;
        public System.Windows.Forms.DataGridView dgv_ListaFada;
        public System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.ComboBox cb_ElementoRapido1;
        private System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.CheckBox cb_FemininoRapido1;
        public System.Windows.Forms.CheckBox cb_MasculinoRapido1;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox txt_NomeRapido1;
        public System.Windows.Forms.ComboBox cb_FamiliaRapida1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_SalvarRapido;
    }
}

