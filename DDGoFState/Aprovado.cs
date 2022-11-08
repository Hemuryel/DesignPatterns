using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDGofState
{
    public class Aprovado : EstadoDeUmOrcamento
    {
        public void AplicarDescontoExtra(Orcamento orcamento)
        {
            orcamento.Valor -= orcamento.Valor * 0.02;
        }

        public void Aprovar(Orcamento orcamento)
        {
            throw new Exception("Orçamento já está em estado de aprovação.");
        }

        public void Finalizar(Orcamento orcamento)
        {
            orcamento.EstadoAtual = new Finalizado();
        }

        public void Reprovar(Orcamento orcamento)
        {
            throw new Exception("Orçamento está em aprovado, não pode ser reprovado agora");
        }
    }
}
