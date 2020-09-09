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
    public partial class Menu_Carrinho : Form
    {
        public Menu_Carrinho()
        {
            InitializeComponent();
        }

        private void btnCliente_SelectCarrinho_Click(object sender, EventArgs e)
        {
            View.Menu_Cliente menu = new View.Menu_Cliente();
            menu.Visible = true;
            this.Visible = false;
        }

        private void btnProduto_SelectCarrinho_Click(object sender, EventArgs e)
        {
            View.Menu_Produto menu = new View.Menu_Produto();
            menu.Visible = true;
            this.Visible = false;
        }

        private void btnServico_SelectCarrinho_Click(object sender, EventArgs e)
        {
            Cadastro_Servico servico = new Cadastro_Servico();
            servico.Visible = true;
            this.Visible = false;
        }

        private void btnTP_SelectCarrinho_Click(object sender, EventArgs e)
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

        private void btnRelatorio_SelectCarrinho_Click(object sender, EventArgs e)
        {
            View.Menu_Relatorios menu = new View.Menu_Relatorios();
            menu.Visible = true;
            this.Visible = false;
        }

        private void btnSair_SelectCarrinho_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            View.Carrinho_Produtos carrinho = new View.Carrinho_Produtos();
            carrinho.Visible = true;
            this.Visible = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            View.Carrinho_Servicos carrinhoserv = new View.Carrinho_Servicos();
            carrinhoserv.Visible = true;
            this.Visible = false;
        }

        private void btnconsultarfatura_Click(object sender, EventArgs e)
        {
            View.Consulta_Faturas consultafaturas = new View.Consulta_Faturas();
            consultafaturas.Visible = true;
            this.Visible = false;
        }
    }
}
