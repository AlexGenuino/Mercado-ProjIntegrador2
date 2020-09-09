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
    public partial class Servicos : Form
    {
        public Servicos()
        {
            InitializeComponent();
        }

        private void NovoServicoButton_Click(object sender, EventArgs e)
        {
            Cadastro_Servico cadServ = new Cadastro_Servico();
            cadServ.Visible = true;
            this.Visible = false;
        }

        private void PrecoServicoTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void CodigoServicoTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ExcluirServicoButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja excluir este serviço ?", "Excluindo Serviço", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    CodigoServicoTextBox.Text = "";
                    PreçoServicoTextBox.Text = "";
                    DescricaoServicoTextBox.Text = "";

                    MessageBox.Show("Serviço Excluido !!");


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Falha ao excluir serviço!\n" + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCad_ConsServico_Click(object sender, EventArgs e)
        {
            View.Menu_Cliente menu = new View.Menu_Cliente();
            menu.Visible = true;
            this.Visible = false;
        }

        private void btnProduto_ConsServico_Click(object sender, EventArgs e)
        {
            View.Menu_Produto menu = new View.Menu_Produto();
            menu.Visible = true;
            this.Visible = false;
        }

        private void btnServ_ConsServico_Click(object sender, EventArgs e)
        {
            Cadastro_Servico servico = new Cadastro_Servico();
            servico.Visible = true;
            this.Visible = false;
        }

        private void btnTipo_ConsServico_Click(object sender, EventArgs e)
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

        private void btnRelatorio_ConsServico_Click(object sender, EventArgs e)
        {
            View.Menu_Relatorios menu = new View.Menu_Relatorios();
            menu.Visible = true;
            this.Visible = false;
        }

        private void btnSair_ConsServico_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BuscarServicoButton_Click(object sender, EventArgs e)
        {

        }

        private void AlterarServicoButton_Click(object sender, EventArgs e)
        {

        }
    }
}
