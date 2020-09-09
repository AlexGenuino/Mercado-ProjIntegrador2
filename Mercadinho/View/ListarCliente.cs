using Mercadinho.Model;
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
    public partial class ListarCliente : Form
    {
        private Conexao.Conexao conexao;
        private Int32 catchRowIndex;
        private Carrinho_Produtos form;
        private Cliente selecionarcliente;
       

        public ListarCliente(Carrinho_Produtos form)
        {
            InitializeComponent();
            carregarDados();
            this.form = form;
            
        }

        internal Cliente Selecionarcliente { get => selecionarcliente; set => selecionarcliente = value; }

        private void carregarDados()
        {
            conexao = new Conexao.Conexao();
            dataGridView1listarcliente.DataSource = null;
            dataGridView1listarcliente.Rows.Clear();
            dataGridView1listarcliente.Refresh();

            string connectionString = conexao.getConnectionString();
            string query = "SELECT a.Contato,a.Email, a.Data_Nascimento, a.CPF, a.Nome, b.Bairro, b.Cidade, b.Rua, b.CEP, b.Numero, b.Id_Endereco, b.CPF from cliente a\n" +
"\n" + "INNER JOIN endereco b ON b.CPF = a.CPF";

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

                            dataGridView1listarcliente.Rows.Add(dataTable.Rows[i][4], dataTable.Rows[i][3], dataTable.Rows[i][2], dataTable.Rows[i][1], dataTable.Rows[i][0], dataTable.Rows[i][5], dataTable.Rows[i][6], dataTable.Rows[i][7], dataTable.Rows[i][8], dataTable.Rows[i][9], dataTable.Rows[i][10]);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro: " + ex);
                    }
                }

            }


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            catchRowIndex = dataGridView1listarcliente.SelectedCells[0].RowIndex;
            foreach (DataGridViewRow row in dataGridView1listarcliente.SelectedRows)
            {
                selecionarcliente = new Cliente();
                selecionarcliente.Nome = row.Cells[0].Value.ToString();
                selecionarcliente.CPF = row.Cells[1].Value.ToString();
                form.Selecionarcliente = selecionarcliente;
                form.preencheTxt();
                this.Visible = false;

            }
        }
    }
}
