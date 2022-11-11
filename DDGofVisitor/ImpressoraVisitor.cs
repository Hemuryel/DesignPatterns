using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDGofVisitor
{
    public class ImpressoraVisitor
    {
        public void ImprimirSoma(Soma soma)
        {
            Console.Write("(");
            soma.Esquerda.Aceitar(this);
            Console.Write("+");
            soma.Direita.Aceitar(this);
            Console.Write(")");            
        }

        public void ImprimirSubracao(Subtracao subtracao)
        {
            Console.Write("(");
            subtracao.Esquerda.Aceitar(this);
            Console.Write("-");
            subtracao.Direita.Aceitar(this);
            Console.Write(")");
        }

        public void ImprimirNumero(Numero numero)
        {
            Console.Write(numero.Valor);
        }
    }
}
