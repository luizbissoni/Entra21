namespace WFA
{
    partial class ListaAlunosAdd
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
            this.dgv_ListaAlunos = new System.Windows.Forms.DataGridView();
            this.CodigoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TurmaColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TurnoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Salvar = new System.Windows.Forms.Button();
            this.btn_Editar = new System.Windows.Forms.Button();
            this.btn_Novo = new System.Windows.Forms.Button();
            this.bnt_Apagar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListaAlunos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_ListaAlunos
            // 
            this.dgv_ListaAlunos.AllowUserToAddRows = false;
            this.dgv_ListaAlunos.AllowUserToDeleteRows = false;
            this.dgv_ListaAlunos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ListaAlunos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodigoColumn,
            this.NomeColumn,
            this.TurmaColumn,
            this.TurnoColumn});
            this.dgv_ListaAlunos.Location = new System.Drawing.Point(12, 216);
            this.dgv_ListaAlunos.Name = "dgv_ListaAlunos";
            this.dgv_ListaAlunos.ReadOnly = true;
            this.dgv_ListaAlunos.Size = new System.Drawing.Size(370, 254);
            this.dgv_ListaAlunos.TabIndex = 0;
            // 
            // CodigoColumn
            // 
            this.CodigoColumn.HeaderText = "Codigo";
            this.CodigoColumn.Name = "CodigoColumn";
            this.CodigoColumn.ReadOnly = true;
            // 
            // NomeColumn
            // 
            this.NomeColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NomeColumn.HeaderText = "Nome";
            this.NomeColumn.Name = "NomeColumn";
            this.NomeColumn.ReadOnly = true;
            // 
            // TurmaColumn
            // 
            this.TurmaColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TurmaColumn.HeaderText = "Turma";
            this.TurmaColumn.Name = "TurmaColumn";
            this.TurmaColumn.ReadOnly = true;
            // 
            // TurnoColumn
            // 
            this.TurnoColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TurnoColumn.HeaderText = "Turno";
            this.TurnoColumn.Name = "TurnoColumn";
            this.TurnoColumn.ReadOnly = true;
            // 
            // btn_Salvar
            // 
            this.btn_Salvar.Location = new System.Drawing.Point(307, 187);
            this.btn_Salvar.Name = "btn_Salvar";
            this.btn_Salvar.Size = new System.Drawing.Size(75, 23);
            this.btn_Salvar.TabIndex = 1;
            this.btn_Salvar.Text = "Salvar";
            this.btn_Salvar.UseVisualStyleBackColor = true;
            // 
            // btn_Editar
            // 
            this.btn_Editar.Location = new System.Drawing.Point(226, 187);
            this.btn_Editar.Name = "btn_Editar";
            this.btn_Editar.Size = new System.Drawing.Size(75, 23);
            this.btn_Editar.TabIndex = 2;
            this.btn_Editar.Text = "Editar";
            this.btn_Editar.UseVisualStyleBackColor = true;
            this.btn_Editar.Click += new System.EventHandler(this.btn_Editar_Click);
            // 
            // btn_Novo
            // 
            this.btn_Novo.Location = new System.Drawing.Point(145, 187);
            this.btn_Novo.Name = "btn_Novo";
            this.btn_Novo.Size = new System.Drawing.Size(75, 23);
            this.btn_Novo.TabIndex = 3;
            this.btn_Novo.Text = "Novo";
            this.btn_Novo.UseVisualStyleBackColor = true;
            this.btn_Novo.Click += new System.EventHandler(this.button3_Click);
            // 
            // bnt_Apagar
            // 
            this.bnt_Apagar.Location = new System.Drawing.Point(12, 187);
            this.bnt_Apagar.Name = "bnt_Apagar";
            this.bnt_Apagar.Size = new System.Drawing.Size(75, 23);
            this.bnt_Apagar.TabIndex = 4;
            this.bnt_Apagar.Text = "Apagar";
            this.bnt_Apagar.UseVisualStyleBackColor = true;
            this.bnt_Apagar.Click += new System.EventHandler(this.bnt_Apagar_Click);
            // 
            // ListaAlunosAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 482);
            this.Controls.Add(this.bnt_Apagar);
            this.Controls.Add(this.btn_Novo);
            this.Controls.Add(this.btn_Editar);
            this.Controls.Add(this.btn_Salvar);
            this.Controls.Add(this.dgv_ListaAlunos);
            this.Name = "ListaAlunosAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListaAlunosAdd";
            this.Activated += new System.EventHandler(this.ListaAlunosAdd_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListaAlunos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_ListaAlunos;
        private System.Windows.Forms.Button btn_Salvar;
        private System.Windows.Forms.Button btn_Editar;
        private System.Windows.Forms.Button btn_Novo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TurmaColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TurnoColumn;
        private System.Windows.Forms.Button bnt_Apagar;
    }
}