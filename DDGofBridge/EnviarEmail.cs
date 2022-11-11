using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDGofBridge
{
    internal class EnviarEmail : IEnviador
    {
        public void Enviar(IMensagem mensagem)
        {
            Console.WriteLine("Enviando a mensagem por e-mail");
            Console.WriteLine(mensagem.Formatar());
        }
    }
}
