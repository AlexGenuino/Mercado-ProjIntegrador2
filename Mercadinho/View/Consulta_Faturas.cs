using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace Mercadinho.View
{
    public partial class Consulta_Faturas : Form
    {
        
        private Conexao.Conexao conexao;
        

        public Consulta_Faturas()
        {
            InitializeComponent();
            carregarDados();
            

        }

        DataTable dataTable;
        private int catchRowIndex;

        private void carregarDados()
        {
            conexao = new Conexao.Conexao();
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            string connectionString = conexao.getConnectionString();
            string query = "SELECT c.Id_Fatura,a.CPF, a.Nome, b.Id_Carrinho, c.Data_Vencimento, c.Data_Pagamento, c.EstaPago, c.Valor_Total from cliente a\n" +
"\n" + "INNER JOIN carrinho b ON b.CPF = a.CPF" + "\n" + "INNER JOIN fatura c on c.Id_Carrinho = b.Id_Carrinho";

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
                            dataGridView1.Rows.Add(dataTable.Rows[i][0], dataTable.Rows[i][1], dataTable.Rows[i][2], dataTable.Rows[i][3], dataTable.Rows[i][4], dataTable.Rows[i][5].ToString() == "01/01/0001 00:00:00" ? "Não pago" : dataTable.Rows[i][5], dataTable.Rows[i][6].ToString() == '1'.ToString() ? "Sim" : "Não", dataTable.Rows[i][7]);
                    }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro: " + ex);
                    }
                }
            }
        }

        private void carregaDadosByClienteName(string nomeCliente)
        {
            conexao = new Conexao.Conexao();
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            string connectionString = conexao.getConnectionString();
            string query = "SELECT c.Id_Fatura,a.CPF, a.Nome, b.Id_Carrinho, c.Data_Vencimento, c.Data_Pagamento, c.EstaPago, c.Valor_Total from cliente a " +
                 "INNER JOIN carrinho b ON b.CPF = a.CPF INNER JOIN fatura c on c.Id_Carrinho = b.Id_Carrinho where a.Nome like '%" + nomeCliente + "%';";

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
                            
                            
                            dataGridView1.Rows.Add(dataTable.Rows[i][0], dataTable.Rows[i][1], dataTable.Rows[i][2], dataTable.Rows[i][3], dataTable.Rows[i][4], dataTable.Rows[i][5].ToString()== "01/01/0001 00:00:00" ? "Não pago": dataTable.Rows[i][5], dataTable.Rows[i][6].ToString()=='1'.ToString()?"Sim":"Não", dataTable.Rows[i][7]);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro: " + ex);
                    }
                }
            }
        }


        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            carregaDadosByClienteName(textBox1.Text);
        }
    

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {

                Model.Fatura fatura = new Model.Fatura();
                fatura.Estapago = true;
                fatura.Idfatura = Convert.ToInt32(txtnumerofatura.Text);
                fatura.DataPagamento1 = Convert.ToDateTime(datapagamentotexbox.Text);
                fatura.BaixarFatura();
                carregarDados();

                MessageBox.Show("Fatura Baixada!", "Banco de dados", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao editar dados", "Banco de dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

}

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            catchRowIndex = dataGridView1.SelectedCells[0].RowIndex;
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                txtnumerodavenda.Text = row.Cells[3].Value.ToString();
                txtnomecliente.Text = row.Cells[2].Value.ToString();
                txtcpfcliente.Text = row.Cells[1].Value.ToString();
                txtpagamento.Text = row.Cells[5].Value.ToString();
                txtdatavencimento.Text = row.Cells[4].Value.ToString();

                txtnumerofatura.Text = row.Cells[0].Value.ToString();
            }
        }

        private void btnCliente_ConsFatura_Click(object sender, EventArgs e)
        {
            View.Menu_Cliente menu = new View.Menu_Cliente();
            menu.Visible = true;
            this.Visible = false;
        }

        private void btnProduto_ConsFatura_Click(object sender, EventArgs e)
        {
            View.Menu_Produto menu = new View.Menu_Produto();
            menu.Visible = true;
            this.Visible = false;

        }

        private void btnServico_ConsFatura_Click(object sender, EventArgs e)
        {
            Cadastro_Servico servico = new Cadastro_Servico();
            servico.Visible = true;
            this.Visible = false;
        }

        private void btnTP_ConsFatura_Click(object sender, EventArgs e)
        {
            View.CadastrarTipo novotipo = new View.CadastrarTipo();
            novotipo.Visible = true;
            this.Visible = false;
        }

        private void btnCarinho_Click(object sender, EventArgs e)
        {
            View.Menu_Carrinho menu = new View.Menu_Carrinho();
            menu.Visible = true;
            this.Visible = false;
        }

        private void btnRelatorio_ConsFatura_Click(object sender, EventArgs e)
        {
            View.Menu_Relatorios menu = new View.Menu_Relatorios();
            menu.Visible = true;
            this.Visible = false;
        }

        private void btnSair_ConsFatura_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
