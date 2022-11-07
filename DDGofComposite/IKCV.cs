using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDGofComposite
{
    public class IKCV : ITemplateDeImpostoCondicional
    {
        public override bool DeveUsarMaximaTaxacao(Orcamento orcamento)
        {
            return (orcamento.Valor > 500 && itemMaiorQue100ReaisNo(orcamento));
        }

        public override double MaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.1;
        }

        public override double MinimaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.06;
        }

        private bool itemMaiorQue100ReaisNo(Orcamento orcamento)
        {
            return orcamento.Itens
                   .ToList()
                   .Where(item => item.Valor > 100)
                   .Any();
        }
    }
}
