using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;


namespace Mercadinho.DAO
{
    class ProdutoDAO
    {
        private Model.Produto prdutomodel;
        private MySqlConnection con;
        private Conexao.Conexao conexao;

        public ProdutoDAO()
        {

        }

        public void InserirDados(String Nome, Decimal PrecoCompra, Decimal PrecoVenda, int QuantidadeEstoque, DateTime DataVencimento, int IdCategoria)
        {
            con = new MySqlConnection();
            prdutomodel = new Model.Produto();
            conexao = new Conexao.Conexao();
            con.ConnectionString = conexao.getConnectionString();
            String query = "INSERT INTO produto(Nome, Preco_Compra, Preco_Venda, Quantidade_Estoque, Data_Vencimento, IdTipo)";

            query += " VALUES (?Nome, ?Preco_Compra, ?Preco_Venda, ?Quantidade_Estoque, ?Data_Vencimento, ?IdTipo)";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?Nome", Nome);
                cmd.Parameters.AddWithValue("?Preco_Compra", PrecoCompra);
                cmd.Parameters.AddWithValue("?Preco_Venda", PrecoVenda);
                cmd.Parameters.AddWithValue("?Quantidade_Estoque", QuantidadeEstoque);
                cmd.Parameters.AddWithValue("?Data_Vencimento", DataVencimento.Date);
                cmd.Parameters.AddWithValue("?IdTipo", IdCategoria);

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

        public void AtualizarDadosProduto(String Nome, Decimal PrecoCompra, Decimal PrecoVenda, int QuantidadeEstoque, DateTime DataVencimento, int IdCategoria, int CodigoBarras)
        {
            con = new MySqlConnection();
            conexao = new Conexao.Conexao();
            con.ConnectionString = conexao.getConnectionString();
            String query = "UPDATE produto SET Nome = ?Nome, Data_Vencimento = ?Data_Vencimento, Preco_Compra = ?Preco_Compra, Preco_Venda = ?Preco_Venda, Quantidade_Estoque = ?Quantidade_Estoque, IdTipo = ?IdTipo WHERE Codigo_Barras = ?Codigo_Barras";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?Nome", Nome);
                cmd.Parameters.AddWithValue("?Data_vencimento", DataVencimento.Date);
                cmd.Parameters.AddWithValue("?Preco_Compra", PrecoCompra);
                cmd.Parameters.AddWithValue("?Preco_Venda", PrecoVenda);
                cmd.Parameters.AddWithValue("?Quantidade_Estoque", QuantidadeEstoque);
                cmd.Parameters.AddWithValue("?IdTipo", IdCategoria);
                cmd.Parameters.AddWithValue("?Codigo_Barras", CodigoBarras);

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

            public void RemoverDadosProduto(Int32 CodigoBarras)
            {
                con = new MySqlConnection();
                conexao = new Conexao.Conexao();
                con.ConnectionString = conexao.getConnectionString();
                String query = "DELETE FROM produto where Codigo_Barras = ?Codigo_Barras";
                try
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("?Codigo_Barras", CodigoBarras);
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
