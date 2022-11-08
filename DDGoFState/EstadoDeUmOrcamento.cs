using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDGofState
{
    public interface EstadoDeUmOrcamento
    {
        void AplicarDescontoExtra(Orcamento orcamento);

        void Aprovar(Orcamento orcamento);
        void Reprovar(Orcamento orcamento);
        void Finalizar(Orcamento orcamento); 
    }
}
