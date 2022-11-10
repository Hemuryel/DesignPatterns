namespace DDGofFlyweight
{
    internal class Program
    {
        /* Flyweight
         * 
         * permite criar e reutilizar objetos, mantendo baixo consumo de memória
         */

        static void Main(string[] args)
        {
            NotasMusicais notas = new NotasMusicais();

            IList<INota> musica = new List<INota>()
            {
                notas.GetNota("do"),
                notas.GetNota("re"),
                notas.GetNota("mi"),
                notas.GetNota("fa"),
                notas.GetNota("fa"),
                notas.GetNota("fa")
            };

            Piano piano = new Piano();
            piano.Tocar(musica);
        }
    }
}