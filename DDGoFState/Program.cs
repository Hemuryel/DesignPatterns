using System;

namespace DDGofState
{
    using static System.Console;
    public class Program
    {
        static void Main(string[] args)
        {
            Orcamento reforma = new Orcamento(500);
            WriteLine(reforma.Valor);

            reforma.AplicarDescontoExtra();
            WriteLine(reforma.Valor);

            reforma.Aprovar();

            reforma.AplicarDescontoExtra();
            WriteLine(reforma.Valor);

            reforma.Finalizar();

            //reforma.AplicarDescontoExtra(); //Exception

            ReadKey();
        }
    }
}
