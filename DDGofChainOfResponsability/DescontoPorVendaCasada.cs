using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDGofChainOfResponsability
{
    public class DescontoPorVendaCasada : IDesconto
    {
        public IDesconto Proximo { get; set; }

        public double Descontar(Orcamento orcamento)
        {
            if (AconteceuVendaCasada(orcamento))
                return orcamento.Valor * 0.05;
            else
                return Proximo.Descontar(orcamento);
        }

        private bool Existe(String nomeItem, Orcamento orcamento)
        {
            foreach(Item item in orcamento.Itens)
            {
                if (item.Nome.Equals(nomeItem))
                    return true;
            }

            return false;
        }

        private bool AconteceuVendaCasada(Orcamento orcamento)
        {
            return Existe("CANETA", orcamento) && Existe("LAPIS", orcamento);
        }
    }
}
