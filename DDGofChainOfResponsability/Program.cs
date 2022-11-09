namespace DDGofChainOfResponsability
{
    public class Program
    {
        /* Chain of Responsability
         * 
         * usado para encadeamento de regras
         * permite passar a solicitação ao longo da cadeia de handlers em potencial até que um deles lide com a solicitação
         */

        static void Main(string[] args)
        {
            CalculadorDeDescontos calculador = new CalculadorDeDescontos();

            Orcamento orcamento = new Orcamento(500);
            orcamento.AdicionarItem(new Item("CANETA", 500));
            orcamento.AdicionarItem(new Item("LAPIS", 500));
            orcamento.AdicionarItem(new Item("GELADEIRA", 500));
            orcamento.AdicionarItem(new Item("FOGAO", 500));
            orcamento.AdicionarItem(new Item("MICRO-ONDAS", 500));
            orcamento.AdicionarItem(new Item("XBOX", 500));

            double desconto = calculador.Calcular(orcamento);
            Console.WriteLine(desconto);

            Console.ReadKey();
        }
    }
}