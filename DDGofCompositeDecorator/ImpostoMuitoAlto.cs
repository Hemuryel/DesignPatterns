using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDGofCompositeDecorator
{
    public class ImpostoMuitoAlto : Imposto
    {
        public ImpostoMuitoAlto() : base()
        {

        }

        public ImpostoMuitoAlto(Imposto imposto) : base(imposto)
        {

        }

        public override double Calcular(Orcamento orcamento)
        {
            return orcamento.Valor * 0.2 + CalcularOutroImposto(orcamento);
        }
    }
}
