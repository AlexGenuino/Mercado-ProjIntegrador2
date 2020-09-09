using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mercadinho.Model
{
    class Login
    {
        private String email;
        private String senha;
       

        private DAO.LoginDAO ldao;

        public Login()
        {

        }

        public string Email { get => email; set => email = value; }
        public string Senha { get => senha; set => senha = value; }
   

        public void VerificarLogin()
        {
            ldao = new DAO.LoginDAO();
            ldao.VerificaLogin(email, senha);
        }





    }
}