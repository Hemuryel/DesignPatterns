namespace DDGofStatePositivoNegativo
{
    public class Conta
    {
        // se quiser mudar para "private set" para ajustar o encapsulamento
        // é necessário mover as classes Positivo e Negativo para dentro da classe Conta
        public double Saldo { get; internal set; } 

        internal IEstadoConta Estado { get; set; }

        public Conta()
        {
            this.Saldo = 0;
            this.Estado = new Positivo();
        }

        public void Sacar(double valor)
        {
            Estado.Sacar(this, valor);
        }

        public void Depositar(double valor)
        {
            Estado.Depositar(this, valor);
        }

        public void ExibirEstado()
        {
            Estado.ExibirEstado();
        }
    }
}