using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDGofVisitor
{
    public interface IVisitor
    {
        void ImprimirSoma(Soma soma);
        void ImprimirSubtracao(Subtracao subtracao);
        void ImprimirNumero(Numero numero);
    }
}
