using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDGofStrategyInvestimento
{
    public class Arrojado : IInvestimento
    {
        private Random random;

        public Arrojado()
        {
            this.random = new Random();
        }

        public double Calcular(Conta conta)
        {
            throw new NotImplementedException();
        }
    }
}
