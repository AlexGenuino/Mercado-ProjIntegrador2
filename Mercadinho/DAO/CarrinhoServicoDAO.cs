using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mercadinho.DAO
{
    class CarrinhoServicoDAO
    {
        private Model.CarrinhoServico carrinhoservicos;
        private MySqlConnection con;
        private Conexao.Conexao conexao;
        private List<Model.Servicos> listadeservicos;
        private List<Model.Fatura> faturas;

        public CarrinhoServicoDAO()
        {
            listadeservicos = new List<Model.Servicos>();
            faturas = new List<Model.Fatura>();
        }

        internal List<Model.Servicos> Listadeservicos { get => listadeservicos; set => listadeservicos = value; }
        internal List<Model.Fatura> Faturas { get => faturas; set => faturas = value; }
        //metodo para inserir dados no carrinho
        public void InserirDadosCarrinho(Model.CarrinhoServico carrinho)
        {
            con = new MySqlConnection();
            carrinhoservicos = new Model.CarrinhoServico();
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
                MySqlDataReader reader = cmd.ExecuteReader();
                var idcarrinho = 0;
                while (reader.Read())
                {
                    idcarrinho = reader.GetInt32("id");
                }

                cmd.Dispose();
                reader.Close();

                foreach (Model.Servicos prod in carrinho.Servicos1)
                {
                    String query2 = "INSERT INTO carrinho_servico(Id_Carrinho, Id_Servico)" +
                        " VALUES (?idCarrinho, ?Id_Servico);";
                    MySqlCommand cmd2 = new MySqlCommand(query2, con);
                    cmd2.Parameters.AddWithValue("?idCarrinho", idcarrinho);
                    cmd2.Parameters.AddWithValue("?Id_Servico", prod.Idservico);
                    cmd2.ExecuteNonQuery();
                    cmd2.Dispose();
                }

                foreach (Model.Fatura fat in carrinho.Parcelas)
                {
                    String query3 = "INSERT INTO fatura(Valor_Total, Data_Vencimento,Data_Pagamento, FormaPagamento, EstaPago, Id_Carrinho)" +
                        " VALUES (?Valor_Total, ?Data_Vencimento,?Data_Pagamento, ?FormaPagamento, ?EstaPago, ?Id_Carrinho);";
                    MySqlCommand cmd3 = new MySqlCommand(query3, con);
                    cmd3.Parameters.AddWithValue("?Valor_Total", fat.Valorfatura);
                    cmd3.Parameters.AddWithValue("?Data_Vencimento", fat.DataVencimento1.Date);
                    cmd3.Parameters.AddWithValue("?Data_Pagamento", fat.DataPagamento1.Date);
                    cmd3.Parameters.AddWithValue("?FormaPagamento", fat.Formadepagamento);
                    cmd3.Parameters.AddWithValue("?EstaPago", fat.Estapago);
                    cmd3.Parameters.AddWithValue("?Id_Carrinho", idcarrinho);
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
