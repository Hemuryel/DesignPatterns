namespace DDGofTemplateMethodReport
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Report simpleReport = new SimpleReport();
            Report complexReport = new ComplexReport();

            Conta conta1 = new Conta();
            conta1.Nome = "Fulano da Silva";
            conta1.Numero = "9876";
            conta1.Saldo = 1000.0;
            conta1.Agencia = "0001";

            IList<Conta> contas = new List<Conta>();
            contas.Add(conta1);

            simpleReport.Print(contas);
            Console.WriteLine("\n#######\n");
            complexReport.Print(contas);
        }
    }
}