using Mercadinho.Model;
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
    public partial class Cadastro_Produtos : Form
    {

        private Model.Produto modelproduto;
        private DAO.ProdutoDAO produtoDAO;
        private Conexao.Conexao conexao;
        private Int32 catchRowIndex;
        private TipoProduto tipoDoProduto;

        public Cadastro_Produtos()
        {
            InitializeComponent();
        }

        private void DataNascCadProdutoTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void CategoriaCadProdutoTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void GravarCadProdutoButton_Click(object sender, EventArgs e)
        {
            try
            {

                modelproduto = new Model.Produto();
                modelproduto.Nome = txtnomeproduto.Text;
                modelproduto.Quantidadeestoque = Convert.ToInt32(txtquantidade.Text);
                modelproduto.Idcategoria = tipoDoProduto.Idtipoproduto;
                modelproduto.Precocompra = Convert.ToDecimal(txtprecocompra.Text);
                modelproduto.Precovenda = Convert.ToDecimal(txtprecovenda.Text);
                modelproduto.Datavencimento = Convert.ToDateTime(txtdatavencimento.Text);


                modelproduto.InserirDados();




                MessageBox.Show("Produto Cadastrado!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex);
            }
            finally
            {

            }
        }

        private void CancelarCadProdutoButton_Click(object sender, EventArgs e)
        {
            
        }

        private void bttiposproduto_Click(object sender, EventArgs e)
        {
            View.ListarTipoProdutos listartipoprodutos = new View.ListarTipoProdutos(this);

            tipoDoProduto = new TipoProduto();

            listartipoprodutos.Novoproduto = tipoDoProduto;

            listartipoprodutos.Visible = true;
            this.Visible = true;

        }
        public void preencheTxt()
        {
            labelidtipo.Text = tipoDoProduto.Tipoproduto;
        }

        private void Cadastro_Produtos_Load(object sender, EventArgs e)
        {

        }

        private void btnCliente_CadProduto_Click(object sender, EventArgs e)
        {
            View.Menu_Cliente menu = new View.Menu_Cliente();
            menu.Visible = true;
            this.Visible = false;
        }

        private void btnProduto_CadProduto_Click(object sender, EventArgs e)
        {
            View.Menu_Produto menu = new View.Menu_Produto();
            menu.Visible = true;
            this.Visible = false;
        }

        private void btnServico_CadProduto_Click(object sender, EventArgs e)
        {
            Cadastro_Servico servico = new Cadastro_Servico();
            servico.Visible = true;
            this.Visible = false;
        }

        private void btnTP_CadProduto_Click(object sender, EventArgs e)
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

        private void btnRelatorio_CadProduto_Click(object sender, EventArgs e)
        {
            View.Menu_Relatorios menu = new View.Menu_Relatorios();
            menu.Visible = true;
            this.Visible = false;
        }

        private void btnSair_CadProduto_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtprecocompra_Click(object sender, EventArgs e)
        {
            txtprecocompra.Clear();
        }

        private void txtprecovenda_Click(object sender, EventArgs e)
        {
            txtprecovenda.Clear();
        }

        private void txtdatavencimento_Click(object sender, EventArgs e)
        {
            txtdatavencimento.Clear();
        }
    }
}
