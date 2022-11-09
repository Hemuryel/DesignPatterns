using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDGofTemplateMethodReport
{
    public class SimpleReport : Report
    {
        protected override void Body(IList<Conta> contas)
        {
            foreach (Conta c in contas)
            {
                Console.WriteLine(c.Nome + " - " + c.Saldo);
            }
        }

        protected override void Footer()
        {
            Console.WriteLine("(11) 1234-5678");
        }

        protected override void Header()
        {
            Console.WriteLine("Banco XYZ");
        }
    }
}
