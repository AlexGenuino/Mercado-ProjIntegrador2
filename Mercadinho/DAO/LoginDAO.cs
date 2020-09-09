using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Mercadinho.DAO
{
    class LoginDAO
    {
        private Model.Login loginv;
        private MySqlConnection con;
        private Conexao.Conexao conexao;
        private Menu menu;

        public void VerificaLogin(String email, String senha)
        {
            con = new MySqlConnection();
            loginv = new Model.Login();
            conexao = new Conexao.Conexao();
            con.ConnectionString = conexao.getConnectionString();
            String query = "SELECT Nome, Permissao, Senha FROM login WHERE Nome = ?Nome and Senha = ?Senha";

            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?Nome", email);
                cmd.Parameters.AddWithValue("?Senha", senha);
                cmd.Dispose();

                MySqlDataReader mysqlDT = cmd.ExecuteReader();

                
                if (mysqlDT.Read())
                {

                    string Permissao = mysqlDT["Permissao"].ToString();
                    string Usuario = mysqlDT["Nome"].ToString();
                    
                    
                    MessageBox.Show("Welcome  " + Usuario);
                    

                    if (Permissao.Equals("Total"))
                    {

                        menu = new Menu();
                        menu.ShowDialog();  

                    }
                    else if (Permissao.Equals("Vendedor"))
                    {
                       menu = new Menu();
                        menu.btnCadastrarproduto.Enabled = false;
                        menu.btnCadastrarservico.Enabled = false;
                        menu.btnRelatorio.Enabled = false;
                        menu.btncadastrartipo.Enabled = false;
                        menu.ShowDialog();
                        
                        
                    }
                    else
                    {
                        MessageBox.Show("Usuario ou senha incorreto");
                    }
                    
                }
            }

            finally
            {
                
                con.Close();
            }
        }

    }
}
