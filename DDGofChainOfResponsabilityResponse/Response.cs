using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDGofChainOfResponsabilityResponse
{
    public class Response
    {
        public Response(Request request, Conta conta)
        {
            //Chain Of Responsability
            IResponse response = new ResponseCSV(new ResponseXML(new ResponsePercent()));

            response.Response(request, conta);
        }
    }
}
