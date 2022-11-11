using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDGofVisitor
{
    public class Subtracao : IExpressao
    {
        public IExpressao Esquerda { get; private set; }
        public IExpressao Direita { get; private set; }

        public Subtracao(IExpressao esquerda, IExpressao direita)
        {
            this.Esquerda = esquerda;
            this.Direita = direita;
        }

        public void Aceitar(IVisitor impressora)
        {
            impressora.ImprimirSubtracao(this);
        }

        public int Avaliar()
        {
            int valorEsquerda = Esquerda.Avaliar();
            int valorDireita = Direita.Avaliar();

            return valorEsquerda - valorDireita;
        }
    }
}
