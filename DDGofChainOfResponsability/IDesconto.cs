using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDGofChainOfResponsability
{
    public interface IDesconto
    {
        double Descontar(Orcamento orcamento);
        IDesconto Proximo { get; set; }
    }
}
