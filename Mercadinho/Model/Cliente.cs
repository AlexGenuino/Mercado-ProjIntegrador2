using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mercadinho.Model
{
    class Cliente
    {
        private String cpf;
        private String nome;
        private DateTime datanascimento;
        private String email;
        private String contato;


        private DAO.ClienteDAO cdao;


        public Cliente()
        {


        }

        public string CPF { get => cpf; set => cpf = value; }
        public string Nome { get => nome; set => nome = value; }
        public DateTime DataNascimento { get => datanascimento; set => datanascimento = value; }
        public string Email { get => email; set => email = value; }
        public string Contato { get => contato; set => contato = value; }

        public void InserirDados()
        {
            cdao = new DAO.ClienteDAO();
            cdao.InserirDados(nome, datanascimento, cpf, email, contato);

        }

        public void Atualizar()
        {
            cdao = new DAO.ClienteDAO();
            cdao.AtualizarDadosCliente(Nome, datanascimento, cpf, email, contato);
        }

        public void Deletar()
        {
            cdao = new DAO.ClienteDAO();
            cdao.RemoverDadosCliente(cpf);
        }

    }
}
