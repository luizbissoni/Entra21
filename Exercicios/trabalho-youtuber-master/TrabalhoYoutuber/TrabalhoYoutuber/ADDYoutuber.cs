using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;

namespace TrabalhoYoutuber
{
    public partial class ADDYoutuber : Form
    {
        public int posicao = -1;
        public static string NOME_ARQUIVO = "Youtubers.bin";

        public ADDYoutuber()
        {
            InitializeComponent();
            AtualizarListaYoutuber();
        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            Youtuber youtuber = new Youtuber();

            try
            {
                youtuber.SetNome(txt_Nome.Text);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                txt_Nome.Focus();
                return;
            }

            try
            {
                youtuber.SetApelido(txt_Apelido.Text);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                txt_Apelido.Focus();
                return;
            }

            try
            {
                youtuber.SetRenda(Convert.ToDouble(mtb_Renda.Text));
                mtb_Renda.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            try
            {
                youtuber.SetStreamer(cb_Streamer.SelectedItem.ToString());

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                cb_Streamer.DroppedDown = true;
                return;
            }

            try
            {
                if (cb_PatrocinadorSim.Checked)
                {
                    youtuber.SetPatrocinador(txt_NomePatrocinador.Text);
                }
                if (cb_PatrocinadorNao.Checked)
                {
                    youtuber.SetPatrocinador("nao");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                txt_NomePatrocinador.Focus();
                return;
            }

            try
            {
                youtuber.SetNomeCanal(txt_NomeCanal.Text);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                txt_NomeCanal.Focus();
                return;
            }

            try
            {
                youtuber.SetCategoria(cb_Categoria.SelectedItem.ToString());

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                cb_Categoria.DroppedDown = true;
                return;
            }

            try
            {
                youtuber.SetVideos(Convert.ToInt64(txt_Videos.Text));

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                txt_Videos.Focus();
                return;
            }
            try
            {
                youtuber.SetViews(Convert.ToInt64(txt_Views.Text));

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                txt_Views.Focus();
                return;
            }

            try
            {
                youtuber.SetLikes(Convert.ToInt64(txt_Likes.Text));

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                txt_Likes.Focus();
                return;
            }

            try
            {
                youtuber.SetInscritos(Convert.ToInt64(txt_Inscritos.Text));

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                txt_Inscritos.Focus();
                return;
            }

            try
            {
                youtuber.SetPlataforma(cb_Plataforma.SelectedItem.ToString());

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                cb_Plataforma.DroppedDown = true;
                return;
            }
            try
            {
                youtuber.SetDescricao(txt_Descricao.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            try
            {
                youtuber.SetNacionalidade(cb_Nacionalidade.SelectedItem.ToString());

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                cb_Nacionalidade.DroppedDown = true;
                return;
            }

            try
            {
                youtuber.SetStrikes(Convert.ToInt64(txt_Strikes.Text));

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                txt_Strikes.Focus();
                return;
            }

            try
            {
                if (cb_PatrocinadorSim.Checked)
                {
                    youtuber.SetPatrocinador(txt_NomePatrocinador.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            try
            {
                if (cb_AnuncioSim.Checked)
                {
                    youtuber.SetAnuncio("sim");
                }
                if (cb_AnuncioNao.Checked)
                {
                    youtuber.SetAnuncio("nao");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Informe se possui anuncios.");
                return;
            }

            try
            {
                youtuber.SetLink(txt_NomeCanal.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }


            Repository tudo = new Repository();
            if (posicao == -1)
            {
                tudo.AddYoutuber(youtuber);
                MessageBox.Show("Youtuber cadastrado com sucesso");
            }
            else
            {
                tudo.EditarYoutuber(youtuber, posicao);
                MessageBox.Show("Youtuber alterado com sucesso");
            }
            llb_Link.Enabled = true;
            LimpaCampos();
            AtualizarListaYoutuber();
        }

        private void AtualizarListaYoutuber()
        {
            Repository tudo = new Repository();
            dgv_ListaYoutubers.Rows.Clear();

            foreach (Youtuber youtuber in tudo.ObterYoutube())
            {
                dgv_ListaYoutubers.Rows.Add(new Object[] { youtuber.GetNome(), youtuber.GetNomeCanal(), youtuber.GetCategoria() });
            }
            llb_Link.Enabled = false;
        }

        public void LimpaCampos()
        {
            txt_Apelido.Text = string.Empty;
            txt_Descricao.Text = string.Empty;
            txt_Inscritos.Text = string.Empty;
            txt_Likes.Text = string.Empty;
            mtb_Renda.Text = string.Empty;
            txt_Nome.Text = string.Empty;
            txt_NomeCanal.Text = string.Empty;
            txt_NomePatrocinador.Text = string.Empty;
            txt_Strikes.Text = string.Empty; ;
            txt_Videos.Text = string.Empty;
            txt_Views.Text = string.Empty;
            cb_AnuncioNao.Checked = false;
            cb_AnuncioSim.Checked = false;
            cb_Categoria.SelectedIndex = -1;
            cb_Nacionalidade.SelectedIndex = -1;
            cb_PatrocinadorNao.Checked = false;
            cb_PatrocinadorSim.Checked = false;
            cb_Plataforma.SelectedIndex = -1;
            cb_Streamer.SelectedIndex = -1;

        }

        public void IrParaSite()
        {
            llb_Link.LinkVisited = true;
            System.Diagnostics.Process.Start("https://www.youtube.com/results?search_query=" + llb_Link.Links[0].LinkData.ToString());
        }

        private void EditarYoutuber()
        {
            if (dgv_ListaYoutubers.CurrentRow == null)
            {
                MessageBox.Show("Selecione uma linha.");
                return;
            }

            string nome = dgv_ListaYoutubers.Rows[dgv_ListaYoutubers.CurrentRow.Index].Cells[0].Value.ToString();

            Repository repositorio = new Repository();

            int quantidade = 0;

            foreach (Youtuber youtuber in repositorio.ObterYoutube())
            {
                if (youtuber.GetNome() == nome)
                {
                    txt_Nome.Text = youtuber.GetNome();
                    txt_Apelido.Text = youtuber.GetApelido();
                    txt_Descricao.Text = youtuber.GetDescricao();
                    txt_Inscritos.Text = Convert.ToString(youtuber.GetInscritos());
                    txt_Likes.Text = Convert.ToString(youtuber.GetLikes());
                    mtb_Renda.Text = Convert.ToString(youtuber.GetRenda());
                    txt_NomeCanal.Text = youtuber.GetNomeCanal();
                    llb_Link.Links.Clear();

                    llb_Link.Links.Add(0, 10, youtuber.GetLink());
                    txt_Strikes.Text = Convert.ToString(youtuber.GetStrokers());
                    txt_Videos.Text = Convert.ToString(youtuber.GetVideos());
                    txt_Views.Text = Convert.ToString(youtuber.GetViews());
                    cb_Categoria.SelectedItem = youtuber.GetCategoria();
                    cb_Nacionalidade.SelectedItem = youtuber.GetNacionalidade();
                    cb_Plataforma.SelectedItem = youtuber.GetPlataforma();
                    cb_Streamer.SelectedItem = youtuber.GetStreamer();
                    llb_Link.Enabled = true;
                    if (youtuber.GetAnuncio() == "sim")
                    {
                        cb_AnuncioSim.Checked = true;
                    }
                    else
                    {
                        cb_AnuncioNao.Checked = true;
                    }
                    if (youtuber.GetPatrocinador() == "nao")
                    {
                        cb_PatrocinadorNao.Checked = true;
                        txt_NomePatrocinador.Text = string.Empty;
                    }
                    else
                    {
                        cb_PatrocinadorSim.Checked = true;
                        txt_NomePatrocinador.Text = youtuber.GetPatrocinador();
                    }


                    posicao = quantidade;
                    return;
                }
                quantidade++;
            }
        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            ApagarYoutuber();
        }

        private void ApagarYoutuber()
        {
            Repository repositorio = new Repository();
            string nome = dgv_ListaYoutubers.Rows[dgv_ListaYoutubers.CurrentRow.Index].Cells[0].Value.ToString();

            if (dgv_ListaYoutubers.CurrentRow == null)
            {
                MessageBox.Show("Selecione algo neste grid");
                return;
            }
            DialogResult resultado = MessageBox.Show("Deseja apagar" + nome + "do registro ?", "AVISO", MessageBoxButtons.YesNo);

            if (resultado == DialogResult.Yes)
            {
                //string nome = dgv_ListaYoutubers.Rows[dgv_ListaYoutubers.CurrentRow.Index].Cells[0].Value.ToString();
                dgv_ListaYoutubers.Rows.RemoveAt(dgv_ListaYoutubers.CurrentRow.Index);
                repositorio.ApagarPersonagem(nome);
                MessageBox.Show(nome + " apagado com sucesso.");
                LimpaCampos();
            }


        }

        private void dgv_ListaYoutubers_DoubleClick(object sender, EventArgs e)
        {
            EditarYoutuber();
        }

        private void cb_PatrocinadorSim_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_PatrocinadorSim.Checked)
            {
                gb_Patrocinio.Enabled = true;
                cb_PatrocinadorNao.Checked = false;
            }
            else
            {
                gb_Patrocinio.Enabled = false;
                cb_PatrocinadorSim.Checked = false;
            }
        }

        private void cb_PatrocinadorNao_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_PatrocinadorNao.Checked)
            {
                cb_PatrocinadorSim.Checked = false;
            }
        }

        private void btn_Salvar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Salvar.PerformClick();

            }
        }

        private void btn_Excluir_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                btn_Excluir.PerformClick();
            }
        }

        private void llb_Link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            IrParaSite();
        }










    }
}
