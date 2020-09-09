using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mercadinho.Model
{
    class Produto
    {
        private String nome;
        private decimal precocompra;
        private decimal precovenda;
        private int quantidadeestoque;
        private int codigobarras;
        private DateTime datavencimento;
        private int idcategoria;

        private DAO.ProdutoDAO pdao;


        public Produto()
        {


        }

        public string Nome { get => nome; set => nome = value; }
        public decimal Precocompra { get => precocompra; set => precocompra = value; }
        public decimal Precovenda { get => precovenda; set => precovenda = value; }
        public int Quantidadeestoque { get => quantidadeestoque; set => quantidadeestoque = value; }
        public int Codigobarras { get => codigobarras; set => codigobarras = value; }
        public DateTime Datavencimento { get => datavencimento; set => datavencimento = value; }
        public int Idcategoria { get => idcategoria; set => idcategoria = value; }




        public void InserirDados()
        {
        pdao = new DAO.ProdutoDAO();
        pdao.InserirDados(nome, precocompra, precovenda, quantidadeestoque, datavencimento, idcategoria);

        }

        public void Atualizar()
        {
            pdao = new DAO.ProdutoDAO();
            pdao.AtualizarDadosProduto(nome, precocompra, precovenda, quantidadeestoque, datavencimento, idcategoria, codigobarras);
        }

        public void Deletar()
        {
            pdao = new DAO.ProdutoDAO();
            pdao.RemoverDadosProduto(codigobarras);
        }
    }
}
