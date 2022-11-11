using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDGofVisitor
{
    public class Soma : IExpressao
    {
        public IExpressao Esquerda { get; private set; }
        public IExpressao Direita { get; private set; }

        public Soma(IExpressao esquerda, IExpressao direita)
        {
            this.Esquerda = esquerda;
            this.Direita = direita;
        }

        public int Avaliar()
        {
            int valorEsquerda = Esquerda.Avaliar();
            int valorDireita = Direita.Avaliar();

            return valorEsquerda + valorDireita;
        }

        public void Aceitar(IVisitor impressora)
        {
            impressora.ImprimirSoma(this);
        }
    }
}
