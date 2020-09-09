using DGVPrinterHelper;
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
    public partial class Relatorio_Cliente : Form
    {
        public Relatorio_Cliente()
        {
            InitializeComponent();
            carregaDados();
        }

        private void btnVoltarRC_Click(object sender, EventArgs e)
        {
            View.Menu_Relatorios menu = new View.Menu_Relatorios();
            menu.Visible = true;
            this.Visible = false;
        }
        DataTable dataTable;
        private Conexao.Conexao conexao;


        private void carregaDadosByClienteName(string nomeCliente)
        {
            conexao = new Conexao.Conexao();
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            string connectionString = conexao.getConnectionString();
            string query = "SELECT c.Id_Fatura,a.Nome, b.Id_Carrinho, c.Data_Vencimento,c.Data_Pagamento, c.EstaPago, y.Nome, y.Preco_Venda from cliente a " +
                 "INNER JOIN carrinho b ON b.CPF = a.CPF INNER JOIN fatura c on c.Id_Carrinho = b.Id_Carrinho INNER JOIN carrinho_produtos d on d.Id_Carrinho = b.Id_Carrinho inner JOIN produto y on y.Codigo_Barras = d.Codigo_Barras where a.Nome like '%" + nomeCliente + "%';";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                {
                    try
                    {
                        dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        for (int i = 0; i < dataTable.Rows.Count; i++)
                        {
                            dataGridView1.Rows.Add(dataTable.Rows[i][0], dataTable.Rows[i][1], dataTable.Rows[i][2], dataTable.Rows[i][3], dataTable.Rows[i][4].ToString() == "01/01/0001 00:00:00" ? "Não pago" : dataTable.Rows[i][4], dataTable.Rows[i][5].ToString() == '1'.ToString() ? "Sim" : "Não", dataTable.Rows[i][6], dataTable.Rows[i][7]);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro: " + ex);
                    }
                }
            }
        }
    


        private void carregaDados()
        {
            conexao = new Conexao.Conexao();
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            string connectionString = conexao.getConnectionString();
            string query = "SELECT c.Id_Fatura,a.Nome, b.Id_Carrinho, c.Data_Vencimento, c.Data_Pagamento, c.EstaPago, c.Valor_Total, y.Nome from cliente a " +
                 "INNER JOIN carrinho b ON b.CPF = a.CPF INNER JOIN fatura c on c.Id_Carrinho = b.Id_Carrinho INNER JOIN carrinho_produtos d on d.Id_Carrinho = b.Id_Carrinho inner JOIN produto y on y.Codigo_Barras = d.Codigo_Barras";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                {
                    try
                    {
                        dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        for (int i = 0; i < dataTable.Rows.Count; i++)
                        {
                            dataGridView1.Rows.Add(dataTable.Rows[i][0], dataTable.Rows[i][1], dataTable.Rows[i][2], dataTable.Rows[i][3], dataTable.Rows[i][4].ToString() == "01/01/0001 00:00:00" ? "Não pago" : dataTable.Rows[i][4], dataTable.Rows[i][5].ToString() == '1'.ToString() ? "Sim" : "Não", dataTable.Rows[i][6], dataTable.Rows[i][7]);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro: " + ex);
                    }
                }
            }
        }


        private void btnSalvarRC_Click(object sender, EventArgs e)
        {
            DGVPrinter print = new DGVPrinter();
            print.Title = "RELATÓRIO DE FATURAS\n\n";
            print.SubTitle = string.Format("DATA: {0}", DateTime.Now.Date.ToString("dd/MM/yyyy"));
            print.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            print.PageNumbers = true;
            print.PageNumberInHeader = false;
            print.PorportionalColumns = true;
            print.HeaderCellAlignment = StringAlignment.Center;
            print.Footer = "MercadLn";
            print.FooterSpacing = 15;
            print.PrintDataGridView(dataGridView1);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            carregaDadosByClienteName(textBox1.Text);
        }
    }
}
