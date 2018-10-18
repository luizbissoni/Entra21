namespace WFA
{
    partial class CadastroAluno
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
            this.txt_Nome = new System.Windows.Forms.TextBox();
            this.txt_Matricula = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Turno = new System.Windows.Forms.TextBox();
            this.txt_Turma = new System.Windows.Forms.TextBox();
            this.txt_Idade = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_Salvar = new System.Windows.Forms.Button();
            this.dgv_CadastroAlunosNotas = new System.Windows.Forms.DataGridView();
            this.NotaColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_ApagarAluno = new System.Windows.Forms.Button();
            this.btn_EditarAluno = new System.Windows.Forms.Button();
            this.btn_AdicionarNota = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CadastroAlunosNotas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome Aluno";
            // 
            // txt_Nome
            // 
            this.txt_Nome.Location = new System.Drawing.Point(83, 13);
            this.txt_Nome.Name = "txt_Nome";
            this.txt_Nome.Size = new System.Drawing.Size(178, 20);
            this.txt_Nome.TabIndex = 1;
            // 
            // txt_Matricula
            // 
            this.txt_Matricula.Location = new System.Drawing.Point(83, 39);
            this.txt_Matricula.Name = "txt_Matricula";
            this.txt_Matricula.Size = new System.Drawing.Size(100, 20);
            this.txt_Matricula.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Matricula";
            // 
            // txt_Turno
            // 
            this.txt_Turno.Location = new System.Drawing.Point(83, 68);
            this.txt_Turno.Name = "txt_Turno";
            this.txt_Turno.Size = new System.Drawing.Size(100, 20);
            this.txt_Turno.TabIndex = 5;
            // 
            // txt_Turma
            // 
            this.txt_Turma.Location = new System.Drawing.Point(83, 94);
            this.txt_Turma.Name = "txt_Turma";
            this.txt_Turma.Size = new System.Drawing.Size(100, 20);
            this.txt_Turma.TabIndex = 6;
            // 
            // txt_Idade
            // 
            this.txt_Idade.Location = new System.Drawing.Point(83, 120);
            this.txt_Idade.Name = "txt_Idade";
            this.txt_Idade.Size = new System.Drawing.Size(45, 20);
            this.txt_Idade.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Turno";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Idade";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Turma";
            // 
            // btn_Salvar
            // 
            this.btn_Salvar.Location = new System.Drawing.Point(189, 65);
            this.btn_Salvar.Name = "btn_Salvar";
            this.btn_Salvar.Size = new System.Drawing.Size(75, 23);
            this.btn_Salvar.TabIndex = 2;
            this.btn_Salvar.Text = "Salvar";
            this.btn_Salvar.UseVisualStyleBackColor = true;
            this.btn_Salvar.Click += new System.EventHandler(this.btn_Salvar_Click);
            // 
            // dgv_CadastroAlunosNotas
            // 
            this.dgv_CadastroAlunosNotas.AllowUserToAddRows = false;
            this.dgv_CadastroAlunosNotas.AllowUserToDeleteRows = false;
            this.dgv_CadastroAlunosNotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_CadastroAlunosNotas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NotaColumn});
            this.dgv_CadastroAlunosNotas.Location = new System.Drawing.Point(15, 216);
            this.dgv_CadastroAlunosNotas.Name = "dgv_CadastroAlunosNotas";
            this.dgv_CadastroAlunosNotas.ReadOnly = true;
            this.dgv_CadastroAlunosNotas.Size = new System.Drawing.Size(370, 254);
            this.dgv_CadastroAlunosNotas.TabIndex = 11;
            // 
            // NotaColumn
            // 
            this.NotaColumn.HeaderText = "Nota";
            this.NotaColumn.Name = "NotaColumn";
            this.NotaColumn.ReadOnly = true;
            // 
            // btn_ApagarAluno
            // 
            this.btn_ApagarAluno.Enabled = false;
            this.btn_ApagarAluno.Location = new System.Drawing.Point(310, 175);
            this.btn_ApagarAluno.Name = "btn_ApagarAluno";
            this.btn_ApagarAluno.Size = new System.Drawing.Size(75, 23);
            this.btn_ApagarAluno.TabIndex = 12;
            this.btn_ApagarAluno.Text = "Apagar";
            this.btn_ApagarAluno.UseVisualStyleBackColor = true;
            // 
            // btn_EditarAluno
            // 
            this.btn_EditarAluno.Enabled = false;
            this.btn_EditarAluno.Location = new System.Drawing.Point(96, 175);
            this.btn_EditarAluno.Name = "btn_EditarAluno";
            this.btn_EditarAluno.Size = new System.Drawing.Size(75, 23);
            this.btn_EditarAluno.TabIndex = 13;
            this.btn_EditarAluno.Text = "Editar";
            this.btn_EditarAluno.UseVisualStyleBackColor = true;
            // 
            // btn_AdicionarNota
            // 
            this.btn_AdicionarNota.Enabled = false;
            this.btn_AdicionarNota.Location = new System.Drawing.Point(12, 175);
            this.btn_AdicionarNota.Name = "btn_AdicionarNota";
            this.btn_AdicionarNota.Size = new System.Drawing.Size(75, 23);
            this.btn_AdicionarNota.TabIndex = 14;
            this.btn_AdicionarNota.Text = "Adicionar";
            this.btn_AdicionarNota.UseVisualStyleBackColor = true;
            this.btn_AdicionarNota.Click += new System.EventHandler(this.btn_Adicionar_Click);
            // 
            // CadastroAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 482);
            this.Controls.Add(this.btn_AdicionarNota);
            this.Controls.Add(this.btn_EditarAluno);
            this.Controls.Add(this.btn_ApagarAluno);
            this.Controls.Add(this.dgv_CadastroAlunosNotas);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Idade);
            this.Controls.Add(this.txt_Turma);
            this.Controls.Add(this.txt_Turno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Matricula);
            this.Controls.Add(this.btn_Salvar);
            this.Controls.Add(this.txt_Nome);
            this.Controls.Add(this.label1);
            this.Name = "CadastroAluno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CadastroAlunosNotas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Nome;
        private System.Windows.Forms.TextBox txt_Matricula;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Turno;
        private System.Windows.Forms.TextBox txt_Turma;
        private System.Windows.Forms.TextBox txt_Idade;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_Salvar;
        private System.Windows.Forms.DataGridView dgv_CadastroAlunosNotas;
        private System.Windows.Forms.Button btn_ApagarAluno;
        private System.Windows.Forms.Button btn_EditarAluno;
        private System.Windows.Forms.Button btn_AdicionarNota;
        private System.Windows.Forms.DataGridViewTextBoxColumn NotaColumn;
    }
}

