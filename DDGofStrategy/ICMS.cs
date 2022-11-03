using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDGofStrategy
{
    public class ICMS : IImposto
    {
        public double Calcular(Orcamento orcamento)
        {
            return orcamento.Valor * 0.05 + 50.00;
        }
    }
}
