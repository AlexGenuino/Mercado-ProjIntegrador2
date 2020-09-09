using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Mercadinho.DAO
{
    class ServicosDAO
    {
        private Model.Servicos servicosmodel;
        private MySqlConnection con;
        private Conexao.Conexao conexao;

        public ServicosDAO()
        {

        }

        public void InserirDados(Decimal Preco, String Descricao)
        {
            con = new MySqlConnection();
            servicosmodel = new Model.Servicos();
            conexao = new Conexao.Conexao();
            con.ConnectionString = conexao.getConnectionString();
            String query = "INSERT INTO servico(Preco, Descricao)";
            query += " VALUES (?Preco, ?Descricao)";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?Preco", Preco);
                cmd.Parameters.AddWithValue("?Descricao", Descricao);   
                cmd.ExecuteNonQuery();
                cmd.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex);
            }
            finally
            {
                con.Close();
            }
        }

        public void AtualizarDadosServico(Model.Servicos servico)
        {

            con = new MySqlConnection();
            conexao = new Conexao.Conexao();
            con.ConnectionString = conexao.getConnectionString();
            String query = "UPDATE servico SET Descricao = ?Nome, Preco = ?Preco WHERE Id_Servico = ?Id_Servico";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?Nome", servico.Descricao);
                cmd.Parameters.AddWithValue("?Preco", servico.Preco);
                cmd.Parameters.AddWithValue("?Id_Servico", servico.Idservico);

                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex);
            }
            finally
            {
                con.Close();
            }
        }

        public void RemoverDadosServico(Model.Servicos servico)
        {
            con = new MySqlConnection();
            conexao = new Conexao.Conexao();
            con.ConnectionString = conexao.getConnectionString();
            String query = "DELETE FROM servico where Id_Servico = ?Id_Servico";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?Id_Servico", servico.Idservico);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            finally
            {
                con.Close();
            }
        }
    }


}

    

