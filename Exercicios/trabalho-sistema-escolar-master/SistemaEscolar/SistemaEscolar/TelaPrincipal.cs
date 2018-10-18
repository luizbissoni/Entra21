using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace SistemaEscolar
{
    public partial class TelaPrincipal : Form
    {
        Random numeroAleatorio = new Random();


        public TelaPrincipal()
        {
            InitializeComponent();
            
        }

        private void btn_FormCadastroUsuario_Click(object sender, EventArgs e)
        {
            new CadastroUsuarioSistema().ShowDialog();
        }

        private void tc_Principal_Selected(object sender, TabControlEventArgs e)
        {
            if (e.TabPageIndex == 0)
            {
                lblTitulo.Text = "Bem-Vindo, Usuário.";
                lblInformacoes.Text = "Por favor, seleciona uma opção.";
            }
            else if (e.TabPageIndex == 1)
            {
                lblTitulo.Text = "Menu dos Professores";
                lblInformacoes.Text = "Neste menu voce tem acesso a todos os dados de todos os professores que exercem atividades na escola.";
                AtualizarListaProfessores();
            }
            else if (e.TabPageIndex == 2)
            {
                lblTitulo.Text = "Menu dos Alunos";
                lblInformacoes.Text = "Neste menu você tem acesso a todos os dados de todos os alunos matriculados na escola.";
            }
            else if (e.TabPageIndex == 3)
            {
                lblTitulo.Text = "Menu dos Funcionários";
                lblInformacoes.Text = "Neste menu você tem acesso a todos os dados de todos os funcionario da escola.";
            }
            else if (e.TabPageIndex == 4)
            {
                lblTitulo.Text = "Menu de Produtos";
                lblInformacoes.Text = "Neste menu você tem o controle do estoque de produtos.";
            }
            else if (e.TabPageIndex == 5)
            {
                lblTitulo.Text = "Menu de Materiais";
                lblInformacoes.Text = "Neste menu você tem acesso as informações de quantos livros didáticos estão em estoque.";
            }
            else if (e.TabPageIndex == 6)
            {
                lblTitulo.Text = "Menu de Alimentos";
                lblInformacoes.Text = "Neste menu você controla a quantidade de comida em estoque e o que está faltando.";
            }
            else if (e.TabPageIndex == 7)
            {
                lblTitulo.Text = "Menu de Equipamentos";
                lblInformacoes.Text = "Neste menu você tem o controle do estoque de equipamentos, como: Projetores, computadores e quadros digitais.";
            }
            else if (e.TabPageIndex == 8)
            {
                lblTitulo.Text = "Menu Financeiro";
                lblInformacoes.Text = "Adiministre toda a parte financeira da escola, adicione saldos de entradas e saídas, para ter total controle.";
            }

        }

        // ------------------------- Inicio dos localizadores de CEP
        private void mtbCepProfessores_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            LocalizaCepProfessor();
        }

        private void mtbCepProfessores_Leave(object sender, EventArgs e)
        {
            LocalizaCepProfessor();
        }

        private void LocalizaCepProfessor()
        {
            try
            {
                if (Tools.ValidarCep(mtbCepProfessor.Text))
                {
                    CEP buscarCep = new CEP(mtbCepProfessor.Text);

                    txtBairroProfessor.Text = buscarCep.bairro;
                    txtCidadeProfessores.Text = buscarCep.localidade;
                    txtLogradouroProfessores.Text = buscarCep.logradouro;
                    txtUfProfessor.Text = buscarCep.uf;
                }
                else
                {
                    MessageBox.Show("CEP inválido!");
                    mtbCepProfessor.Focus();
                    return;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("CEP inválido!");
                return;
            }

        }

        private void LocalizaCepResponsavelAluno()
        {
            try
            {
                if (Tools.ValidarCep(mtbCepPai.Text))
                {
                    CEP buscarCep = new CEP(mtbCepPai.Text);

                    txtBairroPai.Text = buscarCep.bairro;
                    txtLogradouroPai.Text = buscarCep.logradouro;
                    txtUfPai.Text = buscarCep.uf;
                }
                else
                {
                    MessageBox.Show("CEP inválido!");
                    mtbCepPai.Focus();
                    return;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("CEP inválido!");
                return;
            }
        }

        private void LocalizaCepResponsavelAlunoMae()
        {
            try
            {
                if (Tools.ValidarCep(mtbCepMae.Text))
                {
                    CEP buscarCep = new CEP(mtbCepMae.Text);

                    txtBairroMae.Text = buscarCep.bairro;
                    txtLogradouroMae.Text = buscarCep.logradouro;
                    txtUfMae.Text = buscarCep.uf;
                }
                else
                {
                    MessageBox.Show("CEP inválido!");
                    mtbCepMae.Focus();
                    return;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("CEP inválido!");
                return;
            }
        }

        private void LocalizaCepFuncionario()
        {
            try
            {
                if (Tools.ValidarCep(mtb_CepFuncionario.Text))
                {
                    CEP buscarCep = new CEP(mtb_CepFuncionario.Text);

                    txt_BairroFuncionario.Text = buscarCep.bairro;
                    txt_CidadeFuncionario.Text = buscarCep.localidade;
                    txt_LogradouroFuncionario.Text = buscarCep.logradouro;
                    txt_UfFuncionario.Text = buscarCep.uf;
                }
                else
                {
                    MessageBox.Show("CEP inválido!");
                    mtb_CepFuncionario.Focus();
                    return;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("CEP inválido!");
                return;
            }
        }

        private void LocalizarCepAlimento()
        {
            try
            {
                if (Tools.ValidarCep(mtb_CepAlimentos.Text))
                {
                    CEP buscarCep = new CEP(mtb_CepAlimentos.Text);

                    txt_BairroAlimento.Text = buscarCep.bairro;
                    txt_CidadeAlimento.Text = buscarCep.localidade;
                    txt_RuaAlimento.Text = buscarCep.logradouro;
                    txt_UfAlimento.Text = buscarCep.uf;
                }
                else
                {
                    MessageBox.Show("CEP inválido!");
                    mtb_CepAlimentos.Focus();
                    return;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("CEP inválido!");
                return;
            }
        }

        private void mtbCepPai_Leave(object sender, EventArgs e)
        {
            LocalizaCepResponsavelAluno();
        }

        private void mtbCepMae_Leave(object sender, EventArgs e)
        {
            LocalizaCepResponsavelAlunoMae();
        }

        private void mtb_CepFuncionario_Leave(object sender, EventArgs e)
        {
            LocalizaCepFuncionario();
        }

        private void mtb_CepAlimentos_Leave(object sender, EventArgs e)
        {
            LocalizarCepAlimento();
        }
        // ----------------------------- Fim do localizadores de CEP


        // ------------------------ Inicio Menu Produtos
        private int posicaoProdutos = -1;

        public void CadastroProduto(Produto produto, int posicaoProdutos)
        {
            InitializeComponent();

            this.posicaoProdutos = posicaoProdutos;

            txtNomeProduto.Text = produto.NomeProduto;
            cbSetorProduto.SelectedItem = produto.SetorProduto;
            nudQuantidadeProduto.Value = produto.QuantidadeProduto;
            dtpDataEntradaProduto.Value = produto.EntradaProduto;
            txtValorUnitarioProduto.Text = produto.ValorUnitarioProduto.ToString();
            txtNomeLivro.Text = produto.NomeLivro;
            cbDisciplinaLivro.SelectedItem = produto.DisciplinaLivro;
            cbCapaLivro.SelectedItem = produto.CapaLivro;
            txtNomeAutorLivro.Text = produto.NomeAutorLivro;
            dtpAnoLançamentoLivro.Value = produto.AnoLancamentoLivro;
            dtpAnoLançamentoLivro.Value = produto.AnoLancamentoLivro;
        }

        private void btnSalvarProduto_Click(object sender, EventArgs e)
        {
            if (txtNomeProduto.Text.Length < 4)
            {
                MessageBox.Show("Nome do Produto deve conter no mínimo 4 caracteres. Digite o nome completo.");
                txtNomeProduto.Focus();
                return;
            }

            if (cbSetorProduto.SelectedIndex < 0)
            {
                MessageBox.Show("Selecione o setor do produto.");
                cbSetorProduto.DroppedDown = true;
                return;
            }

            if (nudQuantidadeProduto.Value <= 0)
            {
                MessageBox.Show("Coloque uma quantidade de produtos maior que 0.");
                nudQuantidadeProduto.Focus();
                return;
            }

            if (dtpDataEntradaProduto.Value > DateTime.Now)
            {
                MessageBox.Show("Data da compra deve ser hoje ou uma data anterior.");
                dtpDataEntradaProduto.Focus();
                return;
            }

            if (txtValorUnitarioProduto.Text.Length == 0)
            {
                MessageBox.Show("Valor unitário deve ser ser preenchido");
                txtValorUnitarioProduto.Focus();
                return;
            }
            try
            {
                double valorUnitarioProduto = Convert.ToDouble(txtValorUnitarioProduto.Text);
            }
            catch
            {
                MessageBox.Show("Valor deve conter somente números reais!");
                txtValorUnitarioProduto.Focus();
                return;
            }

            if (txtNomeLivro.Text.Length < 4 && cbSetorProduto.Text == "Biblioteca")
            {
                MessageBox.Show("Nome do livro deve conter no mínimo 4 caracteres. Digite o nome completo.");
                txtNomeLivro.Focus();
                return;
            }

            if (cbDisciplinaLivro.SelectedIndex < 0 && cbSetorProduto.Text == "Biblioteca")
            {
                MessageBox.Show("Selecione a disciplina do livro.");
                cbDisciplinaLivro.DroppedDown = true;
                return;
            }

            if (cbCapaLivro.SelectedIndex < 0 && cbSetorProduto.Text == "Biblioteca")
            {
                MessageBox.Show("Selecione a capa do livro.");
                cbCapaLivro.Focus();
                return;
            }

            if (txtNomeAutorLivro.Text.Length < 5 && cbSetorProduto.Text == "Biblioteca")
            {
                MessageBox.Show("Nome do autor do livro deve conter no mínimo 5 caracteres. Digite o nome completo.");
                txtNomeAutorLivro.Focus();
                return;
            }

            if (dtpAnoLançamentoLivro.Value > DateTime.Now && cbSetorProduto.Text == "Biblioteca")
            {
                MessageBox.Show("Data da compra deve ser hoje ou uma data anterior.");
                dtpAnoLançamentoLivro.Focus();
                return;
            }


            Produto produto = new Produto()
            {

                NomeProduto = txtNomeProduto.Text,
                SetorProduto = cbSetorProduto.SelectedItem.ToString(),
                QuantidadeProduto = Convert.ToInt32(nudQuantidadeProduto.Value),
                EntradaProduto = dtpDataEntradaProduto.Value,
                ValorUnitarioProduto = Convert.ToDouble(txtValorUnitarioProduto.Text),

            };
            if (cbSetorProduto.Text == "Biblioteca")
            {
                Produto produtoLivro = new Produto()
                {
                    NomeLivro = txtNomeLivro.Text,
                    DisciplinaLivro = cbDisciplinaLivro.SelectedItem.ToString(),
                    CapaLivro = cbCapaLivro.SelectedItem.ToString(),
                    NomeAutorLivro = txtNomeAutorLivro.Text,
                    AnoLancamentoLivro = dtpAnoLançamentoLivro.Value
                };
            }

            if (posicaoProdutos >= 0)
            {
                Program.produtos[posicaoProdutos] = produto;
                MessageBox.Show("Cadastro alterado com sucesso!");
            }
            else
            {
                Program.produtos.Add(produto);
                MessageBox.Show("Cadastro realizado com sucesso!");
            }
            LimparCamposProdutos();
            AtualizarListaProdutos();
        }

        private void LimparCamposProdutos()
        {
            txtNomeProduto.Text = "";
            cbSetorProduto.SelectedIndex = -1;
            nudQuantidadeProduto.Value = 0;
            dtpDataEntradaProduto.Value = DateTime.Now;
            txtValorUnitarioProduto.Text = "0";
            txtNomeLivro.Text = "";
            cbDisciplinaLivro.SelectedIndex = -1;
            cbCapaLivro.SelectedIndex = -1;
            txtNomeAutorLivro.Text = "";
            dtpAnoLançamentoLivro.Value = DateTime.Now;
        }

        private void AtualizarListaProdutos()
        {
            dgvProdutos.Rows.Clear();
            string busca = txtBuscarProduto.Text.ToLower();
            for (int i = 0; i < Program.produtos.Count; i++)
            {
                Produto produto = Program.produtos[i];
                if (produto.NomeProduto.ToLower().Contains(busca)
                    || produto.NomeLivro.ToLower().Contains(busca))
                {
                    dgvProdutos.Rows.Add(new object[]{
                    produto.NomeProduto, produto.QuantidadeProduto, produto.EntradaProduto, produto.SetorProduto
                });
                }
            }
        }

        private void cbSetorProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            string biblioteca = cbSetorProduto.Text;
            if (biblioteca == "Biblioteca")
            {
                gb_Livro.Enabled = true;
            }
            else
            {
                gb_Livro.Enabled = false;
            }

        } //Selecionando Biblioteca libera o goupbox livro

        private void rbPrincipalPai_CheckedChanged(object sender, EventArgs e)  //selecionando o rb pai libera o groupbox endereço pai/responsavel 
        {
            if (rbPrincipalPai.Checked)
            {
                gb_EnderecoPai.Enabled = true;
            }
            else
            {
                gb_EnderecoPai.Enabled = false;
            }
        }

        private void rbPrincipalMae_CheckedChanged(object sender, EventArgs e) // selecionando o rb mae libera o groupbox endereço mae/responsavel
        {
            if (rbPrincipalMae.Checked)
            {
                gb_EnderecoMae.Enabled = true;
            }
            else
            {
                gb_EnderecoMae.Enabled = false;
            }
        }

        private void btnAtualizarProduto_Click(object sender, EventArgs e)
        {
            AtualizarListaProdutos();
        }

        // -------------------------- Fim Menu Produtos

        // -------------------------- Inicio Menu Professores
        int posicaoProfessores = -1;

        public TelaPrincipal(Professor professor, int posicaoProfessores)
        {
            InitializeComponent();

            this.posicaoProfessores = posicaoProfessores;

            txtNomeProfessor.Text = professor.NomeProfessor;
            cbSexoProfessor.SelectedItem = professor.SexoProfessor;
            mtbCpfProfessor.Text = professor.CPFProfessor;
            cbTurnoProfessor.SelectedItem = professor.TurnoProfessor;
            cbNacionalidadeProfessor.SelectedItem = professor.NacionalidadeProfessor;
            dtpDataNascimentoProfessor.Value = professor.NascimentoProfessor;
            cbEspecialidadeProfessores.SelectedItem = professor.EspecialidadeProfessor;
            txtNumeroConta.Text = professor.NumeroContaSalarioProfessor.ToString();
            txtNumeroAgencia.Text = professor.NumeroAgenciaContaSalarioProfessor.ToString();
            mtbCepProfessor.Text = professor.CEPProfessor.ToString();
            txtUfProfessor.Text = professor.UFProfessor;
            nudNumeroProfessores.Value = professor.NumeroCasaProfessor;
            txtEmailProfessores.Text = professor.EmailProfessor;
        }

        private void btnSalvarProfessores_Click_1(object sender, EventArgs e)
        {
            if (txtNomeProfessor.Text.Length < 4)
            {
                MessageBox.Show("Nome do professor deve conter no mínimo 4 caracteres. Digite o nome completo.");
                txtNomeProfessor.Focus();
                return;
            }

            if (cbSexoProfessor.SelectedIndex < 0)
            {
                MessageBox.Show("Selecione o sexo do professor.");
                cbSexoProfessor.DroppedDown = true;
                return;
            }

            if (cbNacionalidadeProfessor.SelectedIndex < 0)
            {
                MessageBox.Show("Selecione a nacionalidade do professor.");
                cbNacionalidadeProfessor.DroppedDown = true;
                return;
            }

            if (!Tools.ValidaCPF(mtbCpfProfessor.Text))
            {
                MessageBox.Show("CPF inválido.");
                mtbCpfProfessor.Focus();
                return;
            }

            //if (!Tools.ValidaRG(txtRgProfessor.Text))
            //{
            //    MessageBox.Show("RG inválido.");
            //    txtRgProfessor.Focus();
            //    return;
            //}


            if (dtpDataNascimentoProfessor.Value > DateTime.Now) // TODO: Falta Colocar idade minima
            {
                MessageBox.Show("Data de nascimento deve ser hoje ou uma data anterior.");
                dtpDataNascimentoProfessor.Focus();
                return;
            }

            if (cbTurnoProfessor.SelectedIndex < 0)
            {
                MessageBox.Show("Selecione um turno.");
                cbTurnoProfessor.Focus();
                return;
            }

            if (txtNumeroConta.Text.Length < 5)
            {
                MessageBox.Show("Infome um número de conta válido");
                txtNumeroConta.Focus();
                return;
            }
            try
            {
                Convert.ToInt32(txtNumeroConta.Text);
            }
            catch
            {
                MessageBox.Show("Infome um número de conta válido");
                txtNumeroConta.Focus();
                return;
            }

            if (txtNumeroAgencia.Text.Length < 2)
            {
                MessageBox.Show("Infome um número de agencia válido");
                txtNumeroAgencia.Focus();
                return;
            }
            try
            {
                Convert.ToInt32(txtNumeroAgencia.Text);
            }
            catch
            {
                MessageBox.Show("Infome um número de agencia válido");
                txtNumeroAgencia.Focus();
                return;
            }

            if (cbEspecialidadeProfessores.SelectedIndex < 0)
            {
                MessageBox.Show("Selecione uma especialidade");
                cbEspecialidadeProfessores.DroppedDown = true;
                return;
            }

            if (mtbCepProfessor.Text.Replace("-", "").Length != 8)
            {
                MessageBox.Show("Preencha o cep.");
                tabControl1.SelectTab("tb_EnderecoProfessor");
                mtbCepProfessor.Focus();
                return;
            }

            Professor professor = new Professor()
            {
                NomeProfessor = txtNomeProfessor.Text,
                SexoProfessor = cbSexoProfessor.SelectedItem.ToString(),
                TurnoProfessor = cbTurnoProfessor.SelectedItem.ToString(),
                RGProfessor = txtRgProfessor.Text, 
                CPFProfessor = mtbCpfProfessor.Text,
                NacionalidadeProfessor = cbNacionalidadeProfessor.SelectedItem.ToString(),
                NascimentoProfessor = dtpDataNascimentoProfessor.Value,
                EspecialidadeProfessor = cbEspecialidadeProfessores.SelectedItem.ToString(),
                NumeroContaSalarioProfessor = Convert.ToInt32(txtNumeroConta.Text),
                NumeroAgenciaContaSalarioProfessor = Convert.ToInt32(txtNumeroAgencia.Text),
                CEPProfessor = mtbCepProfessor.Text,
                UFProfessor = txtUfProfessor.Text,
                NumeroCasaProfessor = Convert.ToInt32(nudNumeroProfessores.Value),
                EmailProfessor = txtEmailProfessores.Text,
                ComplementoProfessor = txtComplementoProfessores.Text
            };

            if (posicaoProfessores >= 0)
            {
                Program.professores[posicaoProfessores] = professor;
                MessageBox.Show("Cadastro alterado com sucesso!");
            }
            else
            {
                Program.professores.Add(professor);
                MessageBox.Show("Cadastro realizado com sucesso!");
            }
            LimparCamposProfessor();
            AtualizarListaProfessores();
        }

        private void LimparCamposProfessor()
        {
            txtNomeProfessor.Text = "";
            cbSexoProfessor.SelectedIndex = -1;
            mtbCpfProfessor.Text = "";
            txtRgProfessor.Text = "";
            cbTurnoProfessor.SelectedIndex = -1;
            cbNacionalidadeProfessor.SelectedIndex = -1;
            dtpDataNascimentoProfessor.Value = DateTime.Now;
            cbEspecialidadeProfessores.SelectedIndex = -1;
            txtNumeroConta.Text = "";
            txtNumeroAgencia.Text = "";
            mtbCepProfessor.Text = "";
            txtUfProfessor.Text = "";
            nudNumeroProfessores.Value = 0;
            txtEmailProfessores.Text = "";
            txtLogradouroProfessores.Text = "";
            txtCidadeProfessores.Text = "";
            txtBairroProfessor.Text = "";
            txtComplementoProfessores.Text = "";
        }

        private void AtualizarListaProfessores()
        {
            dgvProfessores.Rows.Clear();
            string busca = txtBuscarProfessores.Text.ToLower();
            for (int i = 0; i < Program.professores.Count; i++)
            {
                Professor professor = Program.professores[i];
                if ((professor.NomeProfessor.ToLower().Contains(busca)) || (professor.CPFProfessor.ToLower().Contains(busca)) || (professor.SexoProfessor.ToLower().Contains(busca)) || (professor.TurnoProfessor.ToLower().Contains(busca)))
                {
                    dgvProfessores.Rows.Add(new object[]{
                        professor.NomeProfessor, professor.SexoProfessor, professor.CPFProfessor, professor.TurnoProfessor, professor.EspecialidadeProfessor
                    });
                }
            }
        }

        private void btnEditarProfessor_Click(object sender, EventArgs e)
        {
            if (dgvProfessores.CurrentRow == null)
            {
                MessageBox.Show("Não tem nenhuma peça selecionada!");
                return;
            }

            InserirInformacoesDoProfessorNoCadastro();
        }

        private void dgvProfessores_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            InserirInformacoesDoProfessorNoCadastro();
        }

        private void InserirInformacoesDoProfessorNoCadastro()
        {
            Professor professor = Program.professores.Find(x =>
                x.NomeProfessor == Convert.ToString(this.dgvProfessores.CurrentRow.Cells["ColumnNome"].Value));

            this.txtNomeProfessor.Text = professor.NomeProfessor;
            this.cbSexoProfessor.Text = professor.SexoProfessor;
            this.mtbCpfProfessor.Text = professor.CPFProfessor;
            this.cbTurnoProfessor.Text = professor.TurnoProfessor;
            this.cbNacionalidadeProfessor.Text = professor.NacionalidadeProfessor;
            this.txtRgProfessor.Text = professor.RGProfessor;
            this.txtNumeroAgencia.Text = professor.NumeroAgenciaContaSalarioProfessor.ToString();
            this.txtNumeroConta.Text = professor.NumeroContaSalarioProfessor.ToString();
            this.cbEspecialidadeProfessores.Text = professor.EspecialidadeProfessor;
            this.mtbCepProfessor.Text = professor.CEPProfessor;
            this.nudNumeroProfessores.Value = professor.NumeroCasaProfessor;
            this.txtEmailProfessores.Text = professor.EmailProfessor;
            this.txtComplementoProfessores.Text = professor.ComplementoProfessor;
        }

        private void txtBuscarProfessores_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AtualizarListaProfessores();
            }
        }

        private void btnAtualizarProfessores_Click(object sender, EventArgs e)
        {
            AtualizarListaProfessores();
        }

        private void btnApagarProfessores_Click(object sender, EventArgs e)
        {
            if (dgvProfessores.CurrentRow == null)
            {
                MessageBox.Show("Não tem nenhuma peça selecionada!");
                return;
            }

            int linhaSelecionada = dgvProfessores.CurrentRow.Index;

            Professor professor = Program.professores[linhaSelecionada];
            DialogResult resultado = MessageBox.Show("Deseja realmente apagar o registro " + professor.NomeProfessor + "?", "AVISO", MessageBoxButtons.YesNo);

            if (resultado == DialogResult.Yes)
            {
                Program.professores.RemoveAt(linhaSelecionada);
                AtualizarListaProfessores();
                MessageBox.Show("Registro apagado com sucesso!");
            }
            else
            {
                MessageBox.Show("Registro não apagado.");
            }
        }
        // -------------------------- Fim Menu Professores


        // -------------------------- Inicio Menu Alunos
        int posicaoAlunos = -1;

        public void CadastroAlunos(Aluno aluno, int posicaoAlunos)
        {
            InitializeComponent();



            this.posicaoAlunos = posicaoAlunos;

            txtNomeAluno.Text = aluno.NomeAluno;
            cbNacionalidadeAluno.SelectedItem = aluno.NacionalidadeAluno;
            mtbCpfAluno.Text = aluno.CPFAluno;
            txtRgAluno.Text = aluno.RGALuno;
            cbSexoAluno.SelectedItem = aluno.SexoAluno;
            dtpDataNascimentoAluno.Value = aluno.NascimentoAluno;
            dtpDataMatriculaAluno.Value = aluno.DataMatriculaAluno;
            cbCursando.Checked = aluno.CursandoAluno;
            txtMatriculaAluno.Text = aluno.NumeroMatriculaAluno.ToString();
            cbTurnoAluno.SelectedItem = aluno.PeriodoAluno;
            cbTurmaAluno.SelectedItem = aluno.TurmaAluno;
            txtNomePai.Text = aluno.PaiAluno;
            cbSexoPai.SelectedItem = aluno.SexoPaiAluno;
            dtpNascimentoPai.Value = aluno.DataNascimentoPaiAluno;
            mtbCpfPai.Text = aluno.CPFPaiAluno;
            txtRgPai.Text = aluno.RGPaiAluno;
            mtbTelefonePai.Text = aluno.TelefonePaiAluno.ToString();
            txtNomeMae.Text = aluno.MaeAluno;
            cbSexoMae.SelectedItem = aluno.SexoMaeAluno;
            dtpNascimentoMae.Value = aluno.DataNascimentoMaeAluno;
            mtbCpfMae.Text = aluno.CPFMaeAluno;
            txtRgMae.Text = aluno.RGMaeAluno;
            mtbTelefonMae.Text = aluno.TelefoneMaeAluno.ToString();
        }

        private void btnSalvarEnderecoResponsavel_Click(object sender, EventArgs e)
        {


            if (txtNomeAluno.Text.Length < 4)
            {
                MessageBox.Show("Nome do aluno deve conter no mínimo 4 caracteres. Digite o nome completo.");
                txtNomeAluno.Focus();
                return;
            }

            if (cbNacionalidadeAluno.SelectedIndex < 0)
            {
                MessageBox.Show("Selecione a nacionalidade.");
                cbNacionalidadeAluno.DroppedDown = true;
                return;
            }

            if (!Tools.ValidaCPF(mtbCpfAluno.Text))
            {
                MessageBox.Show("CPF inválido.");
                mtbCpfAluno.Focus();
                return;
            }

            //if (!Tools.ValidaRG(mtbRgAluno.Text))
            //{
            //    MessageBox.Show("RG inválido");
            //    mtbRgAluno.Focus();
            //    return;
            //}

            if (dtpDataNascimentoAluno.Value > DateTime.Now)
            {
                MessageBox.Show("Data de nascimento deve ser hoje ou uma data anterior.");
                dtpDataNascimentoAluno.Focus();
                return;
            }

            if (dtpDataMatriculaAluno.Value > DateTime.Now)
            {
                MessageBox.Show("Data de matrícula deve ser hoje ou uma data anterior.");
                dtpDataMatriculaAluno.Focus();
                return;
            }

            //if (!rbPrincipalPai.Checked || !rbPrincipalMae.Checked)
            //{
            //    MessageBox.Show("Selecione o endereço principal.");
            //    return;
            //}

            // TODO: pegar numero aleatorio de matricula

            if (cbTurnoAluno.SelectedIndex < 0)
            {
                MessageBox.Show("Selecione um turno.");
                cbTurnoAluno.DroppedDown = true;
                return;
            }

            if (cbTurmaAluno.SelectedIndex < 0)
            {
                MessageBox.Show("Selecione uma turma.");
                cbTurmaAluno.DroppedDown = true;
                return;
            }

            if (txtNomePai.Text.Length < 4)
            {
                MessageBox.Show("Nome do pai deve conter no mínimo 4 caracteres. Digite o nome completo.");
                txtNomePai.Focus();
                return;
            }

            if (cbSexoPai.SelectedIndex < 0)
            {
                MessageBox.Show("Selecione o sexo do pai.");
                cbSexoPai.DroppedDown = true;
                return;
            }

            if (dtpNascimentoPai.Value > DateTime.Now)
            {
                MessageBox.Show("Data de nacsimento deve ser hoje ou uma data anterior.");
                dtpNascimentoPai.Focus();
                return;
            }

            //if (!Tools.ValidaRG(mtbRgPai.Text))
            //{
            //    MessageBox.Show("RG inválido");
            //    mtbRgPai.Focus();
            //    return;
            //}

            if (!Tools.ValidaCPF(mtbCpfPai.Text))
            {
                MessageBox.Show("CPF inválido.");
                mtbCpfPai.Focus();
                return;
            }

            //if (!Tools.ValidarTelefone(mtbTelefonePai.Text))
            //{
            //    MessageBox.Show("Telefone inválido.");
            //    mtbTelefonePai.Focus();
            //    return;
            //}

            if (txtNomeMae.Text.Length < 4)
            {
                MessageBox.Show("Nome do aluno deve conter no mínimo 4 caracteres. Digite o nome completo.");
                txtNomeAluno.Focus();
                return;
            }

            if (cbSexoMae.SelectedIndex < 0)
            {
                MessageBox.Show("Selecione o sexo da mãe.");
                cbSexoMae.DroppedDown = true;
                return;
            }

            if (dtpNascimentoMae.Value > DateTime.Now)
            {
                MessageBox.Show("Data de nacsimento deve ser hoje ou uma data anterior.");
                dtpNascimentoMae.Focus();
                return;
            }

            if (!Tools.ValidaCPF(mtbCpfMae.Text))
            {
                MessageBox.Show("CPF inválido.");
                mtbCpfMae.Focus();
                return;
            }

            //if (!Tools.ValidaRG(mtbRgMae.Text))
            //{
            //    MessageBox.Show("RG inválido");
            //    mtbRgMae.Focus();
            //    return;
            //}

            //if (!Tools.ValidarTelefone(mtbTelefonMae.Text))
            //{
            //    MessageBox.Show("Telefone inválido.");
            //    mtbTelefonMae.Focus();
            //    return;
            //}


            //Validação do CEP ja esta pronta nos metodos Buscar CEP da tela principal

            if (rbPrincipalPai.Checked)
            {
                Aluno cepPai = new Aluno() { CEPPrincipal = mtbCepPai.Text };    //armazenar somente o cep. Na hora de editar o aluno, ira mostrar o endereço completo 
            }
            if (rbPrincipalMae.Checked)
            {
                Aluno cepMae = new Aluno() { CEPPrincipal = mtbCepMae.Text };
            }

            Aluno aluno = new Aluno()
            {
                NomeAluno = txtNomeAluno.Text,
                NacionalidadeAluno = cbNacionalidadeAluno.SelectedItem.ToString(),
                CPFAluno = mtbCpfAluno.Text,
                RGALuno = txtRgAluno.Text,
                NascimentoAluno = dtpDataNascimentoAluno.Value,
                DataMatriculaAluno = dtpDataMatriculaAluno.Value,
                CursandoAluno = cbCursando.Checked,
                NumeroMatriculaAluno = txtMatriculaAluno.Text,
                PeriodoAluno = cbTurnoAluno.SelectedItem.ToString(),
                TurmaAluno = cbTurmaAluno.SelectedItem.ToString(),
                TurnoAluno = cbTurnoAluno.SelectedItem.ToString(),
                SexoAluno = cbSexoAluno.SelectedItem.ToString(),
                PaiAluno = txtNomePai.Text,
                SexoPaiAluno = cbSexoPai.SelectedItem.ToString(),
                DataNascimentoPaiAluno = dtpNascimentoPai.Value,
                DataNascimentoMaeAluno = dtpNascimentoPai.Value,
                CPFPaiAluno = mtbCpfPai.Text,
                RGPaiAluno = txtRgPai.Text,
                TelefonePaiAluno = mtbTelefonePai.Text.ToString(),
                MaeAluno = txtNomeMae.Text,
                SexoMaeAluno = cbSexoMae.SelectedItem.ToString(),
                CPFMaeAluno = mtbCpfMae.Text,
                RGMaeAluno = txtRgMae.Text,
                TelefoneMaeAluno = mtbTelefonMae.Text.ToString(),
            };


            if (posicaoAlunos >= 0)
            {
                Program.alunos[posicaoAlunos] = aluno;
                MessageBox.Show("Cadastro alterado com sucesso!");
            }
            else
            {
                Program.alunos.Add(aluno);
                MessageBox.Show("Cadastro realizado com sucesso!");
            }
            LimparCamposAluno();
            AtualizarListaAlunos();
        }

        private void LimparCamposAluno() //ADD cepmae e ceppai 
        {
            txtNomeAluno.Text = "";
            cbNacionalidadeAluno.SelectedIndex = -1;
            mtbCpfAluno.Text = "";
            txtRgAluno.Text = "";
            cbSexoAluno.SelectedIndex = -1;
            dtpDataNascimentoAluno.Value = DateTime.Now;
            dtpDataMatriculaAluno.Value = DateTime.Now;
            cbCursando.Checked = true;
            txtMatriculaAluno.Text = "";
            cbTurnoAluno.SelectedIndex = -1;
            cbTurmaAluno.SelectedIndex = -1;
            txtNomePai.Text = "";
            cbSexoPai.SelectedIndex = -1;
            dtpNascimentoPai.Value = DateTime.Now;
            mtbCpfPai.Text = "";
            txtRgPai.Text = "";
            mtbTelefonePai.Text = "";
            txtNomeMae.Text = "";
            cbSexoMae.SelectedIndex = -1;
            dtpNascimentoMae.Value = DateTime.Now;
            mtbCpfMae.Text = "";
            txtRgMae.Text = "";
            mtbTelefonMae.Text = "";
            mtbCepMae.Text = "";
            mtbCepPai.Text = "";
            txtLogradouroMae.Text = "";
        }

        private void AtualizarListaAlunos()
        {
            dgvAlunos.Rows.Clear();
            string busca = txtBuscarAlunos.Text.ToLower();
            for (int i = 0; i < Program.alunos.Count; i++)
            {
                Aluno aluno = Program.alunos[i];
                if ((aluno.NomeAluno.ToLower().Contains(busca)) || (aluno.CPFAluno.ToLower().Contains(busca)) || (aluno.SexoAluno.ToLower().Contains(busca)) || (aluno.PaiAluno.ToLower().Contains(busca)) || (aluno.MaeAluno.ToLower().Contains(busca)) || (aluno.NacionalidadeAluno.ToLower().Contains(busca)))
                {
                    dgvAlunos.Rows.Add(new object[]{
                    aluno.NomeAluno, aluno.CPFAluno, aluno.PeriodoAluno, aluno.TurmaAluno, aluno.DataMatriculaAluno 
                });
                }
            }
        }

        private void dgvAlunos_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            InserirInformacoesDoAlunoNoCadastro();
        }

        private void txtBuscarAlunos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AtualizarListaAlunos();
            }
        }

        private void InserirInformacoesDoAlunoNoCadastro()
        {
            Aluno aluno = Program.alunos.Find(x =>
                x.NomeAluno == Convert.ToString(this.dgvAlunos.CurrentRow.Cells["ColumnNomeAluno"].Value));

            this.txtNomeAluno.Text = aluno.NomeAluno;
            this.cbSexoAluno.Text = aluno.SexoAluno;
            this.mtbCpfAluno.Text = aluno.CPFAluno;
            this.cbNacionalidadeAluno.Text = aluno.NacionalidadeAluno;
            this.cbTurnoAluno.Text = aluno.TurnoAluno;
            this.cbTurmaAluno.Text = aluno.TurmaAluno;
            this.dtpDataNascimentoAluno.Value = aluno.NascimentoAluno;
            this.dtpDataMatriculaAluno.Value = aluno.DataMatriculaAluno;
            this.txtRgAluno.Text = aluno.RGALuno;
            this.cbCursando.Checked = aluno.CursandoAluno;
            this.txtCepPrincipal.Text = aluno.CEPPrincipal;
            this.txtNomePai.Text = aluno.PaiAluno;
            this.cbSexoPai.Text = aluno.SexoPaiAluno;
            this.mtbCpfPai.Text = aluno.CPFPaiAluno;
            this.txtRgPai.Text = aluno.RGPaiAluno;
            this.mtbTelefonePai.Text = aluno.TelefonePaiAluno;
            this.txtMatriculaAlunoPai.Text = aluno.NumeroMatriculaAluno;
            this.dtpNascimentoPai.Value = aluno.DataNascimentoPaiAluno;
            this.txtNomeMae.Text = aluno.MaeAluno;
            this.cbSexoMae.Text = aluno.SexoMaeAluno;
            this.dtpNascimentoMae.Value = aluno.DataNascimentoMaeAluno;
            this.mtbCpfMae.Text = aluno.CPFMaeAluno;
            this.txtRgMae.Text = aluno.RGMaeAluno;
            this.mtbTelefonMae.Text = aluno.TelefoneMaeAluno;
            this.txtMatriculaAlunoMae.Text = aluno.NumeroMatriculaAluno;
            if (rbPrincipalPai.Checked)
            {
                this.mtbCepPai.Text = aluno.CEPPrincipal;
                this.txtEmailPai.Text = aluno.EmailPai;
                this.nudNumeroPai.Value = aluno.NumeroCasaPai;
                this.txtComplementoPai.Text = aluno.ComplementoPai;
            }
            else
            {
                this.mtbCepMae.Text = aluno.CEPPrincipal;
                this.txtEmailMae.Text = aluno.EmailMae;
                this.nudNumeroMae.Value = aluno.NumeroCasaMae;
                this.txtComplementoMae.Text = aluno.ComplementoMae;
            }


        }

        private void btnEditarAluno_Click(object sender, EventArgs e)
        {
            InserirInformacoesDoAlunoNoCadastro();
        }
        // -------------------------- Fim Menu Alunos

        // -------------------------- Inicio Menu Equipamento
        int posicaoEquipamento = -1;

        public void CadastroEquipamento(Equipamento equipamento, int posicaoEquipamento)
        {
            InitializeComponent();

            this.posicaoEquipamento = posicaoEquipamento;

            txtNomeEquipamento.Text = equipamento.NomeEquipamento;
            cbMarcaEquipamento.SelectedItem = equipamento.MarcaEquipamento;
            nudQuantidadeEquipamento.Value = equipamento.QuantidadeEquipamento;
            dtpDataEntradaEquipamento.Value = equipamento.DataEntradaEquipamento;
            cbSetorEquipamento.SelectedItem = equipamento.SetorEquipamento;
        }

        private void btnSalvarEquipamento_Click(object sender, EventArgs e)
        {
            if (txtNomeEquipamento.Text.Length < 4)
            {
                MessageBox.Show("Nome do equipamento deve conter no mínimo 4 caracteres.");
                txtNomeEquipamento.Focus();
                return;
            }

            if (cbMarcaEquipamento.SelectedIndex < 0)
            {
                MessageBox.Show("Selecione uma marca.");
                cbMarcaEquipamento.DroppedDown = true;
                return;
            }

            if (nudQuantidadeEquipamento.Value <= 0)
            {
                MessageBox.Show("Quantidade deve ser maior que 0.");
                nudQuantidadeEquipamento.Focus();
                return;
            }

            if (dtpDataEntradaEquipamento.Value > DateTime.Now)
            {
                MessageBox.Show("Data de entrada deve ser hoje ou uma data anterior.");
                dtpDataEntradaEquipamento.Focus();
                return;
            }

            if (cbSetorEquipamento.SelectedIndex < 0)
            {
                MessageBox.Show("Selecione um setor.");
                cbSetorEquipamento.DroppedDown = true;
                return;
            }

            Equipamento equipamento = new Equipamento()
            {
                NomeEquipamento = txtNomeEquipamento.Text,
                MarcaEquipamento = cbMarcaEquipamento.SelectedItem.ToString(),
                QuantidadeEquipamento = Convert.ToInt32(nudQuantidadeEquipamento.Value),
                DataEntradaEquipamento = dtpDataEntradaEquipamento.Value,
                SetorEquipamento = cbSetorEquipamento.SelectedItem.ToString()
            };

            if (posicaoEquipamento >= 0)
            {
                Program.equipamentos[posicaoEquipamento] = equipamento;
                MessageBox.Show("Cadastro alterado com sucesso!");
            }
            else
            {
                Program.equipamentos.Add(equipamento);
                MessageBox.Show("Cadastro realizado com sucesso!");
            }
            LimparCamposEquipamento();
            AtualizarListaEquipamentos();
        }

        private void LimparCamposEquipamento()
        {
            txtNomeEquipamento.Text = "";
            cbMarcaEquipamento.SelectedIndex = -1;
            nudQuantidadeEquipamento.Value = 0;
            dtpDataEntradaEquipamento.Value = DateTime.Now;
            cbSetorEquipamento.SelectedIndex = -1;
        }

        private void AtualizarListaEquipamentos()
        {
            dgvEquipamentos.Rows.Clear();
            string busca = txtBuscaEquipamento.Text.ToLower();
            for (int i = 0; i < Program.equipamentos.Count; i++)
            {
                Equipamento equipamento = Program.equipamentos[i];
                if ((equipamento.NomeEquipamento.ToLower().Contains(busca)) || (equipamento.MarcaEquipamento.ToLower().Contains(busca)) || (equipamento.SetorEquipamento.ToLower().Contains(busca)))
                {
                    dgvEquipamentos.Rows.Add(new object[]{
                    equipamento.NomeEquipamento, equipamento.SetorEquipamento, equipamento.QuantidadeEquipamento, equipamento.DataEntradaEquipamento
                });
                }
            }
        }

        private void txtMatriculaAluno_Leave(object sender, EventArgs e)
        {
            int matriculaAluno = numeroAleatorio.Next(1, 100);
            txtMatriculaAluno.Text = Convert.ToString(matriculaAluno);
        }

        private void btnApagarAluno_Click(object sender, EventArgs e)
        {
            if (dgvAlunos.CurrentRow == null)
            {
                MessageBox.Show("Não tem nenhuma peça selecionada!");
                return;
            }

            int linhaSelecionada = dgvAlunos.CurrentRow.Index;

            Aluno aluno = Program.alunos[linhaSelecionada];
            DialogResult resultado = MessageBox.Show("Deseja realmente apagar o registro " + aluno.NomeAluno + "?", "AVISO", MessageBoxButtons.YesNo);

            if (resultado == DialogResult.Yes)
            {
                Program.alunos.RemoveAt(linhaSelecionada);
                AtualizarListaAlunos();
                MessageBox.Show("Registro apagado com sucesso!");
            }
            else
            {
                MessageBox.Show("Registro não apagado.");
            }
        }

        private void btnApagarProduto_Click(object sender, EventArgs e)
        {
            if (dgvProdutos.CurrentRow == null)
            {
                MessageBox.Show("Não tem nenhuma peça selecionada!");
                return;
            }

            int linhaSelecionada = dgvProdutos.CurrentRow.Index;

            Produto produto = Program.produtos[linhaSelecionada];
            DialogResult resultado = MessageBox.Show("Deseja realmente apagar o registro " + produto.NomeProduto + "?", "AVISO", MessageBoxButtons.YesNo);

            if (resultado == DialogResult.Yes)
            {
                Program.produtos.RemoveAt(linhaSelecionada);
                AtualizarListaProdutos();
                MessageBox.Show("Registro apagado com sucesso!");
            }
            else
            {
                MessageBox.Show("Registro não apagado.");
            }
        }

        private void btnApagarAlimento_Click(object sender, EventArgs e)
        {
            if (dgvAlimentos.CurrentRow == null)
            {
                MessageBox.Show("Não tem nenhuma peça selecionada!");
                return;
            }

            int linhaSelecionada = dgvAlimentos.CurrentRow.Index;

            Alimento alimento = Program.alimentos[linhaSelecionada];
            DialogResult resultado = MessageBox.Show("Deseja realmente apagar o registro " + alimento.NomeAlimento + "?", "AVISO", MessageBoxButtons.YesNo);

            if (resultado == DialogResult.Yes)
            {
                Program.alimentos.RemoveAt(linhaSelecionada);
                AtualizarListaAlimentos();
                MessageBox.Show("Registro apagado com sucesso!");
            }
            else
            {
                MessageBox.Show("Registro não apagado.");
            }
        }

        private void btnAtualizarAlimento_Click(object sender, EventArgs e)
        {
            AtualizarListaAlimentos();
        }

        public void AtualizarListaAlimentos()
        {
            dgvAlimentos.Rows.Clear();
            string busca = txtBuscarAlimento.Text.ToLower();
            for (int i = 0; i < Program.alimentos.Count; i++)
            {
                Alimento alimento = Program.alimentos[i];
                if (alimento.NomeAlimento.ToLower().Contains(busca)
                    || alimento.CodigoBarraAlimento.ToString().Contains(busca))
                {
                    dgvAlimentos.Rows.Add(new object[]{
                    alimento.NomeAlimento, alimento.GrupoAlimentarAlimento, alimento.DataValidadeAlimento, alimento.QuantidadeAlimento
                });
                }
            }
        }

        private void btnApagarEquipamento_Click(object sender, EventArgs e)
        {
            if (dgvEquipamentos.CurrentRow == null)
            {
                MessageBox.Show("Não tem nenhuma peça selecionada!");
                return;
            }

            int linhaSelecionada = dgvEquipamentos.CurrentRow.Index;

            Equipamento equipamento = Program.equipamentos[linhaSelecionada];
            DialogResult resultado = MessageBox.Show("Deseja realmente apagar o registro " + equipamento.NomeEquipamento + "?", "AVISO", MessageBoxButtons.YesNo);

            if (resultado == DialogResult.Yes)
            {
                Program.equipamentos.RemoveAt(linhaSelecionada);
                AtualizarListaEquipamentos();
                MessageBox.Show("Registro apagado com sucesso!");
            }
            else
            {
                MessageBox.Show("Registro não apagado.");
            }
        }

        private void btn_AtualizarGrafico_Click(object sender, EventArgs e)
        {
            if (cb_Maior.Checked)
            {
                int maior = 0;

                for (int i = 0; i < Program.professores.Count; i++)
                {
                    Professor professorSistema = Program.professores[i];

                    if (professorSistema.NomeProfessor.Length > maior)
                    {
                        maior = professorSistema.NomeProfessor.Length;
                    }
                }
                this.chart_Financeiro.Series[1].Points.AddXY("Maior Nome", maior);

                if (cb_Menor.Checked)
                {
                    int menor = int.MaxValue;
                    for (int i = 0; i < Program.professores.Count; i++)
                    {
                        Professor professorSistema = Program.professores[i];
                        if (professorSistema.NomeProfessor.Length < menor)
                        {
                            menor = professorSistema.NomeProfessor.Length;
                        }
                    }
                    this.chart_Financeiro.Series[1].Points.AddXY("Menor Nome", menor);
                }
                if (cb_3D.Checked)
                {
                    chart_Financeiro.ChartAreas[0].Area3DStyle.Enable3D = true;
                }
                else
                {
                    chart_Financeiro.ChartAreas[0].Area3DStyle.Enable3D = false;
                }


            }
        }

        // -------------------------- Fim Menu Equipamento
    }

}
