using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Mercadinho.DAO
{
    class TipoProdutoDAO
    {
        private Model.TipoProduto tipoprodutomodel;
        private MySqlConnection con;
        private Conexao.Conexao conexao;

        public TipoProdutoDAO()
        {

        }

        public void InserirDados(String tipoproduto)
        {
            con = new MySqlConnection();
            tipoprodutomodel = new Model.TipoProduto();
            conexao = new Conexao.Conexao();
            con.ConnectionString = conexao.getConnectionString();
            String query = "INSERT INTO tipoproduto(TipoProduto)";
            query += " VALUES (?tipoproduto)";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?tipoproduto", tipoproduto);
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

        public void AtualizarDadosTipo(String Nome, int idTipoProduto)
        {

            con = new MySqlConnection();
            conexao = new Conexao.Conexao();
            con.ConnectionString = conexao.getConnectionString();
            String query = "UPDATE tipoproduto SET TipoProduto = ?Nome WHERE IdTipo = ?IdTipo";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?Nome", Nome);
                cmd.Parameters.AddWithValue("?IdTipo", idTipoProduto);

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

            public void RemoverDadosTipo(Int32 IdTipo)
            {
                con = new MySqlConnection();
                conexao = new Conexao.Conexao();
                con.ConnectionString = conexao.getConnectionString();
                String query = "DELETE FROM tipoproduto where IdTipo = ?IdTipo";
                try
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("?IdTipo", IdTipo);
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





