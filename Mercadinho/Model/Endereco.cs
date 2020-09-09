using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mercadinho.Model
{
    class Endereco
    {
        
        private String bairro;
        private String cidade;
        private String numero;
        private String cep;
        private String rua;
        private string cpfcliente;
        private int idendereco;

        private DAO.EnderecoDAO edao;

        public Endereco()
        {


        }

       
        public string Bairro { get => bairro; set => bairro = value; }
        public string Cidade { get => cidade; set => cidade = value; }
        public string Numero { get => numero; set => numero = value; }
        public string Cep { get => cep; set => cep = value; }
        public string Rua { get => rua; set => rua = value; }
        public string Cpfcliente { get => cpfcliente; set => cpfcliente = value; }
        public int Idendereco { get => idendereco; set => idendereco = value; }

        public void InserirDados()
        {
            edao = new DAO.EnderecoDAO();
            edao.InserirDados(Bairro, Cidade, Numero, Cep, Rua, Cpfcliente);

        }

        public void Atualizar()
        {
            edao = new DAO.EnderecoDAO();
            edao.AtualizarDadosEndereco(bairro, cidade, numero, cep, rua, cpfcliente, idendereco);
        }

        public void DeletarCliente()
        {
            edao = new DAO.EnderecoDAO();
            edao.RemoverDadosCliente(cpfcliente);
        }
    }
}
