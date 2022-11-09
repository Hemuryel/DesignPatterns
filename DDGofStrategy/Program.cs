namespace DDGofStrategy
{
    public class Program
    {
        /* Strategy
         * 
         * uso de polimorfismo
         * permite definir novas operações sem alterar as classes dos elementos sobre os quais opera
         * definir uma família de algoritmos, encapsular cada uma delas e torná-las intercambiáveis
        */
        static void Main(string[] args)
        {
            IImposto iccc = new ICCC();
            IImposto iss = new ISS();

            Orcamento orcamento = new Orcamento(3001.0);

            CalculadorDeImpostos calculador = new CalculadorDeImpostos();
            calculador.RealizarCalculo(orcamento, iccc);
            calculador.RealizarCalculo(orcamento, iss);

            Console.ReadKey();
        }
    }
}