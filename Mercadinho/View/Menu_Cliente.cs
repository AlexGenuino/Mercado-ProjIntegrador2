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
    public partial class Menu_Cliente : Form
    {
        public Menu_Cliente()
        {
            InitializeComponent();
        }

        private void btnCliente_Cliente_Click(object sender, EventArgs e)
        {
            View.Menu_Cliente menu = new View.Menu_Cliente();
            menu.Visible = true;
            this.Visible = false;
        }

        private void btnProduto_Cliente_Click(object sender, EventArgs e)
        {
            View.Menu_Produto menu = new View.Menu_Produto();
            menu.Visible = true;
            this.Visible = false;
        }

        private void btnServico_Cliente_Click(object sender, EventArgs e)
        {
            Cadastro_Servico servico = new Cadastro_Servico();
            servico.Visible = true;
            this.Visible = false;
        }

        private void btnTP_Cliente_Click(object sender, EventArgs e)
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

        private void btnRelatorio_Cliente_Click(object sender, EventArgs e)
        {
            View.Menu_Relatorios menu = new View.Menu_Relatorios();
            menu.Visible = true;
            this.Visible = false;
        }

        private void btnSair_Cliente_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnNovoCliente_Cliente_Click(object sender, EventArgs e)
        {
            Cadastro_Cliente cadcliente = new Cadastro_Cliente();
            cadcliente.Visible = true;
            this.Visible = false;
        }

        private void btnBuscarCliente_Cliente_Click(object sender, EventArgs e)
        {
            Clientes consultaclientes = new Clientes();
            consultaclientes.Visible = true;
            this.Visible = false;
        }

        private void btnEditarCliente_Cliente_Click(object sender, EventArgs e)
        {
            Clientes consultaclientes = new Clientes();
            consultaclientes.Visible = true;
            this.Visible = false;
        }

        private void btnExcluirCliente_Cliente_Click(object sender, EventArgs e)
        {
            Clientes consultaclientes = new Clientes();
            consultaclientes.Visible = true;
            this.Visible = false;
        }
    }
}
