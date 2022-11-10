using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDGofInterpreter
{
    public class Soma : IExpressao
    {
        private IExpressao esquerda;
        private IExpressao direita;

        public Soma(IExpressao esquerda, IExpressao direita)
        {
            this.esquerda = esquerda;
            this.direita = direita;
        }

        public int Avaliar()
        {
            int valorEsquerda = esquerda.Avaliar();
            int valorDireita = direita.Avaliar();

            return valorEsquerda + valorDireita;
        }
    }
}
