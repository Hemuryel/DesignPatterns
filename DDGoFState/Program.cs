using System;

namespace DDGofState
{
    using static System.Console;
    public class Program
    {
        /* State
         * 
         * coloca todo o comportamento associado com um estado particular em um objeto
         */

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
