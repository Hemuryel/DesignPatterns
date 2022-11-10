namespace DDGofStatePositivoNegativo
{
    internal class Negativo : IEstadoConta
    {
        public Negativo()
        {
        }

        public void Depositar(Conta conta, double valor)
        {
            conta.Saldo += valor * 0.95;

            if (conta.Saldo > 0)
                conta.Estado = new Positivo();
        }

        public void Sacar(Conta conta, double valor)
        {
            throw new Exception("Sua conta está no vermelho. Não é permitido sacar!");
        }

        public void ExibirEstado()
        {
            Console.WriteLine("Negativo");
        }
    }
}