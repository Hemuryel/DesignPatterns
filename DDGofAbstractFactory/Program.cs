namespace DDGofAbstractFactory
{
    using DDGofAbstractFactory.Domain.Enums;
    using DDGofAbstractFactory.Domain.Products;
    using DDGofAbstractFactory.Factory.AbstractFactory;
    using System;

    public class Program
    {
        /* Abstract Factory
         * 
         * permite a criação de famílias de objetos relacionados ou dependentes 
         * por meio de uma única interface e sem que a classe concreta seja especificada
         */

        static void Main(string[] args)
        {
            //Obtém as fábricas
            var boloFactory = MassasAbstractFactory.CriarFabricaMassas(TipoMassa.Bolo);
            var pizzaFactory = MassasAbstractFactory.CriarFabricaMassas(TipoMassa.Pizza);

            //cria os objetos com base no tipo : bolo
            var bolo1 = boloFactory.CriarMassa((TipoMassa)TipoBolo.Chocolate);
            var bolo2 = boloFactory.CriarMassa((TipoMassa)TipoBolo.Laranja);

            //cria os objetos com base no tipo : pizza
            var pizza1 = pizzaFactory.CriarMassa((TipoMassa)TipoPizza.Mussarela);
            var pizza2 = pizzaFactory.CriarMassa((TipoMassa)TipoPizza.Calabreza);

            //exibe os detalhes
            ExibirDetalhes(bolo1);
            ExibirDetalhes(bolo2);
            ExibirDetalhes(pizza1);
            ExibirDetalhes(pizza2);

            Console.ReadLine();
        }

        static void ExibirDetalhes(MassaBase massaBase)
        {
            Console.WriteLine($"Tipo : {massaBase.TipoMassa}");
            Console.WriteLine(massaBase.Nome);
            Console.WriteLine(massaBase.Ingredientes[0].ToString());
            Console.WriteLine("\n"); 
        }
    }
}