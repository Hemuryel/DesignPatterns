﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDGofTemplateMethod
{
    public class ISS : IImposto
    {
        public double Calcular(Orcamento orcamento)
        {
            return orcamento.Valor * 0.06;
        }
    }
}
