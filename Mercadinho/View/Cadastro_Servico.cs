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

namespace Mercadinho
{
    public partial class Cadastro_Servico : Form
    {
        private Model.Servicos modelservicos;
        private Conexao.Conexao conexao;
        private int catchRowIndex;

        public Cadastro_Servico()
        {
            InitializeComponent();
            carregarDados();
        }

        private void Limpar()
        {
            txtprecoservico.Clear();
            txtdescricaoservico.ResetText();
        }

        private void carregarDados()
        {
            conexao = new Conexao.Conexao();
            dataGridViewservios.DataSource = null;
            dataGridViewservios.Rows.Clear();
            dataGridViewservios.Refresh();

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

                            dataGridViewservios.Rows.Add(dataTable.Rows[i][0], dataTable.Rows[i][1], dataTable.Rows[i][2]);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro: " + ex);
                    }
                }

            }


        }

        private void PrecoCadServicoTextBox_TextChanged(object sender, EventArgs e)
        {

        }


        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void GravarCadServicoButton_Click(object sender, EventArgs e)
        {
            try
            {

                modelservicos = new Model.Servicos();
                modelservicos.Descricao = txtdescricaoservico.Text;
                modelservicos.Preco = Convert.ToDecimal(txtprecoservico.Text);

                modelservicos.InserirDados();
                carregarDados();
                




                MessageBox.Show("Serviço Cadastrado!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex);
            }
            finally
            {
                
            }
            
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewservios_CellClick(object sender, DataGridViewCellEventArgs e)
        {


            catchRowIndex = dataGridViewservios.SelectedCells[0].RowIndex;
            foreach (DataGridViewRow row in dataGridViewservios.SelectedRows)
            {
                txtdescricaoservico.Text = row.Cells[2].Value.ToString();
                txtprecoservico.Text = row.Cells[0].Value.ToString();
                idserv.Text = row.Cells[1].Value.ToString();

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try {
                modelservicos = new Model.Servicos();
                modelservicos.Descricao = txtdescricaoservico.Text;
                modelservicos.Preco = Convert.ToDecimal(txtprecoservico.Text);
                modelservicos.Idservico = Convert.ToInt32(idserv.Text);
                modelservicos.AtualizarDados();

                MessageBox.Show("Serviço Atualizado!", "Banco de dados", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao editar dados", "Banco de dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void CancelarCadServicoButton_Click(object sender, EventArgs e)
        {

            try {
                modelservicos = new Model.Servicos();
                modelservicos.Descricao = txtdescricaoservico.Text;
                modelservicos.Preco = Convert.ToDecimal(txtprecoservico.Text);
                modelservicos.Idservico = Convert.ToInt32(idserv.Text);
                modelservicos.Excluir();
                carregarDados();
                Limpar();

                MessageBox.Show("Serviço Excluido!", "Banco de dados", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao editar dados", "Banco de dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCad_CadServico_Click(object sender, EventArgs e)
        {
            View.Menu_Cliente menu = new View.Menu_Cliente();
            menu.Visible = true;
            this.Visible = false;
        }

        private void btnProduto_CadServico_Click(object sender, EventArgs e)
        {
            View.Menu_Produto menu = new View.Menu_Produto();
            menu.Visible = true;
            this.Visible = false;
        }

        private void btnServ_CadServico_Click(object sender, EventArgs e)
        {
            Cadastro_Servico servico = new Cadastro_Servico();
            servico.Visible = true;
            this.Visible = false;
        }

        private void btnTipo_CadServico_Click(object sender, EventArgs e)
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

        private void btnRelatorio_CadServico_Click(object sender, EventArgs e)
        {
            View.Menu_Relatorios menu = new View.Menu_Relatorios();
            menu.Visible = true;
            this.Visible = false;
        }

        private void btnSair_CadServico_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtprecoservico_Click(object sender, EventArgs e)
        {
            txtprecoservico.Clear();
        }
    }
   
    
}




