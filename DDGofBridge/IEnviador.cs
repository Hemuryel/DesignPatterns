using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDGofBridge
{
    public interface IEnviador
    {
        public void Enviar(IMensagem mensagem);
    }
}
