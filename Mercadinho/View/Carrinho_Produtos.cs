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

namespace Mercadinho.View
{
    public partial class Carrinho_Produtos : Form
    {
        private CarrinhoProdutos carrinhoproduto;
        private Cliente selecionarcliente;
        private Model.Fatura fat;



        private List<Fatura> parcelas;
        private List<Produto> listaprodutos;
        internal List<Produto> Listaprodutos { get => listaprodutos; set => listaprodutos = value; }
        internal Cliente Selecionarcliente { get => selecionarcliente; set => selecionarcliente = value; }
        internal List<Fatura> Parcelas { get => parcelas; set => parcelas = value; }

        public Carrinho_Produtos()
        {
            InitializeComponent();
            listaprodutos = new List<Produto>();
            parcelas = new List<Fatura>();


        }

        public void SomarCarrinho()
        {

            carrinhoproduto = new CarrinhoProdutos();

            decimal soma = 0;
            foreach (Produto prod in listaprodutos)
            {
                soma += prod.Precovenda;

            }


            LabelTotal.Text = soma.ToString();
        }

        public void CalcularParcelas()
        {
            carrinhoproduto = new CarrinhoProdutos();


            DateTime dataPrimeiroVencimento = DateTime.Now;

            decimal soma = 0;
            decimal quantidadeparcelas = Convert.ToDecimal(qtdparcelas.SelectedItem);
            decimal resultado = 0;
            foreach (Produto prod in listaprodutos)
            {
                soma += prod.Precovenda;

            }

            if (formadepagamento.SelectedItem.Equals("Á Vista"))
            {
                fat = new Fatura();
                fat.DataVencimento1 = dataPrimeiroVencimento;
                fat.DataPagamento1 = dataPrimeiroVencimento;
                fat.Valorfatura = soma;
                fat.Formadepagamento = formadepagamento.SelectedItem.ToString();
                fat.Estapago = true;
                Parcelas.Add(fat);
            }
            else
            {
                
                resultado = (soma / quantidadeparcelas);
                labelvalorparcelas.Text = resultado.ToString();
                for (int i = 0; i < quantidadeparcelas; i++)
                {
                    fat = new Fatura();
                    fat.DataVencimento1 = dataPrimeiroVencimento.AddMonths(i + 1);
                    fat.DataPagamento1.Equals(null);
                    fat.Valorfatura = resultado;
                    fat.Formadepagamento = formadepagamento.SelectedItem.ToString();
                    fat.Estapago = false;
                    Parcelas.Add(fat);
                }
            }

        
        carrinhoproduto.Parcelas = parcelas;

            

        }
       
        public void carregardados()
        {
            dataGridViewcarrinhoprodutos.Rows.Clear();
            foreach(Produto prod in listaprodutos)
            {
                DataGridViewRow row = (DataGridViewRow)dataGridViewcarrinhoprodutos.Rows[0].Clone();

                row.Cells[0].Value = prod.Nome;
                row.Cells[1].Value = prod.Precovenda;
                row.Cells[2].Value = prod.Datavencimento;
                row.Cells[3].Value = prod.Codigobarras;

                dataGridViewcarrinhoprodutos.Rows.Add(row);              
            }

        }
      

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            View.ListarProdutos listarproduto = new View.ListarProdutos(this);       
            listarproduto.Visible = true;
            this.Visible = true;
        }

        private void Adicionar_Produto_Click(object sender, EventArgs e)
        {
            View.ListarCliente listarcliente = new View.ListarCliente(this);

            Selecionarcliente = new Cliente();

            listarcliente.Visible = true;
            this.Visible = true;
        }

        public void preencheTxt()
        {
            LabelNomeCliente.Text = Selecionarcliente.Nome;
            LabelCPF.Text = Selecionarcliente.CPF.ToString();
        }

        private void Carrinho_Produtos_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            CalcularParcelas();
            
            try 
            {
            
            carrinhoproduto.Cliente = selecionarcliente;
            carrinhoproduto.Produtos1 = listaprodutos;
            carrinhoproduto.InserirDadosCarrinho();

                MessageBox.Show("Venda Realizada!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex);
            }
            finally
            {

            }
        }

        private void qtdparcelas_SelectedValueChanged(object sender, EventArgs e)
        {
            
            
            
        }

        private void qtdparcelas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCliente_Carrinho_Click(object sender, EventArgs e)
        {
            View.Menu_Cliente menu = new View.Menu_Cliente();
            menu.Visible = true;
            this.Visible = false;
        }

        private void btnProduto_Carrinho_Click(object sender, EventArgs e)
        {
            View.Menu_Produto menu = new View.Menu_Produto();
            menu.Visible = true;
            this.Visible = false;
        }

        private void btnServico_Carrinho_Click(object sender, EventArgs e)
        {
            Cadastro_Servico servico = new Cadastro_Servico();
            servico.Visible = true;
            this.Visible = false;
        }

        private void btnTP_Carrinho_Click(object sender, EventArgs e)
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

        private void btnRelatorio_Carrinho_Click(object sender, EventArgs e)
        {
            View.Menu_Relatorios menu = new View.Menu_Relatorios();
            menu.Visible = true;
            this.Visible = false;
        }

        private void btnSair_Carrinho_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void qtdparcelas_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void qtdparcelas_SelectedValueChanged_1(object sender, EventArgs e)
        {

            decimal soma = 0;
            decimal quantidadeparcelas = Convert.ToDecimal(qtdparcelas.SelectedItem);
            decimal resultado = 0;
            foreach (Produto prod in listaprodutos)
            {
                soma += prod.Precovenda;

            }

            resultado = (soma / quantidadeparcelas);
            labelvalorparcelas.Text = resultado.ToString();


        }

        private void button4_Click(object sender, EventArgs e)
        {
           
        }
    }
}
