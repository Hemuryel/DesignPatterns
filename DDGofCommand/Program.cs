namespace DDGofCommand
{
    internal class Program
    {
        /* Command
         * 
         * encapsular toda informação necessária para executar uma ação ou acionar um evento em um momento posterior
         * ex: fila de processos
         */

        static void Main(string[] args)
        {
            FilaDeTrabalho fila = new FilaDeTrabalho();
            Pedido pedido1 = new Pedido("Mauricio", 100.0);
            Pedido pedido2 = new Pedido("Marcelo", 100.0);
            fila.Adicionar(new PagadorPedido(pedido1));
            fila.Adicionar(new PagadorPedido(pedido2));
            fila.Adicionar(new FinalizadorPedido(pedido1));
            fila.Adicionar(new FinalizadorPedido(pedido2));

            fila.Processar();
        }
    }
}