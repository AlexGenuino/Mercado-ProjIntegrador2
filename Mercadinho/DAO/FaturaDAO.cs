using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mercadinho.DAO
{
    class FaturaDAO
    {

        private Model.Fatura faturamodel;
        private MySqlConnection con;
        private Conexao.Conexao conexao;

        public FaturaDAO()
        {


        }

        public void BaixarFatura(Model.Fatura fatura)
        {

            con = new MySqlConnection();
            conexao = new Conexao.Conexao();
            con.ConnectionString = conexao.getConnectionString();
            String query = "UPDATE fatura SET EstaPago = ?EstaPago, Data_Pagamento = ?Data_Pagamento WHERE Id_Fatura = ?Id_Fatura";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?EstaPago", fatura.Estapago);
                cmd.Parameters.AddWithValue("?Id_Fatura", fatura.Idfatura);
                cmd.Parameters.AddWithValue("?Data_Pagamento", fatura.DataPagamento1.Date);
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

    }
}
