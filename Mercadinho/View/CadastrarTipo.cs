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

namespace Mercadinho.View
{
    public partial class CadastrarTipo : Form
    {
        private Model.TipoProduto modeltipoproduto;
        private DAO.TipoProdutoDAO tipoprodutoDAO;
        private Conexao.Conexao conexao;
        private Int32 catchRowIndex;
        public CadastrarTipo()
        {
            InitializeComponent();
            carregarDados();
        }

        private void carregarDados()
        {
            conexao = new Conexao.Conexao();
            dataGridViewtipoproduto.DataSource = null;
            dataGridViewtipoproduto.Rows.Clear();
            dataGridViewtipoproduto.Refresh();

            string connectionString = conexao.getConnectionString();
            string query = "SELECT * FROM tipoproduto";

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

                            dataGridViewtipoproduto.Rows.Add(dataTable.Rows[i][1], dataTable.Rows[i][0]);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro: " + ex);
                    }
                }

            }


        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {

                modeltipoproduto = new Model.TipoProduto();
                modeltipoproduto.Tipoproduto = ftftipo.Text;

                modeltipoproduto.InserirDados();
                carregarDados();



                MessageBox.Show("Tipo Cadastrado!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex);
            }
            finally
            {

            }

        }

        private void dataGridViewtipoproduto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Limpar()
        {
            ftftipo.Clear();
            LabelidTipo.ResetText();
        }

        private void AlterarTipoProduto_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Alterar este Tipo: " + ftftipo.Text + "?", "ISSO PODE GERAR PROBLEMAS EM PRODUTOS!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {

                modeltipoproduto = new Model.TipoProduto();
                try
                {
                    modeltipoproduto.Tipoproduto = ftftipo.Text;
                    modeltipoproduto.Idtipoproduto = Convert.ToInt32(LabelidTipo.Text);
                    
                    modeltipoproduto.Atualizar();
                    carregarDados();
                    Limpar();

                    MessageBox.Show("Tipo Atualizado!", "Banco de dados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception)
                {
                    MessageBox.Show("Ocorreu um erro ao editar dados", "Banco de dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
        }

        private void ExcluirTipoProduto_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Para Excluir uma Categoria é necessário antes excluir todos os produtos vinculados! ", "*******ATENÇÃO*******", MessageBoxButtons.OK, MessageBoxIcon.Warning);


            if (MessageBox.Show("Deseja excluir o Tipo: " + ftftipo.Text + "?", "Excluindo Tipo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                modeltipoproduto = new Model.TipoProduto();
                try
                {
                    modeltipoproduto.Idtipoproduto = Convert.ToInt32(LabelidTipo.Text);
                    modeltipoproduto.Deletar();
                    carregarDados();
                    Limpar();
                    MessageBox.Show("Tipo Removido", "Banco de dados", MessageBoxButtons.OK, MessageBoxIcon.Information);



                }
                catch (Exception ex)
                {
                    MessageBox.Show("Falha ao EXCLUIR Tipo!\n" + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dataGridViewtipoproduto_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            catchRowIndex = dataGridViewtipoproduto.SelectedCells[0].RowIndex;
            foreach (DataGridViewRow row in dataGridViewtipoproduto.SelectedRows)
            {

                ftftipo.Text = row.Cells[1].Value.ToString();
                LabelidTipo.Text = row.Cells[0].Value.ToString();

            }
        }

        private void CadastrarTipo_Load(object sender, EventArgs e)
        {

        }

        private void ftftipo_Click(object sender, EventArgs e)
        {
            ftftipo.Clear();
        }

        private void btnCad_TP_Click(object sender, EventArgs e)
        {
            View.Menu_Cliente menu = new View.Menu_Cliente();
            menu.Visible = true;
            this.Visible = false;
        }

        private void btnProduto_TP_Click(object sender, EventArgs e)
        {
            View.Menu_Produto menu = new View.Menu_Produto();
            menu.Visible = true;
            this.Visible = false;
        }

        private void btnServ_TP_Click(object sender, EventArgs e)
        {
            Cadastro_Servico servico = new Cadastro_Servico();
            servico.Visible = true;
            this.Visible = false;
        }

        private void btnTipo_TP_Click(object sender, EventArgs e)
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

        private void btnRelatorio_TP_Click(object sender, EventArgs e)
        {
            View.Menu_Relatorios menu = new View.Menu_Relatorios();
            menu.Visible = true;
            this.Visible = false;
        }

        private void btnSair_TP_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
    
