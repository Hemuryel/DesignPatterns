using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDGofVisitor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // (1 + 10) + (20 - 10)
            IExpressao esquerda = new Soma(new Numero(1), new Numero(10));
            IExpressao direita = new Subtracao(new Numero(20), new Numero(10));
            IExpressao soma = new Soma(esquerda, direita);

            IVisitor impressora = new ImpressoraVisitor();
            soma.Aceitar(impressora);

            Console.WriteLine("\n####\n");

            IVisitor impressoraPreFixa = new ImpressoraPreFixaVisitor();
            soma.Aceitar(impressoraPreFixa);
        }
    }
}
