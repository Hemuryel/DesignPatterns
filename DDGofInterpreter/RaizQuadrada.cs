using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDGofInterpreter
{
    public class RaizQuadrada : IExpressao
    {
        private IExpressao expressao;

        public RaizQuadrada(IExpressao expressao)
        {
            this.expressao = expressao;
        }

        public int Avaliar()
        {
            int valor = expressao.Avaliar();

            return (int) Math.Sqrt(valor);
        }
    }
}
