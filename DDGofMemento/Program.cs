namespace DDGofMemento
{
    internal class Program
    {
        /* Memento
         * 
         * recuperar estado anterior
         */

        static void Main(string[] args)
        {
            Historico historico = new Historico();

            Contrato contrato = new Contrato(DateTime.Now, "Victor", TipoContrato.Novo);
            historico.Adicionar(contrato.SalvarEstado());

            contrato.Avancar();
            historico.Adicionar(contrato.SalvarEstado());

            contrato.Avancar();
            historico.Adicionar(contrato.SalvarEstado());

            Console.WriteLine(contrato.Tipo);
            Console.WriteLine(historico.GetEstado(0).Contrato.Tipo);
            Console.WriteLine(historico.GetEstado(1).Contrato.Tipo);
            Console.WriteLine(historico.GetEstado(2).Contrato.Tipo);
        }
    }
}