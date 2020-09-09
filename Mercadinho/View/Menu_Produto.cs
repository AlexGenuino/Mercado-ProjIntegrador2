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
    public partial class Menu_Produto : Form
    {
        public Menu_Produto()
        {
            InitializeComponent();
        }

        private void btnCliente_Produto_Click(object sender, EventArgs e)
        {
            View.Menu_Cliente menu = new View.Menu_Cliente();
            menu.Visible = true;
            this.Visible = false;
        }

        private void btnProduto_Produto_Click(object sender, EventArgs e)
        {
            View.Menu_Produto menu = new View.Menu_Produto();
            menu.Visible = true;
            this.Visible = false;
        }

        private void btnServico_Produto_Click(object sender, EventArgs e)
        {
            Cadastro_Servico servico = new Cadastro_Servico();
            servico.Visible = true;
            this.Visible = false;
        }

        private void btnTP_Produto_Click(object sender, EventArgs e)
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

        private void btnRelatorio_Produto_Click(object sender, EventArgs e)
        {
            View.Menu_Relatorios menu = new View.Menu_Relatorios();
            menu.Visible = true;
            this.Visible = false;
        }

        private void btnSair_Produto_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnNovoProduto_Produto_Click(object sender, EventArgs e)
        {
            Cadastro_Produtos novoproduto = new Cadastro_Produtos();
            novoproduto.Visible = true;
            this.Visible = false;
        }

        private void btnBuscarProduto_Produto_Click(object sender, EventArgs e)
        {
            Produtos consultaprodutos = new Produtos();
            consultaprodutos.Visible = true;
            this.Visible = false;
        }

        private void btnEditarProduto_Produto_Click(object sender, EventArgs e)
        {
            Produtos consultaprodutos = new Produtos();
            consultaprodutos.Visible = true;
            this.Visible = false;
        }

        private void btnExcluirProduto_Produto_Click(object sender, EventArgs e)
        {
            Produtos consultaprodutos = new Produtos();
            consultaprodutos.Visible = true;
            this.Visible = false;
        }
    }
}
