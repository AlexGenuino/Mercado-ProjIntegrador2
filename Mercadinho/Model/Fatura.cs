using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mercadinho.Model
{
    class Fatura
    {
        private int idfatura;
        private Decimal valorfatura;
        private DateTime DataVencimento;
        private DateTime DataPagamento;
        private string formadepagamento;
        private bool estapago;
        private int idcarrinho;

        private DAO.FaturaDAO edao;

        public Fatura   ()
        {


        }



        public int Idfatura { get => idfatura; set => idfatura = value; }
        public decimal Valorfatura { get => valorfatura; set => valorfatura = value; }
        public DateTime DataVencimento1 { get => DataVencimento; set => DataVencimento = value; }
        public string Formadepagamento { get => formadepagamento; set => formadepagamento = value; }
        public bool Estapago { get => estapago; set => estapago = value; }
        public int Idcarrinho { get => idcarrinho; set => idcarrinho = value; }
        public DateTime DataPagamento1 { get => DataPagamento; set => DataPagamento = value; }

        public void BaixarFatura()
        {
            edao = new DAO.FaturaDAO();
            edao.BaixarFatura(this);
        }


        
    }
}
