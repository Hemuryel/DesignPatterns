using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDGofChainOfResponsabilityResponse
{
    public class ResponsePercent : IResponse
    {
        public IResponse OutraResposta { get; }

        public ResponsePercent()
        {
            this.OutraResposta = null;
        }

        public ResponsePercent(IResponse outraResposta)
        {
            this.OutraResposta = outraResposta;
        }

        public void Response(Request request, Conta conta)
        {
            if (request.Format == Format.PERCENT)
            {
                Console.WriteLine(conta.Titular + "%" + conta.Saldo);
            }
            else
            {
                OutraResposta.Response(request, conta);
            }
        }
    }
}
