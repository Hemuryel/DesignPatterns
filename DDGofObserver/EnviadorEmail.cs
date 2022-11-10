using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDGofObserver
{
    public class EnviadorEmail : IAcaoAposGerarNota
    {
        public void EnviarEmail(NotaFiscal nf)
        {
            Console.WriteLine("E-mail enviado!");
        }

        public void Executar(NotaFiscal nf)
        {
            EnviarEmail(nf);
        }
    }
}
