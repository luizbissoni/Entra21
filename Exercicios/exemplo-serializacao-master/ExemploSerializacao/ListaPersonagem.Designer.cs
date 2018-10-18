namespace ExemploSerializacao
{
    partial class ListaPersonagem
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
            this.cb_Clas = new System.Windows.Forms.ComboBox();
            this.btn_Salvar = new System.Windows.Forms.Button();
            this.txt_Nome = new System.Windows.Forms.TextBox();
            this.txt_Chakra = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NomeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClanColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChakraColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Editar = new System.Windows.Forms.Button();
            this.btn_Excluir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Clans";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nivel Chakra";
            // 
            // cb_Clas
            // 
            this.cb_Clas.FormattingEnabled = true;
            this.cb_Clas.Items.AddRange(new object[] {
            "Otsutsuki",
            "Senju",
            "Hyuuga",
            "Uchiha",
            "Uzumaki",
            "Kazekage",
            "Sarutobi",
            "Hatake",
            "Nara",
            "Aburame"});
            this.cb_Clas.Location = new System.Drawing.Point(87, 59);
            this.cb_Clas.Name = "cb_Clas";
            this.cb_Clas.Size = new System.Drawing.Size(144, 21);
            this.cb_Clas.TabIndex = 3;
            // 
            // btn_Salvar
            // 
            this.btn_Salvar.Location = new System.Drawing.Point(15, 148);
            this.btn_Salvar.Name = "btn_Salvar";
            this.btn_Salvar.Size = new System.Drawing.Size(102, 40);
            this.btn_Salvar.TabIndex = 4;
            this.btn_Salvar.Text = "Salvar";
            this.btn_Salvar.UseVisualStyleBackColor = true;
            this.btn_Salvar.Click += new System.EventHandler(this.btn_Salvar_Click);
            // 
            // txt_Nome
            // 
            this.txt_Nome.Location = new System.Drawing.Point(87, 6);
            this.txt_Nome.Name = "txt_Nome";
            this.txt_Nome.Size = new System.Drawing.Size(144, 20);
            this.txt_Nome.TabIndex = 5;
            // 
            // txt_Chakra
            // 
            this.txt_Chakra.Location = new System.Drawing.Point(87, 113);
            this.txt_Chakra.Name = "txt_Chakra";
            this.txt_Chakra.Size = new System.Drawing.Size(144, 20);
            this.txt_Chakra.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NomeColumn,
            this.ClanColumn,
            this.ChakraColumn});
            this.dataGridView1.Location = new System.Drawing.Point(293, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(347, 150);
            this.dataGridView1.TabIndex = 7;
            // 
            // NomeColumn
            // 
            this.NomeColumn.HeaderText = "Nome";
            this.NomeColumn.Name = "NomeColumn";
            this.NomeColumn.ReadOnly = true;
            // 
            // ClanColumn
            // 
            this.ClanColumn.HeaderText = "Clan";
            this.ClanColumn.Name = "ClanColumn";
            this.ClanColumn.ReadOnly = true;
            // 
            // ChakraColumn
            // 
            this.ChakraColumn.HeaderText = "Chakra";
            this.ChakraColumn.Name = "ChakraColumn";
            this.ChakraColumn.ReadOnly = true;
            // 
            // btn_Editar
            // 
            this.btn_Editar.Location = new System.Drawing.Point(293, 162);
            this.btn_Editar.Name = "btn_Editar";
            this.btn_Editar.Size = new System.Drawing.Size(97, 37);
            this.btn_Editar.TabIndex = 8;
            this.btn_Editar.Text = "Editar";
            this.btn_Editar.UseVisualStyleBackColor = true;
            // 
            // btn_Excluir
            // 
            this.btn_Excluir.Location = new System.Drawing.Point(565, 162);
            this.btn_Excluir.Name = "btn_Excluir";
            this.btn_Excluir.Size = new System.Drawing.Size(75, 23);
            this.btn_Excluir.TabIndex = 9;
            this.btn_Excluir.Text = "Excluir";
            this.btn_Excluir.UseVisualStyleBackColor = true;
            // 
            // ListaPersonagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 227);
            this.Controls.Add(this.btn_Excluir);
            this.Controls.Add(this.btn_Editar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_Chakra);
            this.Controls.Add(this.txt_Nome);
            this.Controls.Add(this.btn_Salvar);
            this.Controls.Add(this.cb_Clas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.KeyPreview = true;
            this.Name = "ListaPersonagem";
            this.Text = "Form1";
            this.Activated += new System.EventHandler(this.ListaPersonagem_Activated);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ListaPersonagem_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_Clas;
        private System.Windows.Forms.Button btn_Salvar;
        private System.Windows.Forms.TextBox txt_Nome;
        private System.Windows.Forms.TextBox txt_Chakra;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClanColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChakraColumn;
        private System.Windows.Forms.Button btn_Editar;
        private System.Windows.Forms.Button btn_Excluir;
    }
}

