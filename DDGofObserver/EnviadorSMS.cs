using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDGofObserver
{
    public class EnviadorSMS : IAcaoAposGerarNota
    {
        public void EnviarSMS(NotaFiscal nf)
        {
            Console.WriteLine("SMS enviado!");
        }

        public void Executar(NotaFiscal nf)
        {
            EnviarSMS(nf);
        }
    }
}
