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
    public partial class Cadastro_Cliente : Form
    {
        private Model.Cliente modelcliente;
        private Model.Endereco modelendereco;
        private DAO.ClienteDAO clienteDAO;
        private DAO.EnderecoDAO enderecoDAO;
        private Conexao.Conexao conexao;
        private Int32 catchRowIndex;
        public Cadastro_Cliente()
        {
            InitializeComponent();
        }



        private void GravarCadProdutoButton_Click(object sender, EventArgs e)
        {

        }

        private void CodBarrasCadProdutoTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Cadastro_Cliente_Load(object sender, EventArgs e)
        {

        }
        
        



    private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                modelcliente = new Model.Cliente();
                modelendereco = new Model.Endereco();
                modelcliente.Nome = btnomecliente.Text;
                modelcliente.CPF = btcpfcliente.Text;
                modelcliente.DataNascimento = Convert.ToDateTime(btdatanascimentocliente.Text);
                modelcliente.Contato = btcontatocliente.Text;
                modelcliente.Email = btemailcliente.Text;
                modelendereco.Bairro = btbairrocliente.Text;
                modelendereco.Cidade = btcidadecliente.Text;
                modelendereco.Rua = btruacliente.Text;
                modelendereco.Cep = btcepcliente.Text;
                modelendereco.Numero = btnumerocliente.Text;
                modelendereco.Cpfcliente = btcpfcliente.Text;

                modelcliente.InserirDados();
                modelendereco.InserirDados();
               
                
                
                MessageBox.Show("Cliente Cadastrado!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex);
            }
            finally
            {

            }
        }

        private void btcpfcliente_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void btnCliente_CadCliente_Click(object sender, EventArgs e)
        {
            View.Menu_Cliente menu = new View.Menu_Cliente();
            menu.Visible = true;
            this.Visible = false;
        }

        private void btnProduto_CadCliente_Click(object sender, EventArgs e)
        {
            View.Menu_Produto menu = new View.Menu_Produto();
            menu.Visible = true;
            this.Visible = false;
        }

        private void btnServ_CadCliente_Click(object sender, EventArgs e)
        {
            Cadastro_Servico servico = new Cadastro_Servico();
            servico.Visible = true;
            this.Visible = false;
        }

        private void btnTP_CadCliente_Click(object sender, EventArgs e)
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

        private void btnRelatorio_CadCliente_Click(object sender, EventArgs e)
        {
            View.Menu_Relatorios menu = new View.Menu_Relatorios();
            menu.Visible = true;
            this.Visible = false;
        }

        private void btnSair_CadCliente_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btcpfcliente_Click(object sender, EventArgs e)
        {
            btcpfcliente.Clear();
        }

        private void btdatanascimentocliente_Click(object sender, EventArgs e)
        {
            btdatanascimentocliente.Clear();
        }

        private void btcontatocliente_Click(object sender, EventArgs e)
        {
            btcontatocliente.Clear();
        }

        private void btcepcliente_Click(object sender, EventArgs e)
        {
            btcepcliente.Clear();
        }

        private void btcpfcliente_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (e.KeyChar != 8))
            {

                e.Handled = true;
            }
        }
    }
}
