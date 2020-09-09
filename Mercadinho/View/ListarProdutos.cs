using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mercadinho.Model;
using MySql.Data.MySqlClient;

namespace Mercadinho.View
{
    public partial class ListarProdutos : Form
    {
        private Model.Produto produto;
        private Conexao.Conexao conexao;
        private Carrinho_Produtos carrinhoprodutos;

        public ListarProdutos(Carrinho_Produtos carrinhoprodutos)
        {
            InitializeComponent();
            carregarDados();
            this.carrinhoprodutos = carrinhoprodutos;
        }



        private void carregarDados()
        {
            conexao = new Conexao.Conexao();
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();

            string connectionString = conexao.getConnectionString();
            string query = "SELECT * FROM produto";

            using (MySqlConnection conn = new MySqlConnection(connectionString))


            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                {
                    try
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        for (int i = 0; i < dataTable.Rows.Count; i++)
                        {

                            dataGridView1.Rows.Add(dataTable.Rows[i][3], dataTable.Rows[i][0], dataTable.Rows[i][1], dataTable.Rows[i][4], dataTable.Rows[i][5], dataTable.Rows[i][6], dataTable.Rows[i][2]);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro: " + ex);
                    }
                }

            }


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Produto prod = new Produto();

            prod.Codigobarras = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[4].Value);
            prod.Nome = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            prod.Precovenda = Convert.ToDecimal(dataGridView1.Rows[e.RowIndex].Cells[2].Value);
            prod.Datavencimento = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells[6].Value);

            carrinhoprodutos.Listaprodutos.Add(prod);
            carrinhoprodutos.carregardados();
            carrinhoprodutos.SomarCarrinho();
        }

        private void btnVoltarRC_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
