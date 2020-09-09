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
    public partial class Carrinho_Servicos : Form
    {
        private Model.Cliente Selecionarcliente;
        private CarrinhoServico carrinhoservico;
        private Model.Fatura fat;



        private List<Model.Fatura> parcelas;

        private List<Model.Servicos> listaservicos;
       

        public Carrinho_Servicos()
        {
            InitializeComponent();
            listaservicos = new List<Model.Servicos>();
            parcelas = new List<Model.Fatura>();
        }
        
        internal Cliente Selecionarcliente1 { get => Selecionarcliente; set => Selecionarcliente = value; }
        internal List<Model.Servicos> Listaservicos { get => listaservicos; set => listaservicos = value; }
        internal List<Fatura> Parcelas { get => parcelas; set => parcelas = value; }

        public void SomarCarrinho()
        {

            carrinhoservico = new CarrinhoServico();

            decimal soma = 0;
            foreach (Model.Servicos servi in listaservicos)
            {
                soma += servi.Preco;

            }


            LabelTotal.Text = soma.ToString();
        }


        public void carregardados()
        {
            dataGridViewservios.Rows.Clear();
            foreach (Model.Servicos servi in listaservicos)
            {
                DataGridViewRow row = (DataGridViewRow)dataGridViewservios.Rows[0].Clone();

                row.Cells[0].Value = servi.Preco;
                row.Cells[1].Value = servi.Idservico ;
                row.Cells[2].Value = servi.Descricao;
                dataGridViewservios.Rows.Add(row);
            }

        }

        public void CalcularParcelas()
        {
            carrinhoservico = new CarrinhoServico();

            DateTime dataPrimeiroVencimento = DateTime.Now;

            decimal soma = 0;
            decimal quantidadeparcelas = Convert.ToDecimal(qtdparcelas.SelectedItem);
            decimal resultado = 0;
            foreach (Model.Servicos serv in listaservicos)
            {
                soma += serv.Preco;

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


            carrinhoservico.Parcelas = parcelas;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            View.ListarClienteServico listarcliente = new View.ListarClienteServico(this);

            Selecionarcliente1 = new Cliente();

            listarcliente.Visible = true;
            this.Visible = true;
        }

        public void preencheTxt()
        {
            labelclienteserv.Text = Selecionarcliente1.Nome;
            cpfclienteserv.Text = Selecionarcliente1.CPF.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            View.ListarServico listarservico = new View.ListarServico(this);
            listarservico.Visible = true;
            this.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {

            CalcularParcelas();
            try
            {
                carrinhoservico.Cliente = Selecionarcliente;
                carrinhoservico.Servicos1 = listaservicos;
                carrinhoservico.InserirDadosCarrinho();

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

        private void qtdparcelas_SelectedValueChanged_1(object sender, EventArgs e)
        {
            decimal soma = 0;
            decimal quantidadeparcelas = Convert.ToDecimal(qtdparcelas.SelectedItem);
            decimal resultado = 0;
            foreach (Model.Servicos serv in listaservicos)
            {
                soma += serv.Preco;
            }
            resultado = (soma / quantidadeparcelas);
            labelvalorparcelas.Text = resultado.ToString();
        }
    }
}
