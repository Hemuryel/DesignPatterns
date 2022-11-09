namespace DDGofTemplateMethod
{
    public class Program
    {
        /* Template Method
         * 
         * define o esqueleto de um algoritmo dentro de um método, 
         * transferindo alguns de seus passos para as subclasses
         */

        static void Main(string[] args)
        {
            IImposto iccc = new ICCC();
            IImposto icpp = new ICPP();
            IImposto ikcv = new IKCV();
            IImposto ihit = new IHIT();

            Orcamento orcamento = new Orcamento(3001.0);
            orcamento.AdicionarItem(new Item("Teste", 100));
            orcamento.AdicionarItem(new Item("Teste", 200));

            CalculadorDeImpostos calculador = new CalculadorDeImpostos();
            calculador.RealizarCalculo(orcamento, iccc);
            calculador.RealizarCalculo(orcamento, icpp);
            calculador.RealizarCalculo(orcamento, ikcv);
            calculador.RealizarCalculo(orcamento, ihit);

            Console.ReadKey();
        }
    }
}