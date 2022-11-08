using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDGofState
{
    public class Reprovado : EstadoDeUmOrcamento
    {
        String msg = "Orçamento está reprovado.";

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
            orcamento.EstadoAtual = new Finalizado();
        }

        public void Reprovar(Orcamento orcamento)
        {
            throw new Exception(msg);
        }
    }
}
