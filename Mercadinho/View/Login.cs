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
    public partial class Login : Form
    {
        Menu menu;
        public Login()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            

            Model.Login login = new Model.Login();
            
            
            login.Email = txtusuario.Text;
            login.Senha = txtsenha.Text;


            try 
            {
                this.Hide();
                login.VerificarLogin();

            }
            catch
            {
                MessageBox.Show("Usuario ou senha incorreto", "Erro ao autenticar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtusuario_Click(object sender, EventArgs e)
        {
            txtusuario.Clear();
        }

        private void txtsenha_Click(object sender, EventArgs e)
        {
            txtsenha.Clear();
            txtsenha.PasswordChar = ('*');
        }

        private void txtsenha_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
