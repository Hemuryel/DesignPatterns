using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDGofCompositeDecoratorFilter
{
    public abstract class Filtro
    {
        protected Filtro OutroFiltro { get; private set; }

        public Filtro() { }

        public Filtro(Filtro outroFiltro)
        {
            OutroFiltro = outroFiltro;
        }

        public abstract IList<Conta> Filtrar(IList<Conta> contas);

        protected IList<Conta> Proximo(IList<Conta> contas)
        {
            if (OutroFiltro != null)
                return OutroFiltro.Filtrar(contas);
            else
                return new List<Conta>();
        }
    }
}
