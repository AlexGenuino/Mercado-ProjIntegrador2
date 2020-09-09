using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Mercadinho
{
    public partial class Produtos : Form
    {
        private Model.Produto produto;
        private Conexao.Conexao conexao;
        private Int32 catchRowIndex;
        public Produtos()
        {
            InitializeComponent();
            carregarDados();
        }

        private void carregarDados()
        {
            conexao = new Conexao.Conexao();
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();

            string connectionString = conexao.getConnectionString();
            string query = "SELECT a.Nome,a.Preco_Compra, a.Preco_Venda, a.Data_Vencimento, a.Quantidade_estoque, a.Codigo_Barras, b.TipoProduto, a.IdTipo from produto a\n" +
"\n" + "INNER JOIN tipoproduto b ON b.IdTipo = a.IdTipo";

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

                            dataGridView1.Rows.Add(dataTable.Rows[i][0], dataTable.Rows[i][1], dataTable.Rows[i][2], dataTable.Rows[i][4], dataTable.Rows[i][5], dataTable.Rows[i][7], dataTable.Rows[i][6], dataTable.Rows[i][3]);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro: " + ex);
                    }
                }

            }


        }


        private void ExcluirProdutoButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja excluir este produto: " + NomeProdutoTextBox.Text + "?", "Excluindo Produto", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                produto = new Model.Produto();
                try
                {

                    produto.Codigobarras = Convert.ToInt32(CodigoBarrasProduto.Text);
                    produto.Deletar();
                    carregarDados();
                    Limpar();
                    MessageBox.Show("Produto Removido", "Banco de dados", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Falha ao excluir produto!\n" + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void CodBarrasProdutoLabel_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            catchRowIndex = dataGridView1.SelectedCells[0].RowIndex;
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {

                NomeProdutoTextBox.Text = row.Cells[0].Value.ToString();
                PreçoCompraProdutoTextBox.Text = row.Cells[1].Value.ToString();
                PreçoVendaProdutoTextBox.Text = row.Cells[2].Value.ToString();
                DataProdutoTextBox.Text = row.Cells[7].Value.ToString();
                QuantidadeProdutoTextBox.Text = row.Cells[3].Value.ToString();
                CodigoBarrasProduto.Text = row.Cells[4].Value.ToString();
                IdTipoProduto.Text = row.Cells[5].Value.ToString();
                


            }
        }

        public void Limpar()
        {
            NomeProdutoTextBox.Clear();
            PreçoCompraProdutoTextBox.Clear();
            PreçoVendaProdutoTextBox.Clear();
            QuantidadeProdutoTextBox.Clear();
            CodigoBarrasProduto.ResetText();
            DataProdutoTextBox.Clear();
            IdTipoProduto.ResetText();


        }

        private void AlterarProdutoButton_Click(object sender, EventArgs e)
        {
            produto = new Model.Produto();
            try
            {
                produto.Nome = NomeProdutoTextBox.Text;
                produto.Precocompra = Convert.ToDecimal(PreçoCompraProdutoTextBox.Text);
                produto.Precovenda = Convert.ToDecimal(PreçoVendaProdutoTextBox.Text);
                produto.Quantidadeestoque = Convert.ToInt32(QuantidadeProdutoTextBox.Text);
                produto.Codigobarras = Convert.ToInt32(CodigoBarrasProduto.Text);
                produto.Datavencimento = Convert.ToDateTime(DataProdutoTextBox.Text);
                produto.Idcategoria = Convert.ToInt32(IdTipoProduto.Text);
                produto.Atualizar();
                carregarDados();
                Limpar();

                MessageBox.Show("Produto Atualizado!", "Banco de dados", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao editar dados", "Banco de dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Produtos_Load(object sender, EventArgs e)
        {

        }

        private void btnCliente_ConsProduto_Click(object sender, EventArgs e)
        {
            View.Menu_Cliente menu = new View.Menu_Cliente();
            menu.Visible = true;
            this.Visible = false;
        }

        private void btnProduto_ConsProduto_Click(object sender, EventArgs e)
        {

            View.Menu_Produto menu = new View.Menu_Produto();
            menu.Visible = true;
            this.Visible = false;
        }

        private void btnServico_ConsProduto_Click(object sender, EventArgs e)
        {
            Cadastro_Servico servico = new Cadastro_Servico();
            servico.Visible = true;
            this.Visible = false;
        }

        private void btnTP_ConsProduto_Click(object sender, EventArgs e)
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

        private void btnRelatorio_ConsProduto_Click(object sender, EventArgs e)
        {
            View.Menu_Relatorios menu = new View.Menu_Relatorios();
            menu.Visible = true;
            this.Visible = false;
        }

        private void btnSair_ConsProduto_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DataProdutoTextBox_Click(object sender, EventArgs e)
        {
            DataProdutoTextBox.Clear();
        }

        private void PreçoCompraProdutoTextBox_Click(object sender, EventArgs e)
        {
            PreçoCompraProdutoTextBox.Clear();
        }

        private void PreçoVendaProdutoTextBox_Click(object sender, EventArgs e)
        {
            PreçoVendaProdutoTextBox.Clear();
        }
    }
}
