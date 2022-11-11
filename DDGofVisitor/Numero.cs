using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDGofVisitor
{
    public class Numero : IExpressao
    {
        public int Valor { get; private set; }

        public Numero(int numero)
        {
            this.Valor = numero;
        }

        public int Avaliar()
        {
            return this.Valor;
        }

        public void Aceitar(ImpressoraVisitor impressora)
        {
            impressora.ImprimirNumero(this);
        }
    }
}
