﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDGofStrategyInvestimento
{
    public class Moderado : IInvestimento
    {
        private Random random;
        public Moderado()
        {
            this.random = new Random();
        }
        public double Calcular(Conta conta)
        {
            if (random.Next(2) == 0)
                return conta.Saldo * 0.025;
            else
                return conta.Saldo * 0.007;
        }
    }
}
