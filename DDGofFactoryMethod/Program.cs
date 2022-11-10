using System.Data;
using System.Data.SqlClient;

namespace DDGofFactoryMethod
{
    internal class Program
    {
        /* Factory Method
         * 
         * isola a criação de objetos complicados
         * 
         * faça uso de Factories sempre que a criação de um objeto possa mudar em algum momento
         * obs: enquanto Builder, o objeto que é criado varia de acordo com os parâmetros
         * ver classe ConnectionFactory
         */

        static void Main(string[] args)
        {
            IDbConnection conexao = new ConnectionFactory().GetConnection();

            IDbCommand comando = conexao.CreateCommand();
            comando.CommandText = "SELECT * FROM tabela";
        }
    }
}