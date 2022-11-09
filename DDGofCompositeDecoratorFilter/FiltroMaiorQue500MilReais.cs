using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDGofCompositeDecoratorFilter
{
    public class FiltroMaiorQue500MilReais : Filtro
    {
        public FiltroMaiorQue500MilReais() : base()
        {

        }

        public FiltroMaiorQue500MilReais(Filtro outroFiltro) : base(outroFiltro)
        {

        }

        public override IList<Conta> Filtrar(IList<Conta> contas)
        {
            IList<Conta> filtrada = new List<Conta>();

            foreach(Conta c in contas)
            {
                if(c.Valor > 500000)
                    filtrada.Add(c);
            }

            foreach(Conta c in Proximo(contas))
            {
                filtrada.Add(c);
            }

            return filtrada;
        }
    }
}
