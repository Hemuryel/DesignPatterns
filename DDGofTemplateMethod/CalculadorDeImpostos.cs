using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDGofTemplateMethod
{
    public class CalculadorDeImpostos
    { 
        public void RealizarCalculo(Orcamento orcamento, IImposto imposto)
        {
            Console.WriteLine(imposto.Calcular(orcamento));
        }
    }
}
