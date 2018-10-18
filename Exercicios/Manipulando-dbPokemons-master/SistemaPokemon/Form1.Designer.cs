namespace SistemaPokemon
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
            this.components = new System.ComponentModel.Container();
            this.dgv_Pokemons = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alturaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pesoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ataqueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.defesaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.especialataqueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.especialdefesaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.velocidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pokemonsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pokemonsDataSet = new SistemaPokemon.pokemonsDataSet();
            this.pokemonsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pokemonsTableAdapter = new SistemaPokemon.pokemonsDataSetTableAdapters.pokemonsTableAdapter();
            this.btn_Salvar = new System.Windows.Forms.Button();
            this.pokemonsBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.pokemonsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.fillToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Nome = new System.Windows.Forms.TextBox();
            this.txt_Altura = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Peso = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_HP = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Ataque = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Defesa = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_EspecialAtaque = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_EspecialDefesa = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_Velocidade = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_Descricao = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cb_Categoria = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.pokemonsDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pokemonsBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.pokemonsBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.btn_Ordenar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Pokemons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokemonsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokemonsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokemonsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokemonsBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokemonsBindingSource2)).BeginInit();
            this.fillToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pokemonsDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokemonsBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokemonsBindingSource5)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Pokemons
            // 
            this.dgv_Pokemons.AllowUserToAddRows = false;
            this.dgv_Pokemons.AllowUserToDeleteRows = false;
            this.dgv_Pokemons.AutoGenerateColumns = false;
            this.dgv_Pokemons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Pokemons.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.codigoDataGridViewTextBoxColumn,
            this.categoriaDataGridViewTextBoxColumn,
            this.alturaDataGridViewTextBoxColumn,
            this.pesoDataGridViewTextBoxColumn,
            this.hpDataGridViewTextBoxColumn,
            this.ataqueDataGridViewTextBoxColumn,
            this.defesaDataGridViewTextBoxColumn,
            this.especialataqueDataGridViewTextBoxColumn,
            this.especialdefesaDataGridViewTextBoxColumn,
            this.velocidadeDataGridViewTextBoxColumn,
            this.descricaoDataGridViewTextBoxColumn});
            this.dgv_Pokemons.DataSource = this.pokemonsBindingSource1;
            this.dgv_Pokemons.Location = new System.Drawing.Point(12, 270);
            this.dgv_Pokemons.Name = "dgv_Pokemons";
            this.dgv_Pokemons.ReadOnly = true;
            this.dgv_Pokemons.Size = new System.Drawing.Size(1382, 283);
            this.dgv_Pokemons.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // codigoDataGridViewTextBoxColumn
            // 
            this.codigoDataGridViewTextBoxColumn.DataPropertyName = "codigo";
            this.codigoDataGridViewTextBoxColumn.HeaderText = "codigo";
            this.codigoDataGridViewTextBoxColumn.Name = "codigoDataGridViewTextBoxColumn";
            this.codigoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // categoriaDataGridViewTextBoxColumn
            // 
            this.categoriaDataGridViewTextBoxColumn.DataPropertyName = "categoria";
            this.categoriaDataGridViewTextBoxColumn.HeaderText = "categoria";
            this.categoriaDataGridViewTextBoxColumn.Name = "categoriaDataGridViewTextBoxColumn";
            this.categoriaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // alturaDataGridViewTextBoxColumn
            // 
            this.alturaDataGridViewTextBoxColumn.DataPropertyName = "altura";
            this.alturaDataGridViewTextBoxColumn.HeaderText = "altura";
            this.alturaDataGridViewTextBoxColumn.Name = "alturaDataGridViewTextBoxColumn";
            this.alturaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pesoDataGridViewTextBoxColumn
            // 
            this.pesoDataGridViewTextBoxColumn.DataPropertyName = "peso";
            this.pesoDataGridViewTextBoxColumn.HeaderText = "peso";
            this.pesoDataGridViewTextBoxColumn.Name = "pesoDataGridViewTextBoxColumn";
            this.pesoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hpDataGridViewTextBoxColumn
            // 
            this.hpDataGridViewTextBoxColumn.DataPropertyName = "hp";
            this.hpDataGridViewTextBoxColumn.HeaderText = "hp";
            this.hpDataGridViewTextBoxColumn.Name = "hpDataGridViewTextBoxColumn";
            this.hpDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ataqueDataGridViewTextBoxColumn
            // 
            this.ataqueDataGridViewTextBoxColumn.DataPropertyName = "ataque";
            this.ataqueDataGridViewTextBoxColumn.HeaderText = "ataque";
            this.ataqueDataGridViewTextBoxColumn.Name = "ataqueDataGridViewTextBoxColumn";
            this.ataqueDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // defesaDataGridViewTextBoxColumn
            // 
            this.defesaDataGridViewTextBoxColumn.DataPropertyName = "defesa";
            this.defesaDataGridViewTextBoxColumn.HeaderText = "defesa";
            this.defesaDataGridViewTextBoxColumn.Name = "defesaDataGridViewTextBoxColumn";
            this.defesaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // especialataqueDataGridViewTextBoxColumn
            // 
            this.especialataqueDataGridViewTextBoxColumn.DataPropertyName = "especial_ataque";
            this.especialataqueDataGridViewTextBoxColumn.HeaderText = "especial_ataque";
            this.especialataqueDataGridViewTextBoxColumn.Name = "especialataqueDataGridViewTextBoxColumn";
            this.especialataqueDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // especialdefesaDataGridViewTextBoxColumn
            // 
            this.especialdefesaDataGridViewTextBoxColumn.DataPropertyName = "especial_defesa";
            this.especialdefesaDataGridViewTextBoxColumn.HeaderText = "especial_defesa";
            this.especialdefesaDataGridViewTextBoxColumn.Name = "especialdefesaDataGridViewTextBoxColumn";
            this.especialdefesaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // velocidadeDataGridViewTextBoxColumn
            // 
            this.velocidadeDataGridViewTextBoxColumn.DataPropertyName = "velocidade";
            this.velocidadeDataGridViewTextBoxColumn.HeaderText = "velocidade";
            this.velocidadeDataGridViewTextBoxColumn.Name = "velocidadeDataGridViewTextBoxColumn";
            this.velocidadeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descricaoDataGridViewTextBoxColumn
            // 
            this.descricaoDataGridViewTextBoxColumn.DataPropertyName = "descricao";
            this.descricaoDataGridViewTextBoxColumn.HeaderText = "descricao";
            this.descricaoDataGridViewTextBoxColumn.Name = "descricaoDataGridViewTextBoxColumn";
            this.descricaoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pokemonsBindingSource1
            // 
            this.pokemonsBindingSource1.DataMember = "pokemons";
            this.pokemonsBindingSource1.DataSource = this.pokemonsDataSet;
            // 
            // pokemonsDataSet
            // 
            this.pokemonsDataSet.DataSetName = "pokemonsDataSet";
            this.pokemonsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pokemonsBindingSource
            // 
            this.pokemonsBindingSource.DataMember = "pokemons";
            this.pokemonsBindingSource.DataSource = this.pokemonsDataSet;
            // 
            // pokemonsTableAdapter
            // 
            this.pokemonsTableAdapter.ClearBeforeFill = true;
            // 
            // btn_Salvar
            // 
            this.btn_Salvar.Location = new System.Drawing.Point(13, 239);
            this.btn_Salvar.Name = "btn_Salvar";
            this.btn_Salvar.Size = new System.Drawing.Size(113, 23);
            this.btn_Salvar.TabIndex = 1;
            this.btn_Salvar.Text = "Salvar";
            this.btn_Salvar.UseVisualStyleBackColor = true;
            this.btn_Salvar.Click += new System.EventHandler(this.btn_AtualizarLista_Click);
            // 
            // pokemonsBindingSource3
            // 
            this.pokemonsBindingSource3.DataMember = "pokemons";
            this.pokemonsBindingSource3.DataSource = this.pokemonsDataSet;
            // 
            // pokemonsBindingSource2
            // 
            this.pokemonsBindingSource2.DataMember = "pokemons";
            this.pokemonsBindingSource2.DataSource = this.pokemonsDataSet;
            // 
            // fillToolStrip
            // 
            this.fillToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillToolStripButton});
            this.fillToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillToolStrip.Name = "fillToolStrip";
            this.fillToolStrip.Size = new System.Drawing.Size(1406, 25);
            this.fillToolStrip.TabIndex = 4;
            this.fillToolStrip.Text = "fillToolStrip";
            // 
            // fillToolStripButton
            // 
            this.fillToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillToolStripButton.Name = "fillToolStripButton";
            this.fillToolStripButton.Size = new System.Drawing.Size(26, 22);
            this.fillToolStripButton.Text = "Fill";
            this.fillToolStripButton.Click += new System.EventHandler(this.fillToolStripButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nome";
            // 
            // txt_Nome
            // 
            this.txt_Nome.Location = new System.Drawing.Point(132, 12);
            this.txt_Nome.Name = "txt_Nome";
            this.txt_Nome.Size = new System.Drawing.Size(192, 20);
            this.txt_Nome.TabIndex = 6;
            // 
            // txt_Altura
            // 
            this.txt_Altura.Location = new System.Drawing.Point(395, 195);
            this.txt_Altura.Name = "txt_Altura";
            this.txt_Altura.Size = new System.Drawing.Size(73, 20);
            this.txt_Altura.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(355, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Altura";
            // 
            // txt_Peso
            // 
            this.txt_Peso.Location = new System.Drawing.Point(395, 12);
            this.txt_Peso.Name = "txt_Peso";
            this.txt_Peso.Size = new System.Drawing.Size(73, 20);
            this.txt_Peso.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(358, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Peso";
            // 
            // txt_HP
            // 
            this.txt_HP.Location = new System.Drawing.Point(395, 38);
            this.txt_HP.Name = "txt_HP";
            this.txt_HP.Size = new System.Drawing.Size(73, 20);
            this.txt_HP.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(367, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "HP";
            // 
            // txt_Ataque
            // 
            this.txt_Ataque.Location = new System.Drawing.Point(395, 64);
            this.txt_Ataque.Name = "txt_Ataque";
            this.txt_Ataque.Size = new System.Drawing.Size(73, 20);
            this.txt_Ataque.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(348, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Ataque";
            // 
            // txt_Defesa
            // 
            this.txt_Defesa.Location = new System.Drawing.Point(395, 90);
            this.txt_Defesa.Name = "txt_Defesa";
            this.txt_Defesa.Size = new System.Drawing.Size(73, 20);
            this.txt_Defesa.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(348, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Defesa";
            // 
            // txt_EspecialAtaque
            // 
            this.txt_EspecialAtaque.Location = new System.Drawing.Point(395, 116);
            this.txt_EspecialAtaque.Name = "txt_EspecialAtaque";
            this.txt_EspecialAtaque.Size = new System.Drawing.Size(73, 20);
            this.txt_EspecialAtaque.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(305, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Ataque Especial";
            // 
            // txt_EspecialDefesa
            // 
            this.txt_EspecialDefesa.Location = new System.Drawing.Point(395, 143);
            this.txt_EspecialDefesa.Name = "txt_EspecialDefesa";
            this.txt_EspecialDefesa.Size = new System.Drawing.Size(73, 20);
            this.txt_EspecialDefesa.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(305, 150);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Defesa Especial";
            // 
            // txt_Velocidade
            // 
            this.txt_Velocidade.Location = new System.Drawing.Point(395, 169);
            this.txt_Velocidade.Name = "txt_Velocidade";
            this.txt_Velocidade.Size = new System.Drawing.Size(73, 20);
            this.txt_Velocidade.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(329, 176);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Velocidade";
            // 
            // txt_Descricao
            // 
            this.txt_Descricao.Location = new System.Drawing.Point(94, 93);
            this.txt_Descricao.Multiline = true;
            this.txt_Descricao.Name = "txt_Descricao";
            this.txt_Descricao.Size = new System.Drawing.Size(192, 118);
            this.txt_Descricao.TabIndex = 25;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(91, 77);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "Descrição";
            // 
            // cb_Categoria
            // 
            this.cb_Categoria.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.pokemonsBindingSource5, "categoria", true));
            this.cb_Categoria.DataSource = this.pokemonsBindingSource4;
            this.cb_Categoria.DisplayMember = "categoria";
            this.cb_Categoria.FormattingEnabled = true;
            this.cb_Categoria.Location = new System.Drawing.Point(203, 38);
            this.cb_Categoria.Name = "cb_Categoria";
            this.cb_Categoria.Size = new System.Drawing.Size(121, 21);
            this.cb_Categoria.TabIndex = 26;
            this.cb_Categoria.ValueMember = "categoria";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(145, 41);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 13);
            this.label11.TabIndex = 27;
            this.label11.Text = "Categoria";
            // 
            // pokemonsDataSetBindingSource
            // 
            this.pokemonsDataSetBindingSource.DataSource = this.pokemonsDataSet;
            this.pokemonsDataSetBindingSource.Position = 0;
            // 
            // pokemonsBindingSource4
            // 
            this.pokemonsBindingSource4.DataMember = "pokemons";
            this.pokemonsBindingSource4.DataSource = this.pokemonsDataSetBindingSource;
            // 
            // pokemonsBindingSource5
            // 
            this.pokemonsBindingSource5.DataMember = "pokemons";
            this.pokemonsBindingSource5.DataSource = this.pokemonsDataSet;
            // 
            // btn_Ordenar
            // 
            this.btn_Ordenar.Location = new System.Drawing.Point(572, 239);
            this.btn_Ordenar.Name = "btn_Ordenar";
            this.btn_Ordenar.Size = new System.Drawing.Size(75, 23);
            this.btn_Ordenar.TabIndex = 28;
            this.btn_Ordenar.Text = "Ordenar A/Z";
            this.btn_Ordenar.UseVisualStyleBackColor = true;
            this.btn_Ordenar.Click += new System.EventHandler(this.btn_Ordenar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1406, 573);
            this.Controls.Add(this.btn_Ordenar);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cb_Categoria);
            this.Controls.Add(this.txt_Descricao);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt_Velocidade);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_EspecialDefesa);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_EspecialAtaque);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_Defesa);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_Ataque);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_HP);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_Peso);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Altura);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Nome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fillToolStrip);
            this.Controls.Add(this.btn_Salvar);
            this.Controls.Add(this.dgv_Pokemons);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Pokemons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokemonsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokemonsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokemonsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokemonsBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokemonsBindingSource2)).EndInit();
            this.fillToolStrip.ResumeLayout(false);
            this.fillToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pokemonsDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokemonsBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokemonsBindingSource5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Pokemons;
        private pokemonsDataSet pokemonsDataSet;
        private System.Windows.Forms.BindingSource pokemonsBindingSource;
        private pokemonsDataSetTableAdapters.pokemonsTableAdapter pokemonsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alturaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pesoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hpDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ataqueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn defesaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn especialataqueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn especialdefesaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn velocidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource pokemonsBindingSource1;
        private System.Windows.Forms.Button btn_Salvar;
        private System.Windows.Forms.BindingSource pokemonsBindingSource3;
        private System.Windows.Forms.BindingSource pokemonsBindingSource2;
        private System.Windows.Forms.ToolStrip fillToolStrip;
        private System.Windows.Forms.ToolStripButton fillToolStripButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Nome;
        private System.Windows.Forms.TextBox txt_Altura;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Peso;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_HP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Ataque;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Defesa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_EspecialAtaque;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_EspecialDefesa;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_Velocidade;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_Descricao;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cb_Categoria;
        private System.Windows.Forms.BindingSource pokemonsBindingSource5;
        private System.Windows.Forms.BindingSource pokemonsBindingSource4;
        private System.Windows.Forms.BindingSource pokemonsDataSetBindingSource;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btn_Ordenar;
    }
}

