using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDGofCompositeDecorator
{
    public class ICMS : Imposto
    {
        public ICMS() : base()
        {

        }

        public ICMS(Imposto outroImposto) : base(outroImposto)
        {

        }

        public override double Calcular(Orcamento orcamento)
        {
            return orcamento.Valor * 0.1 + CalcularOutroImposto(orcamento);
        }
    }
}
