using System;

namespace DDGofProxy
{
    //RealSubject
    //Objeto que queremos usar de forma mais eficiente usando a classe proxy
    public class PastaCompartilhada : IPastaCompartilhada
    {
        public void OperacaoDeLeituraGravacao()
        {
            //define operação a ser realizada na pasta Real 
            Console.WriteLine("### Operação de Leitura e Escrita " +
                "na pasta compartilhada ###");
        }
    }
}
