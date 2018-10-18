namespace MarketDesktop
{
    partial class FormPrincipal
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
            this.tab1_Cadastro = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tab_CadastroSetor = new System.Windows.Forms.TabControl();
            this.tab_Feira = new System.Windows.Forms.TabPage();
            this.dgv_CadastroFeira = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tab_Frios = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tab_Limpeza = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tab_Padaria = new System.Windows.Forms.TabPage();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_AdicionarCadastro = new System.Windows.Forms.Button();
            this.txtb_valorUnitario = new System.Windows.Forms.TextBox();
            this.txtb_Quantidade = new System.Windows.Forms.TextBox();
            this.txtb_Produto = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tab1_Cadastro.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tab_CadastroSetor.SuspendLayout();
            this.tab_Feira.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CadastroFeira)).BeginInit();
            this.tab_Frios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tab_Limpeza.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tab_Padaria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // tab1_Cadastro
            // 
            this.tab1_Cadastro.Controls.Add(this.tabPage1);
            this.tab1_Cadastro.Controls.Add(this.tabPage2);
            this.tab1_Cadastro.Location = new System.Drawing.Point(4, 13);
            this.tab1_Cadastro.Name = "tab1_Cadastro";
            this.tab1_Cadastro.SelectedIndex = 0;
            this.tab1_Cadastro.Size = new System.Drawing.Size(508, 465);
            this.tab1_Cadastro.TabIndex = 0;
            this.tab1_Cadastro.Tag = "";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.tab_CadastroSetor);
            this.tabPage1.Controls.Add(this.btn_Delete);
            this.tabPage1.Controls.Add(this.btn_AdicionarCadastro);
            this.tabPage1.Controls.Add(this.txtb_valorUnitario);
            this.tabPage1.Controls.Add(this.txtb_Quantidade);
            this.tabPage1.Controls.Add(this.txtb_Produto);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(500, 439);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cadastro Produtos";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tab_CadastroSetor
            // 
            this.tab_CadastroSetor.Controls.Add(this.tab_Feira);
            this.tab_CadastroSetor.Controls.Add(this.tab_Frios);
            this.tab_CadastroSetor.Controls.Add(this.tab_Limpeza);
            this.tab_CadastroSetor.Controls.Add(this.tab_Padaria);
            this.tab_CadastroSetor.Location = new System.Drawing.Point(0, 67);
            this.tab_CadastroSetor.Name = "tab_CadastroSetor";
            this.tab_CadastroSetor.SelectedIndex = 0;
            this.tab_CadastroSetor.Size = new System.Drawing.Size(504, 366);
            this.tab_CadastroSetor.TabIndex = 6;
            // 
            // tab_Feira
            // 
            this.tab_Feira.Controls.Add(this.dgv_CadastroFeira);
            this.tab_Feira.Location = new System.Drawing.Point(4, 22);
            this.tab_Feira.Name = "tab_Feira";
            this.tab_Feira.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Feira.Size = new System.Drawing.Size(496, 340);
            this.tab_Feira.TabIndex = 0;
            this.tab_Feira.Text = "Feira";
            this.tab_Feira.UseVisualStyleBackColor = true;
            // 
            // dgv_CadastroFeira
            // 
            this.dgv_CadastroFeira.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_CadastroFeira.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgv_CadastroFeira.Location = new System.Drawing.Point(6, 6);
            this.dgv_CadastroFeira.Name = "dgv_CadastroFeira";
            this.dgv_CadastroFeira.Size = new System.Drawing.Size(445, 283);
            this.dgv_CadastroFeira.TabIndex = 4;
            this.dgv_CadastroFeira.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgv_CadastroProdutos_RowPostPaint);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Produto";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Quantidade";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Valor unitário";
            this.Column4.Name = "Column4";
            // 
            // tab_Frios
            // 
            this.tab_Frios.Controls.Add(this.dataGridView1);
            this.tab_Frios.Location = new System.Drawing.Point(4, 22);
            this.tab_Frios.Name = "tab_Frios";
            this.tab_Frios.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Frios.Size = new System.Drawing.Size(496, 380);
            this.tab_Frios.TabIndex = 1;
            this.tab_Frios.Text = "Frios";
            this.tab_Frios.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(4, 7);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // tab_Limpeza
            // 
            this.tab_Limpeza.Controls.Add(this.dataGridView2);
            this.tab_Limpeza.Location = new System.Drawing.Point(4, 22);
            this.tab_Limpeza.Name = "tab_Limpeza";
            this.tab_Limpeza.Size = new System.Drawing.Size(496, 380);
            this.tab_Limpeza.TabIndex = 2;
            this.tab_Limpeza.Text = "Limpeza";
            this.tab_Limpeza.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(7, 4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(240, 150);
            this.dataGridView2.TabIndex = 0;
            // 
            // tab_Padaria
            // 
            this.tab_Padaria.Controls.Add(this.dataGridView3);
            this.tab_Padaria.Location = new System.Drawing.Point(4, 22);
            this.tab_Padaria.Name = "tab_Padaria";
            this.tab_Padaria.Size = new System.Drawing.Size(496, 380);
            this.tab_Padaria.TabIndex = 3;
            this.tab_Padaria.Text = "Padaraia";
            this.tab_Padaria.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(7, 4);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(240, 150);
            this.dataGridView3.TabIndex = 0;
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(419, 23);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(75, 23);
            this.btn_Delete.TabIndex = 5;
            this.btn_Delete.Text = "Excluir";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_AdicionarCadastro
            // 
            this.btn_AdicionarCadastro.Location = new System.Drawing.Point(256, 23);
            this.btn_AdicionarCadastro.Name = "btn_AdicionarCadastro";
            this.btn_AdicionarCadastro.Size = new System.Drawing.Size(75, 23);
            this.btn_AdicionarCadastro.TabIndex = 3;
            this.btn_AdicionarCadastro.Text = "Adicionar";
            this.btn_AdicionarCadastro.UseVisualStyleBackColor = true;
            this.btn_AdicionarCadastro.Click += new System.EventHandler(this.btn_AdicionarCadastro_Click);
            // 
            // txtb_valorUnitario
            // 
            this.txtb_valorUnitario.Location = new System.Drawing.Point(183, 26);
            this.txtb_valorUnitario.Name = "txtb_valorUnitario";
            this.txtb_valorUnitario.Size = new System.Drawing.Size(67, 20);
            this.txtb_valorUnitario.TabIndex = 2;
            // 
            // txtb_Quantidade
            // 
            this.txtb_Quantidade.Location = new System.Drawing.Point(114, 26);
            this.txtb_Quantidade.Name = "txtb_Quantidade";
            this.txtb_Quantidade.Size = new System.Drawing.Size(63, 20);
            this.txtb_Quantidade.TabIndex = 1;
            // 
            // txtb_Produto
            // 
            this.txtb_Produto.Location = new System.Drawing.Point(6, 26);
            this.txtb_Produto.Name = "txtb_Produto";
            this.txtb_Produto.Size = new System.Drawing.Size(100, 20);
            this.txtb_Produto.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(500, 439);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Produto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(124, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Quantidade";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(200, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Valor";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 490);
            this.Controls.Add(this.tab1_Cadastro);
            this.Name = "FormPrincipal";
            this.Text = "Form1";
            this.tab1_Cadastro.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tab_CadastroSetor.ResumeLayout(false);
            this.tab_Feira.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CadastroFeira)).EndInit();
            this.tab_Frios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tab_Limpeza.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tab_Padaria.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab1_Cadastro;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btn_AdicionarCadastro;
        private System.Windows.Forms.TextBox txtb_valorUnitario;
        private System.Windows.Forms.TextBox txtb_Quantidade;
        private System.Windows.Forms.TextBox txtb_Produto;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgv_CadastroFeira;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.TabControl tab_CadastroSetor;
        private System.Windows.Forms.TabPage tab_Feira;
        private System.Windows.Forms.TabPage tab_Frios;
        private System.Windows.Forms.TabPage tab_Limpeza;
        private System.Windows.Forms.TabPage tab_Padaria;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

