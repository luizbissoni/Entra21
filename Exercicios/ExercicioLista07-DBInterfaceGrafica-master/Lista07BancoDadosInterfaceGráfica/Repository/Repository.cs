using Lista07BancoDadosInterfaceGráfica.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista07BancoDadosInterfaceGráfica.Repository
{
    public class Repository
    {
        private string connectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\100085\Documents\Lista07BancoDadosInterfaceGráfica.mdf;Integrated Security=True;Connect Timeout=30";
        private SqlConnection connection = null;
        SqlCommand command = new SqlCommand();
        public Repository()
        {
            connection = new SqlConnection(connectionString);
        }

        public int Inserir(AlunosModel alunos)
        {
            connection.Open();
            command.Connection = connection;
            command.CommandText = @"INSERT INTO alunos(nome, nota_1, nota_2, nota_3, frequencia)VALUES(@NOME, @NOTA1, @NOTA2, @NOTA3, @FREQUENCIA)";

            command.Parameters.AddWithValue("@NOME", alunos.Nome);
            command.Parameters.AddWithValue("@NOTA1", alunos.Nota_1);
            command.Parameters.AddWithValue("@NOTA2", alunos.Nota_2);
            command.Parameters.AddWithValue("@NOTA3", alunos.Nota_3);
            command.Parameters.AddWithValue("@FREQUENCIA", alunos.Frequencia);

            int id = Convert.ToInt32(command.ExecuteScalar().ToString());
            connection.Close();
            return id;
        }

        public AlunosModel ObterCodigo(int codigo)
        {
            connection.Open();
            command.Connection = connection;
            command.CommandText = @"SELECT id, nome, nota_1, nota_2, nota_3, frequencia WHERE id = @ID";
            command.Parameters.AddWithValue("@ID", codigo);
            DataTable tabelaMemoria = new DataTable();
            tabelaMemoria.Load(command.ExecuteReader());
            if (tabelaMemoria.Rows.Count == 0)
            {
                return null;
            }
            AlunosModel aluno = new AlunosModel();
            aluno.Id = Convert.ToInt32(tabelaMemoria.Rows[0][0].ToString());
            aluno.Nome = tabelaMemoria.Rows[0][1].ToString();
            aluno.Matricula = Convert.ToInt16(tabelaMemoria.Rows[0][2].ToString());
            aluno.Nota_1 = Convert.ToDouble(tabelaMemoria.Rows[0][3].ToString());
            aluno.Nota_2 = Convert.ToDouble(tabelaMemoria.Rows[0][4].ToString());
            aluno.Nota_3 = Convert.ToDouble(tabelaMemoria.Rows[0][5].ToString());
            aluno.Frequencia = Convert.ToInt32(tabelaMemoria.Rows[0][6].ToString());
            connection.Close();
            return aluno;
        }

        public bool Apagar(int codigo)
        {
            connection.Open();
            command.Connection = connection;
            command.CommandText = "DELETE FROM alunos WHERE id = @CODIGO";
            command.Parameters.AddWithValue("@CODIGO", codigo);
            int quantidade = command.ExecuteNonQuery();
            connection.Close();
            return quantidade == 1;
        }

        public bool Alterar(AlunosModel alunos)
        {
            connection.Open();
            command.Connection = connection;
            command.CommandText = @"UPDATE alunos SET nome = @NOME, matricula = @MATRICULA, nota_1 = @NOTA_1, nota_2 = @NOTA_2, nota_3 = @NOTA_3, frequencia = @FREQUENCIA WHERE id = @ID";
            command.Parameters.AddWithValue("@NOME",alunos.Nome);
            command.Parameters.AddWithValue("@MATRICULA", alunos.Matricula);
            command.Parameters.AddWithValue("@NOTA_1", alunos.Nota_1);
            command.Parameters.AddWithValue("@NOTA_2", alunos.Nota_2);
            command.Parameters.AddWithValue("@NOTA_3", alunos.Nota_3);
            command.Parameters.AddWithValue("@FREQUENCIA", alunos.Frequencia);
            int quantidade = command.ExecuteNonQuery();
            connection.Close();
            return quantidade == 1;
        }

        public List<AlunosModel> obeterTodos(string texteParaPesquisar = "%%", string colunaOrdenacao = "nome", string tipoOrdenacao = "ASC")
        {
            texteParaPesquisar = "%" + texteParaPesquisar + "%";
            List<AlunosModel> alunos = new List<AlunosModel>();
            connection.Open();
            command.Connection = connection;
            command.CommandText = @"SELECT id, nome, matricula, nota_1, nota_2, nota_3, frequencia WHERE nome like @pesquisa ORDER BY " + colunaOrdenacao + " " + tipoOrdenacao;
            command.Parameters.AddWithValue("@PESQUISA", texteParaPesquisar);
            DataTable tabelaEmMemoria = new DataTable();
            tabelaEmMemoria.Load(command.ExecuteReader());
            for (int i = 0; i < tabelaEmMemoria.Rows.Count; i++)
            {
                AlunosModel aluno = new AlunosModel();
                aluno.Id = Convert.ToInt32(tabelaEmMemoria.Rows[i][0].ToString());
                aluno.Nome = tabelaEmMemoria.Rows[i][1].ToString();
                aluno.Matricula = Convert.ToInt16(tabelaEmMemoria.Rows[i][2].ToString());
                aluno.Nota_1 = Convert.ToDouble(tabelaEmMemoria.Rows[i][3].ToString());
                aluno.Nota_2 = Convert.ToDouble(tabelaEmMemoria.Rows[i][4].ToString());
                aluno.Nota_3 = Convert.ToDouble(tabelaEmMemoria.Rows[i][5].ToString());
                aluno.Frequencia = Convert.ToInt16(tabelaEmMemoria.Rows[i][6].ToString());
                alunos.Add(aluno);
            }
            return alunos;
        }



    }


}
