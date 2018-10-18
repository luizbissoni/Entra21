using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExemploSerializacao
{
    public partial class ListaPersonagem : Form
    {
        public int posicao = -1;

        public static string NOME_ARQUIVO = "Personagens.bin";
        
        public ListaPersonagem()
        {
            InitializeComponent();
        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            Personagem personagem = new Personagem();
            personagem.SetNome(txt_Nome.Text);
            personagem.SetCla(cb_Clas.SelectedItem.ToString());
            personagem.SetNivelChakra(Convert.ToInt32(txt_Chakra.Text));
            PersonagemRepository tudo = new PersonagemRepository();

             if (posicao == -1)
            {
            tudo.AdicionarPersonagem(personagem);
            MessageBox.Show("Personagem add com sucesso.");
             }
             else
            {
                tudo.EditarPersonagem(personagem, posicao);
                MessageBox.Show("Personagem alterado com sucesso.");
            }
             LimparCampos();
            AtualizarListaPersonagem();
        }

        private void LimparCampos()
        {
            txt_Nome.Text = "";
            txt_Chakra.Text = "";
            cb_Clas.SelectedIndex = -1;
            posicao = -1;
        }

        private void ListaPersonagem_Activated(object sender, EventArgs e)
        {
            AtualizarListaPersonagem();
        }

        private void AtualizarListaPersonagem()
        {
            PersonagemRepository tudo = new PersonagemRepository();
            dataGridView1.Rows.Clear();
            foreach (Personagem personagem in tudo.ObterPersonagens())
            {
                dataGridView1.Rows.Add(new Object[] { 
                personagem.GetNome(),
                personagem.GetCla(),
                personagem.GetNivelChakra()
                });
            }
        }

        private void ListaPersonagem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.L)
            {
                ApagarPersonagem();
            }
            else if (e.KeyCode == Keys.F2)
            {
                EditarPersonagem();
            }
        }

        private void EditarPersonagem()
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("selecione algo.");
                return;
            }

            string nome = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
            PersonagemRepository repository = new PersonagemRepository();
            foreach (Personagem personagem in repository.ObterPersonagens())
            {
                int quantidade = 0;
                if (personagem.GetNome() == nome)
                {
                    txt_Nome.Text = personagem.GetNome();
                    txt_Chakra.Text = Convert.ToString(personagem.GetNivelChakra());
                    cb_Clas.SelectedItem = personagem.GetCla();
                    posicao = quantidade; //posiçao -1 cadastro, posiçao 0 em diante e editar
                    return;
                }
                    quantidade++;
            }
        }

        private void ApagarPersonagem()
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("selecione algo no grid.");
                return;
            }
            string nome = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();

            dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
            PersonagemRepository repository = new PersonagemRepository();
           
            repository.ApagarPersonagem(nome);
            MessageBox.Show(nome + " Apagado com sucesso.");
            LimparCampos();

            }
           
        }
    }

