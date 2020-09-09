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
    public partial class Clientes : Form
    {
        private Model.Cliente cliente;
        private Model.Endereco endereco;
        private DAO.ClienteDAO clienteDAO;
        private DAO.EnderecoDAO enderecoDAO;
        private Conexao.Conexao conexao;
        private Int32 catchRowIndex;
        public Clientes()
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
                            
                            dataGridView1.Rows.Add(dataTable.Rows[i][4], dataTable.Rows[i][3], dataTable.Rows[i][2], dataTable.Rows[i][1], dataTable.Rows[i][0], dataTable.Rows[i][5], dataTable.Rows[i][6], dataTable.Rows[i][7], dataTable.Rows[i][8], dataTable.Rows[i][9], dataTable.Rows[i][10]);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro: " + ex);
                    }
                }

            }


        }

        private void Cliente_Load(object sender, EventArgs e)
        {
            carregarDados();

        }
        private void NovoClienteButton_Click(object sender, EventArgs e)
        {
            
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void ExcluirClienteButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja excluir o cliente: " + NomeClienteTextBox.Text + "?", "Excluindo Cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                cliente = new Model.Cliente();
                endereco = new Model.Endereco();
                try
                {
                        cliente.CPF = CPFClienteTextBox.Text;
                        endereco.Cpfcliente = CPFClienteTextBox.Text;
                        endereco.DeletarCliente();
                        cliente.Deletar();
                        carregarDados();
                        Limpar();
                        MessageBox.Show("Dado Removido", "Banco de dados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Falha ao EXCLUIR cliente!\n" + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void EmailClienteLabel_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        public void Limpar()
        {
            NomeClienteTextBox.Clear();
            CPFClienteTextBox.Clear();
            TelefoneClienteTextBox.Clear();
            EmailClienteTextBox.Clear();
            DataClienteTextBox.Clear();
            BairroClienteTextBox.Clear();
            RuaClienteTextBox.Clear();
            CidadeClienteTextBox.Clear();
            CEPClienteTextBox.Clear();
            NumeroClienteTextBox.Clear();
            

        }

        private void AlterarClienteButton_Click(object sender, EventArgs e)
        {
            endereco = new Model.Endereco();
            cliente = new Model.Cliente();
            try
            {
                cliente.Nome = NomeClienteTextBox.Text;
                cliente.CPF = CPFClienteTextBox.Text;
                cliente.Contato = TelefoneClienteTextBox.Text;
                cliente.Email = EmailClienteTextBox.Text;
                cliente.DataNascimento = Convert.ToDateTime(DataClienteTextBox.Text);
                endereco.Cpfcliente = CPFClienteTextBox.Text;
                endereco.Bairro = BairroClienteTextBox.Text;
                endereco.Rua = RuaClienteTextBox.Text;
                endereco.Cidade = CidadeClienteTextBox.Text;
                endereco.Cep = CEPClienteTextBox.Text;
                endereco.Numero = NumeroClienteTextBox.Text;
                endereco.Idendereco = Convert.ToInt32(numeroendereco.Text);
                endereco.Atualizar();
                cliente.Atualizar();
                carregarDados();
                Limpar();

                MessageBox.Show("Dados Atualizados", "Banco de dados", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao editar dados", "Banco de dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            catchRowIndex = dataGridView1.SelectedCells[0].RowIndex;
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                NomeClienteTextBox.Text = row.Cells[0].Value.ToString();
                CPFClienteTextBox.Text = row.Cells[1].Value.ToString();
                DataClienteTextBox.Text = row.Cells[2].Value.ToString();
                EmailClienteTextBox.Text = row.Cells[3].Value.ToString();
                TelefoneClienteTextBox.Text = row.Cells[4].Value.ToString();
                BairroClienteTextBox.Text = row.Cells[5].Value.ToString();
                CidadeClienteTextBox.Text = row.Cells[6].Value.ToString();
                RuaClienteTextBox.Text = row.Cells[7].Value.ToString();
                CEPClienteTextBox.Text = row.Cells[8].Value.ToString();
                NumeroClienteTextBox.Text = row.Cells[9].Value.ToString();
                numeroendereco.Text = row.Cells[10].Value.ToString();




            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void numeroendereco_Click(object sender, EventArgs e)
        {

        }

        private void Clientes_Load(object sender, EventArgs e)
        {

        }

        private void btnCliente_ConsCliente_Click(object sender, EventArgs e)
        {
            View.Menu_Cliente menu = new View.Menu_Cliente();
            menu.Visible = true;
            this.Visible = false;
        }

        private void btnProduto_ConsCliente_Click(object sender, EventArgs e)
        {
            View.Menu_Produto menu = new View.Menu_Produto();
            menu.Visible = true;
            this.Visible = false;
        }

        private void btnServico_ConsCliente_Click(object sender, EventArgs e)
        {
            Cadastro_Servico servico = new Cadastro_Servico();
            servico.Visible = true;
            this.Visible = false;
        }

        private void btnTP_ConsCliente_Click(object sender, EventArgs e)
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

        private void btnRelatorio_ConsCliente_Click(object sender, EventArgs e)
        {
            View.Menu_Relatorios menu = new View.Menu_Relatorios();
            menu.Visible = true;
            this.Visible = false;
        }

        private void btnSair_ConsCliente_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DataClienteTextBox_Click(object sender, EventArgs e)
        {
            DataClienteTextBox.Clear();
        }

        private void CPFClienteTextBox_Click(object sender, EventArgs e)
        {
            CPFClienteTextBox.Clear();
        }

        private void TelefoneClienteTextBox_Click(object sender, EventArgs e)
        {
            TelefoneClienteTextBox.Clear();
        }

        private void CEPClienteTextBox_Click(object sender, EventArgs e)
        {
            CEPClienteTextBox.Clear();
        }
    }
}
