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
    public partial class Menu_Relatorios : Form
    {
        public Menu_Relatorios()
        {
            InitializeComponent();
        }

        private void btnCliente_Relatorio_Click(object sender, EventArgs e)
        {
            View.Menu_Cliente menu = new View.Menu_Cliente();
            menu.Visible = true;
            this.Visible = false;
        }

        private void btnProduto_Relatorio_Click(object sender, EventArgs e)
        {
            View.Menu_Produto menu = new View.Menu_Produto();
            menu.Visible = true;
            this.Visible = false;
        }

        private void btnServico_Relatorio_Click(object sender, EventArgs e)
        {
            Cadastro_Servico servico = new Cadastro_Servico();
            servico.Visible = true;
            this.Visible = false;
        }

        private void btnTP_Relatorio_Click(object sender, EventArgs e)
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

        private void btnRelatorio_Relatorio_Click(object sender, EventArgs e)
        {
            View.Menu_Relatorios menu = new View.Menu_Relatorios();
            menu.Visible = true;
            this.Visible = false;
        }

        private void btnSair_Relatorio_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnClientes_Relatorio_Click(object sender, EventArgs e)
        {
            View.Relatorio_Cliente relatorio = new Relatorio_Cliente();
            relatorio.Visible = true;
            this.Visible = false;
        }

        private void btnProdutos_Relatorio_Click(object sender, EventArgs e)
        {
            View.Relatorio_Produtos relatorio = new Relatorio_Produtos();
            relatorio.Visible = true;
            this.Visible = false;
        }

        private void btnFatura_Relatorio_Click(object sender, EventArgs e)
        {
            View.Relatorio_Faturas relatorio = new Relatorio_Faturas();
            relatorio.Visible = true;
            this.Visible = false;
        }

        private void btnVencimento_Relatorio_Click(object sender, EventArgs e)
        {
            View.Relatorio_Vencimento relatorio = new Relatorio_Vencimento();
            relatorio.Visible = true;
            this.Visible = false;
        }
    }
}
