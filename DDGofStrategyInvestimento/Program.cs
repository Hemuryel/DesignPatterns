namespace DDGofStrategyInvestimento
{
    /* Exercício: tipos de investimento

        "CONSERVADOR"
            que sempre retorna 0.8% do valor investido;

        "MODERADO"
            que tem 50% de chances de retornar 2.5%, 
            e 50% de chances de retornar 0.7%;

        "ARROJADO"
            que tem 20% de chances de retornar 5%, 
            30% de chances de retornar 3%, 
            e 50% de chances de retornar 0.6%.
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            Conta conta = new Conta();
            conta.Depositar(500.0);

            IInvestimento conservador = new Conservador();

            RealizadorInvestimentos realizador = new RealizadorInvestimentos();

            realizador.Realizar(conta, conservador);
        }
    }
}