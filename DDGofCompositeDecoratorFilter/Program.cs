namespace DDGofCompositeDecoratorFilter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //menor que 100
            Conta conta1 = new Conta();
            conta1.DataAbertura = new DateTime(2020, 11, 9);
            conta1.Valor = 97;

            //não atende
            Conta conta2 = new Conta();
            conta2.DataAbertura = new DateTime(2021, 11, 9);
            conta2.Valor = 500000;

            //> 500.000
            Conta conta3 = new Conta();
            conta3.DataAbertura = new DateTime(2021, 11, 9);
            conta3.Valor = 500001;

            //mesmo mês
            Conta conta4 = new Conta();
            conta4.DataAbertura = new DateTime(2022, 11, 9);
            conta4.Valor = 101;

            IList<Conta> contas = new List<Conta>();
            contas.Add(conta1);
            contas.Add(conta2);
            contas.Add(conta3);
            contas.Add(conta4);

            Filtro filtro = new FiltroMaiorQue500MilReais(new FiltroMenorQue100Reais(new FiltroMesmoMes()));

            var teste = filtro.Filtrar(contas);

            foreach(var obj in teste)
            {
                Console.WriteLine(obj.Valor);
            }
        }
    }
}