using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDGofTemplateMethodReport
{
    public class ComplexReport : Report
    {
        protected override void Body(IList<Conta> contas)
        {
            foreach (Conta c in contas)
            {
                Console.WriteLine(c.Nome + " - " + c.Numero + " - " + c.Agencia + " - " + c.Saldo);
            }
        }

        protected override void Footer()
        {
            Console.WriteLine("banco@xyz.com.br");
            Console.WriteLine(DateTime.Now);
        }

        protected override void Header()
        {
            Console.WriteLine("Banco XYZ");
            Console.WriteLine("Avenida Paulista, 1234");
            Console.WriteLine("(11) 1234-5678");
        }
    }
}
