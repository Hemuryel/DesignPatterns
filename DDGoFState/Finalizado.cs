using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDGofState
{
    public class Finalizado : EstadoDeUmOrcamento
    {
        String msg = "Orçamento já está finalizado.";

        public void AplicarDescontoExtra(Orcamento orcamento)
        {
            throw new Exception("Orçamentos finalizados não recebem desconto extra");
        }

        public void Aprovar(Orcamento orcamento)
        {
            throw new Exception(msg);
        }

        public void Finalizar(Orcamento orcamento)
        {
            throw new Exception(msg);
        }

        public void Reprovar(Orcamento orcamento)
        {
            throw new Exception(msg);
        }
    }
}
