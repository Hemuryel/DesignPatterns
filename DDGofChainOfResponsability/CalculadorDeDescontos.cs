using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDGofChainOfResponsability
{
    public class CalculadorDeDescontos
    {
        public double Calcular(Orcamento orcamento)
        {
            IDesconto d1 = new DescontosPorCincoItens();
            IDesconto d2 = new DescontoPorMaisDeQuinhentosReais();
            IDesconto d3 = new DescontoPorVendaCasada();
            IDesconto d4 = new SemDesconto();

            d1.Proximo = d2;
            d2.Proximo = d3;
            d3.Proximo = d4;

            return d1.Descontar(orcamento);
        }
    }
}
