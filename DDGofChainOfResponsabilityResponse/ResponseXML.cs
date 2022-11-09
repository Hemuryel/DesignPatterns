using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDGofChainOfResponsabilityResponse
{
    public class ResponseXML : IResponse
    {
        public IResponse OutraResposta { get; }

        public ResponseXML()
        {
            this.OutraResposta = null;
        }

        public ResponseXML(IResponse outraResposta)
        {
            this.OutraResposta = outraResposta;
        }

        public void Response(Request request, Conta conta)
        {
            if (request.Format == Format.XML)
            {
                Console.WriteLine("<conta><titular>" + conta.Titular + "</titular><saldo>" + conta.Saldo + "</saldo></conta>");
            }
            else
            {
                OutraResposta.Response(request, conta);
            }
        }
    }
}
