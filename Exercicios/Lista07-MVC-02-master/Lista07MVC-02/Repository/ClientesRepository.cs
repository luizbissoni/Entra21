using Lista07MVC_02.DataBase;
using Lista07MVC_02.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Lista07MVC_02.Repository
{
    public class ClientesRepository
    {
        public List<ClientesModel> GetAll()
        {
            List<ClientesModel> clientes = new List<ClientesModel>();
            SqlCommand command = new BancoDados().ObterConexao();
            command.CommandText = "SELECT id, dono, modelo, cor, colaborador_responsavel, estatus, data_orcamento, valor_orcamento, valor_desconto, valor_total, data_finalizacao_servico FROM mecanicas";
            DataTable table = new DataTable();

            table.Load(command.ExecuteReader());
            foreach (DataRow linha in table.Rows)
            {
                ClientesModel cliente = new ClientesModel()
                {
                    Id = Convert.ToInt32(linha[0].ToString()),
                    Dono = linha[1].ToString(),
                    Modelo = linha[2].ToString(),
                    Cor = linha[3].ToString(),
                    ColaboradorResponsavel = linha[4].ToString(),
                    Status = linha[5].ToString(),
                    DataOrcamento = Convert.ToDateTime(linha[6].ToString()),
                    ValorOrcamento = Convert.ToDouble(linha[7].ToString()),
                    ValorDesconto = Convert.ToDouble(linha[8].ToString()),
                    ValorTotal = Convert.ToDouble(linha[9].ToString()),
                    DataFinalizacaoServico = Convert.ToDateTime(linha[10].ToString())
                };
                clientes.Add(cliente);
            }
            return clientes;
        }
        public int Register(ClientesModel cliente)
        {
            SqlCommand command = new BancoDados().ObterConexao();
            command.CommandText = "INSERT INTO mecanicas(dono, modelo, cor, colaborador_responsabel, estatus, data_oracamento, valor_orcamento, valor_desconto, valor_total, data_finalizacao_servico) OUTPUT INSERTED.ID VALUES(@DONO, @MODELO, @COR, @COLABORADOR, @STATUS, @DATAORCAMENTO, @VALORORCAMENTO, @VALORDESCONTO, @VALORTOTAL, @DATASEVICO)";
            command.Parameters.AddWithValue("@DONO", cliente.Dono);
            command.Parameters.AddWithValue("@MODELO", cliente.Modelo);
            command.Parameters.AddWithValue("@COR", cliente.Cor);
            command.Parameters.AddWithValue("@COLABORADOR", cliente.ColaboradorResponsavel);
            command.Parameters.AddWithValue("@STATUS", cliente.Status);
            command.Parameters.AddWithValue("@DATAORCAMENTO", cliente.DataOrcamento);
            command.Parameters.AddWithValue("@VALORDESCONTO", cliente.ValorDesconto);
            command.Parameters.AddWithValue("@VALORORCAMENTO", cliente.ValorOrcamento);
            command.Parameters.AddWithValue("@VALORTOTAL", cliente.ValorTotal);
            command.Parameters.AddWithValue("@DATASEVICO", cliente.DataFinalizacaoServico);
            int id = Convert.ToInt32(command.ExecuteScalar().ToString());
            return id;
        }
        public bool Change(ClientesModel cliente)
        {
            SqlCommand command = new BancoDados().ObterConexao();
            command.CommandText = "UPDATE mecanicas SET id = @ID, dono = @DONO, modelo = @MODELO, cor = @COR, colaborador_responsavel = @COLABORADOR, estatus = @STATUS, data_orcamento =  @DATAORCAMENTO, valor_orcamento = @VALORORCAMENTO, valor_desconto = @VALORDESCONTO, valor_total = @VALORTOTAL, data_finalizacao_servico = @DATASEVICO";
            command.Parameters.AddWithValue("@ID", cliente.Id);
            command.Parameters.AddWithValue("@DONO", cliente.Dono);
            command.Parameters.AddWithValue("@MODELO", cliente.Modelo);
            command.Parameters.AddWithValue("@COR", cliente.Cor);
            command.Parameters.AddWithValue("@COLABORADOR", cliente.ColaboradorResponsavel);
            command.Parameters.AddWithValue("@STATUS", cliente.Status);
            command.Parameters.AddWithValue("@DATAORCAMENTO", cliente.DataOrcamento);
            command.Parameters.AddWithValue("@VALORORCAMENTO", cliente.ValorOrcamento);
            command.Parameters.AddWithValue("@VALORDESCONTO", cliente.ValorDesconto);
            command.Parameters.AddWithValue("@VALORTOTAL", cliente.ValorTotal);
            command.Parameters.AddWithValue("@DATASERVICO", cliente.DataFinalizacaoServico);

            return command.ExecuteNonQuery() == 1;

        }
        public bool Delete(int id)
        {
            SqlCommand command = new BancoDados().ObterConexao();
            command.CommandText = "DELETE FROM mecanicas WHERE id = @ID";
            command.Parameters.AddWithValue("@ID", id);

            return command.ExecuteNonQuery() == 1;
        }
        public ClientesModel GetForId(int id)
        {
            ClientesModel cliente = null;
            SqlCommand command = new BancoDados().ObterConexao();
            command.CommandText = "SELECT dono, modelo, cor, colaborador_responsabel, estatus, data_oracamento, valor_orcamento, valor_desconto, valor_total, data_finalizacao_servico FROM mecanicas WHERE id = @ID";
            command.Parameters.AddWithValue("@ID", id);
            DataTable table = new DataTable();
            table.Load(command.ExecuteReader());

            if (table.Rows.Count == 1)
            {
                cliente = new ClientesModel();
                cliente.Id = id;
                cliente.Dono = table.Rows[0][0].ToString();
                cliente.Modelo = table.Rows[0][1].ToString();
                cliente.Cor = table.Rows[0][2].ToString();
                cliente.ColaboradorResponsavel = table.Rows[0][3].ToString();
                cliente.Status = table.Rows[0][4].ToString();
                cliente.DataOrcamento = Convert.ToDateTime(table.Rows[0][5].ToString());
                cliente.ValorOrcamento = Convert.ToDouble(table.Rows[0][6].ToString());
                cliente.ValorDesconto = Convert.ToDouble(table.Rows[0][7].ToString());
                cliente.ValorTotal = Convert.ToDouble(table.Rows[0][8].ToString());
                cliente.DataFinalizacaoServico = Convert.ToDateTime(table.Rows[0][9].ToString());
            }


            return cliente;



        }
    }
}