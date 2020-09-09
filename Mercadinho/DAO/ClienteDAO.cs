using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Mercadinho.DAO
{
    class ClienteDAO
    {

        private Model.Cliente clientemodel;
        private MySqlConnection con;
        private Conexao.Conexao conexao;

        public ClienteDAO()
        {

        }

        public void InserirDados(String Nome, DateTime DataNascimento, String CPF, String Email, String Contato)
        {
            con = new MySqlConnection();
            clientemodel = new Model.Cliente();
            conexao = new Conexao.Conexao();
            con.ConnectionString = conexao.getConnectionString();
            String query = "INSERT INTO cliente(Nome, Data_Nascimento, CPF, Email, Contato)";
            query += " VALUES (?Nome, ?DataNascimento, ?CPF, ?Email, ?Contato)";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?Nome", Nome);
                cmd.Parameters.AddWithValue("?DataNascimento", DataNascimento.Date);
                cmd.Parameters.AddWithValue("?CPF", CPF);
                cmd.Parameters.AddWithValue("?Email", Email);
                cmd.Parameters.AddWithValue("?Contato", Contato);
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

        public void AtualizarDadosCliente(String Nome, DateTime DataNascimento, String CPF, String Email, String Contato)
        {
            con = new MySqlConnection();
            conexao = new Conexao.Conexao();
            con.ConnectionString = conexao.getConnectionString();
            String query = "UPDATE cliente SET Nome = ?Nome, Data_Nascimento = ?Data_Nascimento, Email = ?Email, Contato = ?Contato WHERE CPF = ?CPF";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?Nome", Nome);
                cmd.Parameters.AddWithValue("?Data_Nascimento", DataNascimento.Date);
                cmd.Parameters.AddWithValue("?Email", Email);
                cmd.Parameters.AddWithValue("?Contato", Contato);
                cmd.Parameters.AddWithValue("?CPF", CPF);
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
        public void RemoverDadosCliente(String CPF)
        {
            con = new MySqlConnection();
            conexao = new Conexao.Conexao();
            con.ConnectionString = conexao.getConnectionString();
            String query = "DELETE FROM cliente where CPF = ?CPF";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?CPF", CPF);
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
