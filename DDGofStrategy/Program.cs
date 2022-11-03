namespace CursoDesignPatterns
{
    public class Program
    {
        static void Main(string[] args)
        {
            IImposto iccc = new ICCC();

            Orcamento orcamento = new Orcamento(3001.0);

            CalculadorDeImpostos calculador = new CalculadorDeImpostos();
            calculador.RealizarCalculo(orcamento, iccc);

            Console.ReadKey();
        }
    }
}