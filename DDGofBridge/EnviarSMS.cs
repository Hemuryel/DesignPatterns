using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDGofBridge
{
    internal class EnviarSMS : IEnviador
    {
        public void Enviar(IMensagem mensagem)
        {
            Console.WriteLine("Enviando a mensagem por SMS");
            Console.WriteLine(mensagem.Formatar());
        }
    }
}
