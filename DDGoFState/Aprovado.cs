using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDGofState
{
    public class Aprovado : EstadoDeUmOrcamento
    {
        private bool descontoAplicado = false;

        public void AplicarDescontoExtra(Orcamento orcamento)
        {
            if (!descontoAplicado)
            {
                orcamento.Valor -= orcamento.Valor * 0.02;
                descontoAplicado = true;
            }
            else
            {
                throw new Exception("Desconto já aplicado!");
            }
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
