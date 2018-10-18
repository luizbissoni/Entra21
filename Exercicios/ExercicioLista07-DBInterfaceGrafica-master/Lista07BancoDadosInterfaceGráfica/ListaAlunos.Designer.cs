namespace Lista07BancoDadosInterfaceGráfica
{
    partial class ListaAlunos
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
            this.btn_Cadastrar = new System.Windows.Forms.Button();
            this.btn_Excluir = new System.Windows.Forms.Button();
            this.dgv_ListaAlunos = new System.Windows.Forms.DataGridView();
            this.txt_Busca = new System.Windows.Forms.TextBox();
            this.rb_Nome = new System.Windows.Forms.RadioButton();
            this.rb_Frequencia = new System.Windows.Forms.RadioButton();
            this.rb_ASC = new System.Windows.Forms.RadioButton();
            this.rb_DESC = new System.Windows.Forms.RadioButton();
            this.btn_Atualizar = new System.Windows.Forms.Button();
            this.ColumnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNota1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNota2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNota3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFrequencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSituacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListaAlunos)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Cadastrar
            // 
            this.btn_Cadastrar.Location = new System.Drawing.Point(212, 12);
            this.btn_Cadastrar.Name = "btn_Cadastrar";
            this.btn_Cadastrar.Size = new System.Drawing.Size(75, 23);
            this.btn_Cadastrar.TabIndex = 0;
            this.btn_Cadastrar.Text = "Cadastrar";
            this.btn_Cadastrar.UseVisualStyleBackColor = true;
            this.btn_Cadastrar.Click += new System.EventHandler(this.btn_Cadastrar_Click);
            // 
            // btn_Excluir
            // 
            this.btn_Excluir.Location = new System.Drawing.Point(212, 41);
            this.btn_Excluir.Name = "btn_Excluir";
            this.btn_Excluir.Size = new System.Drawing.Size(75, 23);
            this.btn_Excluir.TabIndex = 1;
            this.btn_Excluir.Text = "Excluir";
            this.btn_Excluir.UseVisualStyleBackColor = true;
            this.btn_Excluir.Click += new System.EventHandler(this.btn_Excluir_Click);
            // 
            // dgv_ListaAlunos
            // 
            this.dgv_ListaAlunos.AllowUserToAddRows = false;
            this.dgv_ListaAlunos.AllowUserToDeleteRows = false;
            this.dgv_ListaAlunos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ListaAlunos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnID,
            this.ColumnNome,
            this.ColumnNota1,
            this.ColumnNota2,
            this.ColumnNota3,
            this.ColumnFrequencia,
            this.ColumnSituacao});
            this.dgv_ListaAlunos.Location = new System.Drawing.Point(12, 168);
            this.dgv_ListaAlunos.Name = "dgv_ListaAlunos";
            this.dgv_ListaAlunos.ReadOnly = true;
            this.dgv_ListaAlunos.Size = new System.Drawing.Size(646, 139);
            this.dgv_ListaAlunos.TabIndex = 2;
            this.dgv_ListaAlunos.DoubleClick += new System.EventHandler(this.dgv_ListaAlunos_DoubleClick);
            // 
            // txt_Busca
            // 
            this.txt_Busca.Location = new System.Drawing.Point(12, 12);
            this.txt_Busca.Name = "txt_Busca";
            this.txt_Busca.Size = new System.Drawing.Size(187, 20);
            this.txt_Busca.TabIndex = 3;
            // 
            // rb_Nome
            // 
            this.rb_Nome.AutoSize = true;
            this.rb_Nome.Location = new System.Drawing.Point(23, 132);
            this.rb_Nome.Name = "rb_Nome";
            this.rb_Nome.Size = new System.Drawing.Size(53, 17);
            this.rb_Nome.TabIndex = 4;
            this.rb_Nome.TabStop = true;
            this.rb_Nome.Text = "Nome";
            this.rb_Nome.UseVisualStyleBackColor = true;
            // 
            // rb_Frequencia
            // 
            this.rb_Frequencia.AutoSize = true;
            this.rb_Frequencia.Location = new System.Drawing.Point(114, 132);
            this.rb_Frequencia.Name = "rb_Frequencia";
            this.rb_Frequencia.Size = new System.Drawing.Size(78, 17);
            this.rb_Frequencia.TabIndex = 5;
            this.rb_Frequencia.TabStop = true;
            this.rb_Frequencia.Text = "Frequencia";
            this.rb_Frequencia.UseVisualStyleBackColor = true;
            // 
            // rb_ASC
            // 
            this.rb_ASC.AutoSize = true;
            this.rb_ASC.Location = new System.Drawing.Point(287, 132);
            this.rb_ASC.Name = "rb_ASC";
            this.rb_ASC.Size = new System.Drawing.Size(46, 17);
            this.rb_ASC.TabIndex = 6;
            this.rb_ASC.TabStop = true;
            this.rb_ASC.Text = "ASC";
            this.rb_ASC.UseVisualStyleBackColor = true;
            // 
            // rb_DESC
            // 
            this.rb_DESC.AutoSize = true;
            this.rb_DESC.Location = new System.Drawing.Point(378, 132);
            this.rb_DESC.Name = "rb_DESC";
            this.rb_DESC.Size = new System.Drawing.Size(54, 17);
            this.rb_DESC.TabIndex = 7;
            this.rb_DESC.TabStop = true;
            this.rb_DESC.Text = "DESC";
            this.rb_DESC.UseVisualStyleBackColor = true;
            // 
            // btn_Atualizar
            // 
            this.btn_Atualizar.Location = new System.Drawing.Point(485, 129);
            this.btn_Atualizar.Name = "btn_Atualizar";
            this.btn_Atualizar.Size = new System.Drawing.Size(75, 23);
            this.btn_Atualizar.TabIndex = 8;
            this.btn_Atualizar.Text = "Atualizar";
            this.btn_Atualizar.UseVisualStyleBackColor = true;
            this.btn_Atualizar.Click += new System.EventHandler(this.btn_Atualizar_Click);
            // 
            // ColumnID
            // 
            this.ColumnID.HeaderText = "Id";
            this.ColumnID.Name = "ColumnID";
            this.ColumnID.ReadOnly = true;
            this.ColumnID.Visible = false;
            // 
            // ColumnNome
            // 
            this.ColumnNome.HeaderText = "Nome";
            this.ColumnNome.Name = "ColumnNome";
            this.ColumnNome.ReadOnly = true;
            // 
            // ColumnNota1
            // 
            this.ColumnNota1.HeaderText = "Nota_1";
            this.ColumnNota1.Name = "ColumnNota1";
            this.ColumnNota1.ReadOnly = true;
            // 
            // ColumnNota2
            // 
            this.ColumnNota2.HeaderText = "Nota_2";
            this.ColumnNota2.Name = "ColumnNota2";
            this.ColumnNota2.ReadOnly = true;
            // 
            // ColumnNota3
            // 
            this.ColumnNota3.HeaderText = "Nota_4";
            this.ColumnNota3.Name = "ColumnNota3";
            this.ColumnNota3.ReadOnly = true;
            // 
            // ColumnFrequencia
            // 
            this.ColumnFrequencia.HeaderText = "Frequencia";
            this.ColumnFrequencia.Name = "ColumnFrequencia";
            this.ColumnFrequencia.ReadOnly = true;
            // 
            // ColumnSituacao
            // 
            this.ColumnSituacao.HeaderText = "Situação ";
            this.ColumnSituacao.Name = "ColumnSituacao";
            this.ColumnSituacao.ReadOnly = true;
            // 
            // ListaAlunos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 319);
            this.Controls.Add(this.btn_Atualizar);
            this.Controls.Add(this.rb_DESC);
            this.Controls.Add(this.rb_ASC);
            this.Controls.Add(this.rb_Frequencia);
            this.Controls.Add(this.rb_Nome);
            this.Controls.Add(this.txt_Busca);
            this.Controls.Add(this.dgv_ListaAlunos);
            this.Controls.Add(this.btn_Excluir);
            this.Controls.Add(this.btn_Cadastrar);
            this.Name = "ListaAlunos";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.ListaAlunos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListaAlunos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Cadastrar;
        private System.Windows.Forms.Button btn_Excluir;
        private System.Windows.Forms.DataGridView dgv_ListaAlunos;
        private System.Windows.Forms.TextBox txt_Busca;
        private System.Windows.Forms.RadioButton rb_Nome;
        private System.Windows.Forms.RadioButton rb_Frequencia;
        private System.Windows.Forms.RadioButton rb_ASC;
        private System.Windows.Forms.RadioButton rb_DESC;
        private System.Windows.Forms.Button btn_Atualizar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNota1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNota2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNota3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFrequencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSituacao;
    }
}

