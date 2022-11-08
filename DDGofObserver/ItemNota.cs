namespace DDGofObserver
{
    public class ItemNota
    {
        public string Nome { get; private set; }
        public double Valor { get; private set; }

        public ItemNota(string nome, double valor)
        {
            this.Nome = nome;
            this.Valor = valor;
        }
    }
}