using System;

namespace DDGofObserver
{
    public class Multiplicador : IAcaoAposGerarNota
    {
        public double Fator { get; private set; }

        public Multiplicador(double fator)
        {
            this.Fator = fator;
        }

        public void Executar(NotaFiscal nf)
        {
            Console.WriteLine("Multiplicando: " + nf.ValorBruto * this.Fator);
        }
    }
}