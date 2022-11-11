using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDGofCommand
{
    public class PagadorPedido : ICommand
    {
        private Pedido pedido;

        public PagadorPedido(Pedido pedido)
        {
            this.pedido = pedido;
        }

        public void Executar()
        {
            Console.WriteLine($"Pagando o pedido do cliente {pedido.Cliente}");
            pedido.Pagar();
        }
    }
}
