using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDGofStrategy
{
    public class CalculadorDeImpostos
    { 
        public void RealizarCalculo(Orcamento orcamento, IImposto imposto)
        {
            //Strategy
            double resultado = imposto.Calcular(orcamento);
            Console.WriteLine(resultado);
        }
    }
}
