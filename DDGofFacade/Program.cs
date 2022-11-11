namespace DDGofFacade
{
    internal class Program
    {
        /* Façade
         * 
         * provê uma interface simplificada para um corpo de código maior
         */

        static void Main(string[] args)
        {
            String cpf = "1234";

            EmpresaFacade facade = EmpresaFacadeSingleton.GetInstance();

            Cliente cliente = facade.BuscarCliente(cpf);
            Fatura fatura = facade.CriarFatura(cliente, 5000);
            Cobranca cobranca = facade.GerarCobranca(fatura, cliente);
            ContatoCliente contatoCliente = facade.FazerContato(cliente, cobranca);
        }
    }
}