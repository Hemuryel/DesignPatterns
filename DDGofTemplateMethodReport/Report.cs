using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDGofTemplateMethodReport
{
    public abstract class Report
    {
        protected abstract void Header();
        protected abstract void Body(IList<Conta> contas);
        protected abstract void Footer();

        public void Print(IList<Conta> contas)
        {
            Header();
            Body(contas);
            Footer();
        }
    }
}
