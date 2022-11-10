namespace DDGofStatePositivoNegativo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Conta conta = new Conta();
            conta.Depositar(100);

            conta.Sacar(50);
            conta.ExibirEstado();

            conta.Sacar(200);
            conta.ExibirEstado();
        }
    }
}