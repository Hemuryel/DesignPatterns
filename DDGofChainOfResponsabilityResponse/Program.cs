namespace DDGofChainOfResponsabilityResponse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Conta conta1 = new Conta();
            conta1.Titular = "Fulano da Silva";
            conta1.Saldo = 1000.0;

            Request request = new Request(Format.XML);
            Response response = new Response(request, conta1);
        }
    }
}