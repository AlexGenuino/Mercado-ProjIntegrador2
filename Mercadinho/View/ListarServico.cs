using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mercadinho.View
{
    public partial class ListarServico : Form
    {
        private Conexao.Conexao conexao;
        private Carrinho_Servicos carrinhoservico;
        private Model.Servicos servico;
        public ListarServico(Carrinho_Servicos carrinhoservico)
        {
            InitializeComponent();
            this.carrinhoservico = carrinhoservico;
            carregarDados();
        }

        private void carregarDados()
        {
            conexao = new Conexao.Conexao();
            dataGridView1servicos.DataSource = null;
            dataGridView1servicos.Rows.Clear();
            dataGridView1servicos.Refresh();

            string connectionString = conexao.getConnectionString();
            string query = "SELECT * FROM servico";

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

                            dataGridView1servicos.Rows.Add(dataTable.Rows[i][0], dataTable.Rows[i][2], dataTable.Rows[i][1]);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro: " + ex);
                    }
                }

            }


        }

        private void dataGridView1servicos_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            servico = new Model.Servicos();

            
            servico.Preco = Convert.ToDecimal(dataGridView1servicos.Rows[e.RowIndex].Cells[0].Value);
            servico.Descricao = dataGridView1servicos.Rows[e.RowIndex].Cells[1].Value.ToString();
            servico.Idservico = Convert.ToInt32(dataGridView1servicos.Rows[e.RowIndex].Cells[2].Value);

            carrinhoservico.Listaservicos.Add(servico);
            carrinhoservico.carregardados();
            carrinhoservico.SomarCarrinho();



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
