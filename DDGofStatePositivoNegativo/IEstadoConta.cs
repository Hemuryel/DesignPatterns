using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDGofStatePositivoNegativo
{
    public interface IEstadoConta
    {
        void Sacar(Conta conta, double valor);
        void Depositar(Conta conta, double valor);
        void ExibirEstado();
    }
}
