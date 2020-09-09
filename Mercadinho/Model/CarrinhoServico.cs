using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mercadinho.Model
{
    class CarrinhoServico
    {
        private int idCompra;
        private Cliente cliente;
        private List<Servicos> Servicos;
        private List<Fatura> parcelas;
        private decimal somacarrinho;

        private DAO.CarrinhoServicoDAO cdao;


        public CarrinhoServico()
        {
        }


        public int IdCompra { get => idCompra; set => idCompra = value; }
        public decimal Somacarrinho { get => somacarrinho; set => somacarrinho = value; }
        internal Cliente Cliente { get => cliente; set => cliente = value; }
        internal List<Servicos> Servicos1 { get => Servicos; set => Servicos = value; }
        internal List<Fatura> Parcelas { get => parcelas; set => parcelas = value; }

        public decimal calcularcarrinho()
        {
            decimal soma = 0;

            foreach (Servicos prod in Servicos1)
            {
                soma += prod.Preco;
            }


            return soma;
        }
        public void InserirDadosCarrinho()
        {
            cdao = new DAO.CarrinhoServicoDAO();
            cdao.InserirDadosCarrinho(this);
        }
    }
}
