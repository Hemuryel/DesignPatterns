using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDGofFactoryMethod
{
    internal class ConnectionFactory
    {
        public IDbConnection GetConnection()
        {
            IDbConnection conexao = new SqlConnection();
            conexao.ConnectionString = "User Id=sa;Password=;Server=localhost;Database=meuBanco";
            //conexao.ConnectionString = new LeitorConfiguracao().LerConnectionString();
            conexao.Open();

            return conexao;
        }
    }
}
