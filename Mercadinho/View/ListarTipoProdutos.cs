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
    public partial class ListarTipoProdutos : Form
    {
        private Model.TipoProduto modeltipoproduto;
        private TipoProduto novoproduto;

        private DAO.TipoProdutoDAO tipoprodutoDAO;
        private Conexao.Conexao conexao;
        private Int32 catchRowIndex;
        private Cadastro_Produtos form;
        
        internal TipoProduto Novoproduto { get => novoproduto; set => novoproduto = value; }

        

        public ListarTipoProdutos(Cadastro_Produtos form)
        {
            InitializeComponent();
            carregarDados();
            this.form = form;

            
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



        private void ListarTipoProdutos_Load(object sender, EventArgs e)
        {

        }

        private void dataGridViewtipoproduto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            catchRowIndex = dataGridViewtipoproduto.SelectedCells[0].RowIndex;
            foreach (DataGridViewRow row in dataGridViewtipoproduto.SelectedRows)
            {
                novoproduto.Idtipoproduto =Convert.ToInt32( row.Cells[0].Value.ToString());
                novoproduto.Tipoproduto = row.Cells[1].Value.ToString();
                form.preencheTxt();
                this.Visible = false;

            }



        }

        private void btnVoltarRC_Click(object sender, EventArgs e)
        {
            Cadastro_Produtos cadastrar = new Cadastro_Produtos();
            cadastrar.Visible = true;
            this.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
