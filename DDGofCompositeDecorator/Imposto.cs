using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDGofCompositeDecorator
{
    public abstract class Imposto
    {
        public Imposto OutroImposto { get; set; }

        public abstract double Calcular(Orcamento orcamento);

        public Imposto()
        {
            this.OutroImposto = null;
        }

        public Imposto(Imposto outroImposto)
        {
            this.OutroImposto = outroImposto;
        }

        //Padrão GoF - Decorator
        protected double CalcularOutroImposto(Orcamento orcamento)
        {
            if (OutroImposto == null) return 0;
            return OutroImposto.Calcular(orcamento);
        }
    }
}
