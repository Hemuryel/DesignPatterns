using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDGofStrategyInvestimento
{
    internal class RealizadorInvestimentos
    {
        public void Realizar(Conta conta, IInvestimento investimento)
        {
            double resultado = investimento.Calcular(conta);
            double deposito = resultado * 0.75;

            conta.Depositar(deposito);
            Console.WriteLine("Novo saldo: " + conta.Saldo);
        }
    }
}
