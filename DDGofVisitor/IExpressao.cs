using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDGofVisitor
{
    public interface IExpressao
    {
        int Avaliar();
        void Aceitar(IVisitor impressora);
    }
}
