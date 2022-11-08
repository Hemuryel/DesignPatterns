using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDGofObserver
{
    public class NotaFiscalDAO : AcaoAposGerarNota
    {
        public void SalvarBanco(NotaFiscal nf)
        {
            Console.WriteLine("Salvo no banco");
        }

        public void Executar(NotaFiscal nf)
        {
            SalvarBanco(nf);
        }
    }
}
