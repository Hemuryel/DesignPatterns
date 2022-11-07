using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDGofComposite
{
    public class CalculadorDeImpostos
    { 
        public void RealizarCalculo(Orcamento orcamento, Imposto imposto)
        {
            Console.WriteLine(imposto.Calcular(orcamento));
        }
    }
}
