using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDGofMemento
{
    internal class Historico
    {
        private IList<Estado> Estados = new List<Estado>();

        public void Adicionar(Estado estado)
        {
            this.Estados.Add(estado);
        }

        public Estado GetEstado(int indice)
        {
            return Estados[indice];
        }
    }
}
