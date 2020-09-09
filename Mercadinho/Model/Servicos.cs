using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mercadinho.Model
{
   
    class Servicos
    {
        private decimal preco;
        private String descricao;
        private int idservico;

        


        private DAO.ServicosDAO sdao;

        public Servicos()
        {

        }

        public decimal Preco { get => preco; set => preco = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public int Idservico { get => idservico; set => idservico = value; }

        public void InserirDados()
        {
            sdao = new DAO.ServicosDAO();
            sdao.InserirDados(preco, descricao);

        }

        public void AtualizarDados()
        {
            sdao = new DAO.ServicosDAO();
            sdao.AtualizarDadosServico(this);
        }

        public void Excluir()
        {
            sdao = new DAO.ServicosDAO();
            sdao.RemoverDadosServico(this);
        }

    }

}
