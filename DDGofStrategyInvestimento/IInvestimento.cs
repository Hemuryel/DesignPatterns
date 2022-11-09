using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDGofStrategyInvestimento
{
    public interface IInvestimento
    {
        double Calcular(Conta conta);
    }
}
