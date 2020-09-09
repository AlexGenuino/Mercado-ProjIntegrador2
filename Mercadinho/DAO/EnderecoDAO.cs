using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;

namespace Mercadinho.DAO
{
    class EnderecoDAO
    {
        private Model.Endereco enderecomodel;
        private MySqlConnection con;
        private Conexao.Conexao conexao;

        public EnderecoDAO()
        {


        }
        public void InserirDados(String Bairro, String Cidade, String Numero, String Cep, String Rua, String Cpfcliente)
        {
            con = new MySqlConnection();
            enderecomodel = new Model.Endereco();
            conexao = new Conexao.Conexao();
            con.ConnectionString = conexao.getConnectionString();
            String query = "INSERT INTO endereco(Bairro, Cidade, Numero, Cep, Rua, CPF)";
            query += " VALUES (?Bairro, ?Cidade, ?Numero, ?Cep, ?Rua, ?CPF)";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);

                cmd.Parameters.AddWithValue("?Bairro", Bairro);
                cmd.Parameters.AddWithValue("?Cidade", Cidade);
                cmd.Parameters.AddWithValue("?Numero", Numero);
                cmd.Parameters.AddWithValue("?Cep", Cep);
                cmd.Parameters.AddWithValue("?Rua", Rua);
                cmd.Parameters.AddWithValue("?CPF", Cpfcliente);
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
        public void AtualizarDadosEndereco(String Bairro, String Cidade, String Numero, String Cep, String Rua, String Cpfcliente, int Id_Endereco)
        {
            con = new MySqlConnection();
            conexao = new Conexao.Conexao();
            con.ConnectionString = conexao.getConnectionString();
            String query = "UPDATE endereco SET Bairro = ?Bairro, Cidade = ?Cidade, Numero = ?Numero, CEP = ?CEP, Rua = ?Rua, CPF = ?CPF WHERE Id_Endereco = ?Id_Endereco";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?Bairro", Bairro);
                cmd.Parameters.AddWithValue("?Cidade", Cidade);
                cmd.Parameters.AddWithValue("?Numero", Numero);
                cmd.Parameters.AddWithValue("?CEP", Cep);
                cmd.Parameters.AddWithValue("?Rua", Rua);
                cmd.Parameters.AddWithValue("?CPF", Cpfcliente);
                cmd.Parameters.AddWithValue("?Id_Endereco", Id_Endereco);
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
            String query = "DELETE FROM endereco where CPF = ?CPF";
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

       
    




