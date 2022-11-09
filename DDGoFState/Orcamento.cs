using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDGofState
{
    /* State
     * 
     * sugere que você crie novas classes para todos os estados possíveis de um objeto 
     *  e extraia todos os comportamentos específicos de estados para dentro dessas classes
     */
    public class Orcamento
    {
        public EstadoDeUmOrcamento EstadoAtual { get; set; }

        public double Valor { get; set; }

        public IList<Item> Itens { get; private set; }

        public Orcamento(double valor)
        {
            this.Valor = valor;
            this.Itens = new List<Item>();
            this.EstadoAtual = new EmAprovacao();
        }

        public void AdicionarItem(Item item)
        {
            Itens.Add(item);
        }

        public void AplicarDescontoExtra()
        {
            EstadoAtual.AplicarDescontoExtra(this);
        }

        public void Aprovar()
        {
            EstadoAtual.Aprovar(this);
        }

        public void Reprovar()
        {
            EstadoAtual.Reprovar(this);
        }

        public void Finalizar()
        {
            EstadoAtual.Finalizar(this);
        }
    }
}
