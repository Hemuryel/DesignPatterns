using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDGofCompositeDecorator
{
    public class ISS : Imposto
    {
        public ISS() : base()
        {

        }

        public ISS(Imposto outroImposto) : base(outroImposto)
        {
        }

        public override double Calcular(Orcamento orcamento)
        {
            return orcamento.Valor * 0.06 + CalcularOutroImposto(orcamento);
        }
    }
}
