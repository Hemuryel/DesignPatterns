using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDGofStrategyInvestimento
{
    public class Conservador : IInvestimento
    {
        public double Calcular(Conta conta)
        {
            return conta.Saldo * 0.008;
        }
    }
}
