using System.Xml.Serialization;

namespace DDGofAdapter
{
    internal class Program
    {
        /* Adapter
         * 
         * lidar com código legado
         * converter interface legada em outra
         */

        static void Main(string[] args)
        {
            Cliente cliente = new Cliente();
            cliente.Nome = "Fulano";
            cliente.Endereco = "Rua Vergueiro";
            cliente.DtNascimento = DateTime.Now;

            string xml = new GeradorXMLAdapter().GerarXml(cliente);

            Console.WriteLine(xml);
        }
    }
}