using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDGofChainOfResponsabilityResponse
{
    public interface IResponse
    {
        void Response(Request req, Conta conta);
    }
}
