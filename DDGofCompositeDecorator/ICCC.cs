using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDGofCompositeDecorator
{
    public class ICCC : Imposto
    {
        public override double Calcular(Orcamento orcamento)
        {
            double valor = orcamento.Valor;
            double valorTotal = 0;

            if (valor < 1000.0)
            {
                valorTotal = valor * 0.05;
            } 
            else if (valor >= 1000.0 && valor <= 3000.0)
            {
                valorTotal = valor * 0.07;
            }
            else
            {
                valorTotal = valor * 0.08 + 30.0;
            }

            return valorTotal;
        }
    }
}
