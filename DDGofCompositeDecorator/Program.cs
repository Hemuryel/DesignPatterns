using System;

namespace DDGofCompositeDecorator
{

    public class Program
    {
        /* Composite
         * 
         * compõe objetos em uma estrutura de árvore
         * 
         * Imposto iss = new ISS(new ICMS(new IKCV()));
         */

        /* Decorator
         * 
         * anexa responsabilidades adicionais a um objeto dinamicamente
         * fornecem uma alternativa flexível de subclasse para estender a funcionalidade
         * 
         * ver classe Imposto.cs e método CalcularOutroImposto
         */

        static void Main(string[] args)
        {
            Imposto imposto = new ImpostoMuitoAlto(new ISS(new ICMS(new IKCV())));
            Orcamento orcamento = new Orcamento(500);

            double valorImposto = imposto.Calcular(orcamento);

            Console.WriteLine(valorImposto);
            Console.ReadKey();
        }
    }
}