using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Mercadinho.Conexao

{
    class Conexao
    {
        private String connectionString;

        public String getConnectionString()
        {
            connectionString = ConfigurationManager.ConnectionStrings
            ["Mercadinho.Properties.Settings.mercadinhoConnectionString"].ConnectionString;
            return connectionString;
        }
    }
}
