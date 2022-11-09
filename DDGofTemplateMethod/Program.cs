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

            Orcamento orcamento = new Orcamento(3001.0);

            CalculadorDeImpostos calculador = new CalculadorDeImpostos();
            calculador.RealizarCalculo(orcamento, iccc);

            Console.ReadKey();
        }
    }
}