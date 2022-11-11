using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDGofCommand
{
    public class FinalizadorPedido : ICommand
    {
        private Pedido pedido;

        public FinalizadorPedido(Pedido pedido)
        {
            this.pedido = pedido;
        }

        public void Executar()
        {
            Console.WriteLine($"Finalizando o pedido do cliente {pedido.Cliente}");
            pedido.Finalizar();
        }
    }
}
