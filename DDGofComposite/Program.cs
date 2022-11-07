using System;

namespace DDGofComposite
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Imposto iss = new ISS();
            Imposto iss = new ISS(new ICMS(new IKCV()));

            Orcamento orcamento = new Orcamento(500);

            double valor = iss.Calcular(orcamento);

            Console.WriteLine(valor);

            Console.ReadKey();
        }
    }
}