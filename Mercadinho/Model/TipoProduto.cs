using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mercadinho.Model
{
    class TipoProduto
    {
        private String tipoproduto;
        private int idtipoproduto;

        private DAO.TipoProdutoDAO tdao;

        public TipoProduto()
        {

        }

        public string Tipoproduto { get => tipoproduto; set => tipoproduto = value; }
        public int Idtipoproduto { get => idtipoproduto; set => idtipoproduto = value; }

        public void InserirDados()
        {   
            tdao = new DAO.TipoProdutoDAO();
            tdao.InserirDados(tipoproduto);

        }

        public void Atualizar()
        {
            tdao = new DAO.TipoProdutoDAO();
            tdao.AtualizarDadosTipo(tipoproduto, idtipoproduto);
        }

        public void Deletar()
        {
            tdao = new DAO.TipoProdutoDAO();
            tdao.RemoverDadosTipo(idtipoproduto);
        }
    }
}
