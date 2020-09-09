using Mercadinho.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mercadinho.DAO
{
    class CarrinhoProdutoDAO
    {
        private Model.CarrinhoProdutos carrinhoprodutos;
        private MySqlConnection con;
        private Conexao.Conexao conexao;
        private List<Model.Produto> listadeprodutos;
        private List<Model.Fatura> faturas;

        public CarrinhoProdutoDAO()
        {
            listadeprodutos = new List<Produto>();
            Faturas = new List<Fatura>();
        }

        internal List<Produto> Listadeprodutos { get => listadeprodutos; set => listadeprodutos = value; }
        internal List<Fatura> Faturas { get => faturas; set => faturas = value; }
        //METODO PARA INSERIR DADOS DO OBJETOCARRINHOPRODUTO PARA O MYSQL
        public void InserirDadosCarrinho(CarrinhoProdutos carrinho)
        {
            con = new MySqlConnection();
            carrinhoprodutos = new Model.CarrinhoProdutos();
            conexao = new Conexao.Conexao();
            con.ConnectionString = conexao.getConnectionString();
            String query = "INSERT INTO carrinho(TotalCarrinho, CPF)";
            query += " VALUES (?TotalCarrinho, ?CPF);SELECT LAST_INSERT_ID() as id;";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?TotalCarrinho", carrinho.calcularcarrinho());
                cmd.Parameters.AddWithValue("?CPF", carrinho.Cliente.CPF);
                MySqlDataReader reader =  cmd.ExecuteReader();
                var idcarrinho = 0;
                while (reader.Read())
                {
                    idcarrinho = reader.GetInt32("id");//PEGAR O ULTIMO ID INSERIDO NO BANCO DO CARRINHO
                }

                cmd.Dispose();
                reader.Close();
                //INSERINDO DADOS NA TABELA CARRINHO PRODUTOS - ARMAZENEI O ULTIMO ID DO CARRINHO INSERIDO NA VARIAVEL idcarrinho
                foreach (Produto prod in carrinho.Produtos1)
                {
                    String query2 = "INSERT INTO carrinho_produtos(Id_Carrinho, Codigo_Barras)" +
                        " VALUES (?idCarrinho, ?Codigo_Barras);";
                    String query4 = "UPDATE produto SET Quantidade_estoque = Quantidade_estoque-1 WHERE Codigo_Barras = ?Codigo_Barras";
                    MySqlCommand cmd2 = new MySqlCommand(query2, con);
                    MySqlCommand cmd4 = new MySqlCommand(query4, con);
                    cmd4.Parameters.AddWithValue("?Codigo_Barras", prod.Codigobarras);
                    cmd2.Parameters.AddWithValue("?idCarrinho", idcarrinho);
                    cmd2.Parameters.AddWithValue("?Codigo_Barras", prod.Codigobarras);
                    cmd4.ExecuteNonQuery();
                    cmd2.ExecuteNonQuery();
                    cmd4.Dispose();
                    cmd2.Dispose();
                }

                // inserindo dados na fatura gerada usando tbm como base o ultimo id do carrinho inserido armazenado na variavel idcarrinho
                foreach (Fatura fat in carrinho.Parcelas)
                {
                    String query3 = "INSERT INTO fatura(Valor_Total, Data_Vencimento, FormaPagamento, EstaPago, Id_Carrinho, Data_Pagamento)" +
                        " VALUES (?Valor_Total, ?Data_Vencimento, ?FormaPagamento, ?EstaPago, ?Id_Carrinho, ?Data_Pagamento);";
                    MySqlCommand cmd3 = new MySqlCommand(query3, con);
                    cmd3.Parameters.AddWithValue("?Valor_Total", fat.Valorfatura);
                    cmd3.Parameters.AddWithValue("?Data_Vencimento", fat.DataVencimento1.Date);
                    cmd3.Parameters.AddWithValue("?FormaPagamento", fat.Formadepagamento);
                    cmd3.Parameters.AddWithValue("?EstaPago", fat.Estapago);
                    cmd3.Parameters.AddWithValue("?Id_Carrinho", idcarrinho);
                    cmd3.Parameters.AddWithValue("?Data_Pagamento", fat.DataPagamento1.Date);
                    cmd3.ExecuteNonQuery();
                    cmd3.Dispose();
                }


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

       
    }          
}

    






    

