using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDGofTemplateMethod
{
    public class IHIT : ITemplateDeImpostoCondicional
    {

        public override bool DeveUsarMaximaTaxacao(Orcamento orcamento)
        {
            //lista vazia
            IList<String> noOrcamento = new List<string>();

            foreach (Item item in orcamento.Itens)
            {
                if (noOrcamento.Contains(item.Nome))
                { 
                    //se encontrar o valor x2 na lista
                    return true;
                }
                else
                {
                    //a medida que adiciona, verifica se o próximo valor contém na list
                    noOrcamento.Add(item.Nome);
                }
            }

            return false;
        }

        public override double MaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.13 + 100;
        }

        public override double MinimaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * (0.01 * orcamento.Itens.Count);
        }
    }
}
