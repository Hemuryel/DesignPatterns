using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDGofBridge
{
    public interface IMensagem
    {
        IEnviador Enviador { get; set; }
        void Enviar();
        string Formatar();
    }
}
