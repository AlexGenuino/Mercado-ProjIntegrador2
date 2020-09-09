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
    public partial class Relatorio_Produtos : Form
    {
        private Conexao.Conexao conexao;

        public Relatorio_Produtos()
        {
            InitializeComponent();
            carregarDados();
        }

        private void btnVoltarRP_Click(object sender, EventArgs e)
        {
            View.Menu_Relatorios relatorio = new Menu_Relatorios();
            relatorio.Visible = true;
            this.Visible = false;
        }

        private void btnSalvarRP_Click(object sender, EventArgs e)
        {

            DGVPrinter print = new DGVPrinter();
            print.Title = "RELATÓRIO DE PRODUTOS\n\n";
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
        private void carregarDados()
        {
            conexao = new Conexao.Conexao();
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();

            string connectionString = conexao.getConnectionString();
            string query = "SELECT Codigo_Barras, Nome, Preco_Compra, Preco_Venda, Quantidade_estoque, Quantidade_estoque * Preco_Venda from produto where Quantidade_estoque > 0";

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

                            dataGridView1.Rows.Add(dataTable.Rows[i][0], dataTable.Rows[i][1], dataTable.Rows[i][2], dataTable.Rows[i][3], dataTable.Rows[i][4], dataTable.Rows[i][5]);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro: " + ex);
                    }
                }

            }


        }
    }
}
