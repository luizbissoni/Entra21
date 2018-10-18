using Lista07MVC.DataBase;
using Lista07MVC.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Lista07MVC.Repository
{
    public class AlunoRepository
    {
        public List<Alunos> ObeterTodos()
        {
            List<Alunos> alunos = new List<Alunos>();
            SqlCommand command = new BancoDados().ObterConexao();
            command.CommandText = "SELECT id, nome, codigo_matricula, nota_1, nota_2, nota_3, frequencia, situacao FROM alunos";
            DataTable table = new DataTable();

            table.Load(command.ExecuteReader());
            foreach (DataRow linha in table.Rows)
            {
                Alunos aluno = new Alunos()
                {
                    Id = Convert.ToInt32(linha[0].ToString()),
                    Nome = linha[1].ToString(),
                    CodigoMatricula = linha[2].ToString(),
                    Nota_1 = Convert.ToDouble(linha[3].ToString()),
                    Nota_2 = Convert.ToDouble(linha[4].ToString()),
                    Nota_3 = Convert.ToDouble(linha[5].ToString()),
                    Frequencia = Convert.ToInt32(linha[6].ToString()),
                    Situacao = linha[7].ToString()
                };
                alunos.Add(aluno);

            }
            return alunos;
        }

        public int Cadastrar(Alunos aluno)
        {
            SqlCommand command = new BancoDados().ObterConexao();
            command.CommandText = "INSERT INTO alunos(nome, codigo_matricula,nota_1, nota_2, nota_3, frequencia, situacao) OUTPUT INSERTED.ID VALUES (@NOME, @CODIGO_MATRICULA, @NOTA_1, @NOTA_2, @NOTA_3, @FREQUENCIA, @SITUACAO)";
            command.Parameters.AddWithValue("@NOME", aluno.Nome);
            command.Parameters.AddWithValue("@CODIGO_MATRICULA", aluno.CodigoMatricula);
            command.Parameters.AddWithValue("@NOTA_1", aluno.Nota_1);
            command.Parameters.AddWithValue("@NOTA_2", aluno.Nota_2);
            command.Parameters.AddWithValue("@NOTA_3", aluno.Nota_3);
            command.Parameters.AddWithValue("@FREQUENCIA", aluno.Frequencia);
            command.Parameters.AddWithValue("@SITUACAO", aluno.Situacao);

            int id = Convert.ToInt32(command.ExecuteScalar().ToString());

            return id;
        }

        public bool Alterar(Alunos aluno)
        {
            SqlCommand command = new BancoDados().ObterConexao();
            command.CommandText = "UPDATE alunos SET nome = @NOME, codigo_matricula = @CODIGO_MATRICULA, nota_1 = @NOTA_1, nota_2 = @NOTA_2, nota_3 = @NOTA_3, frequencia = @FREQUENCIA, situacao = @SITUACAO WHERE id = @ID";
            command.Parameters.AddWithValue("@ID", aluno.Id);
            command.Parameters.AddWithValue("@NOME", aluno.Nome);
            command.Parameters.AddWithValue("@CODIGO_MATRICULA", aluno.CodigoMatricula);
            command.Parameters.AddWithValue("@NOTA_1", aluno.Nota_1);
            command.Parameters.AddWithValue("@NOTA_2", aluno.Nota_2);
            command.Parameters.AddWithValue("@NOTA_3", aluno.Nota_3);
            command.Parameters.AddWithValue("@FREQUENCIA", aluno.Frequencia);
            command.Parameters.AddWithValue("@SITUACAO", aluno.Situacao);

            return command.ExecuteNonQuery() == 1;
        }

        public bool Excluir(int id)
        {
            SqlCommand command = new BancoDados().ObterConexao();
            command.CommandText = "DELETE FROM alunos WHERE id = @ID";
            command.Parameters.AddWithValue("@ID", id);

            return command.ExecuteNonQuery() == 1;
        }

        public Alunos ObterPeloId(int id)
        {
            Alunos aluno = null;
            SqlCommand command = new BancoDados().ObterConexao();
            command.CommandText = "SELECT nome, codigo_matricula, nota_1, nota_2, nota_3, frequencia, situacao FROM alunos WHERE id = @ID";
            command.Parameters.AddWithValue("@ID", id);
            DataTable table = new DataTable();
            table.Load(command.ExecuteReader());
            if (table.Rows.Count == 1)
            {
                aluno = new Alunos();
                aluno.Id = id;
                aluno.Nome = table.Rows[0][0].ToString();
                aluno.CodigoMatricula = table.Rows[0][1].ToString();
                aluno.Nota_1 = Convert.ToDouble(table.Rows[0][2].ToString());
                aluno.Nota_2 = Convert.ToDouble(table.Rows[0][3].ToString());
                aluno.Nota_3 = Convert.ToDouble(table.Rows[0][4].ToString());
                aluno.Frequencia = Convert.ToInt32(table.Rows[0][5].ToString());
                aluno.Situacao = table.Rows[0][6].ToString();
            }
            return aluno;
        }
    }
}