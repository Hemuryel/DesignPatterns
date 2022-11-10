using System.Data;
using System.Data.SqlClient;

namespace DDGofFactoryMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IDbConnection conexao = new ConnectionFactory().GetConnection();

            IDbCommand comando = conexao.CreateCommand();
            comando.CommandText = "SELECT * FROM tabela";
        }
    }
}