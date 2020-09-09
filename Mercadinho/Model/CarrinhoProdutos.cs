using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mercadinho.Model
{
    class CarrinhoProdutos
    {
        private int idCompra;
        private Cliente cliente;
        private List<Produto> Produtos;
        private List<Fatura> parcelas;
        private decimal somacarrinho;

        private DAO.CarrinhoProdutoDAO cdao;

        public CarrinhoProdutos()
        {
        }
        public int IdCompra { get => idCompra; set => idCompra = value; }
        public decimal Somacarrinho { get => somacarrinho; set => somacarrinho = value; }
        internal Cliente Cliente { get => cliente; set => cliente = value; }
        internal List<Produto> Produtos1 { get => Produtos; set => Produtos = value; }
        internal List<Fatura> Parcelas { get => parcelas; set => parcelas = value; }

        public decimal calcularcarrinho()
        {
            decimal soma = 0;
            foreach (Produto prod in Produtos1)
            {
                soma += prod.Precovenda;
            }
            return soma;
        }
        public void InserirDadosCarrinho()
        {
            cdao = new DAO.CarrinhoProdutoDAO();
            cdao.InserirDadosCarrinho(this);
        }
    }

        
}


