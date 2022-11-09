using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDGofChainOfResponsabilityResponse
{
    public class ResponseCSV : IResponse
    {
        public IResponse OutraResposta { get; }

        public ResponseCSV()
        {
            this.OutraResposta = null;
        }

        public ResponseCSV(IResponse outraResposta)
        {
            OutraResposta = outraResposta;
        }   

        public void Response(Request request, Conta conta)
        {
            if (request.Format == Format.CSV)
            {
                Console.WriteLine(conta.Titular + ";" + conta.Saldo);
            }
            else
            {
                OutraResposta.Response(request, conta);
            }
        }
    }
}
