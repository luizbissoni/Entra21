using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SistemaPokemon
{
    public partial class Form1 : Form
    {
        SqlConnection conectar = new SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\\Users\\100085\\Documents\\GitHub\\Manipulando-dbPokemons\\SistemaPokemon\\pokemons.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand comando = new SqlCommand();
        SqlDataReader dataRead;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pokemonsDataSet.pokemons' table. You can move, or remove it, as needed.
            this.pokemonsTableAdapter.Fill(this.pokemonsDataSet.pokemons);
            comando.Connection = conectar;
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.pokemonsTableAdapter.Fill(this.pokemonsDataSet.pokemons);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void btn_AtualizarLista_Click(object sender, EventArgs e)
        {
            try
            {
                conectar.Open();
                comando.CommandText = @"INSERT INTO pokemons(nome,categoria,altura,peso,hp,ataque,defesa,especial_ataque,especial_defesa,velocidade,descricao) VALUES('" + txt_Nome.Text + "','" + cb_Categoria.SelectedItem + "','"
                    + Convert.ToDouble(txt_Altura.Text) + "','" + Convert.ToDouble(txt_Peso.Text) + "','" + Convert.ToInt16(txt_HP.Text) + "','" + Convert.ToInt16(txt_Ataque.Text) + "','" + Convert.ToInt16(txt_Defesa.Text) + "','" + Convert.ToInt16(txt_EspecialAtaque.Text) + "','" + Convert.ToInt16(txt_EspecialDefesa.Text) + "','"
                    + Convert.ToInt16(txt_Velocidade.Text) + "','" + txt_Descricao.Text + "');";
                comando.ExecuteNonQuery();
                conectar.Close();
                MessageBox.Show("Pokemon add Com sucesso!.","Confirmação",
                    MessageBoxButtons.OK,MessageBoxIcon.Information);
                LimpaCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro!"+ ex.Message,"Problemas",
                    MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            
        }

        private void LimpaCampos()
        {
            txt_Altura.Text = string.Empty;
            txt_Ataque.Text = string.Empty;
            txt_Defesa.Text = string.Empty;
            txt_Descricao.Text = string.Empty;
            txt_EspecialAtaque.Text = string.Empty;
            txt_EspecialDefesa.Text = string.Empty;
            txt_HP.Text = string.Empty;
            txt_Nome.Text = string.Empty;
            txt_Peso.Text = string.Empty;
            txt_Velocidade.Text = string.Empty;
            cb_Categoria.SelectedIndex = -1;
        }

        private void btn_Ordenar_Click(object sender, EventArgs e)
        {
            conectar.Open();
            comando.CommandText = @"SELECT nome,codigo,categoria,altura,peso,hp,ataque,defesa,
          especial_ataque,especial_defesa,velocidade FROM pokemons ORDER BY nome,codigo,categoria,altura,peso,hp,ataque,defesa,especial_ataque,especial_defesa,velocidade;";
            comando.ExecuteNonQuery();
            conectar.Close();
        }

     
    }
}
