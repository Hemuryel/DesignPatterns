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

        /* Decorator
         * 
         * anexa responsabilidades adicionais a um objeto dinamicamente
         * fornecem uma alternativa flexível de subclasse para estender a funcionalidade
         */
        protected double CalcularOutroImposto(Orcamento orcamento)
        {
            return (OutroImposto == null ? 0 : OutroImposto.Calcular(orcamento));
        }
    }
}
