using DDGofAbstractFactory.Domain.Enums;
using DDGofAbstractFactory.Domain.Products;
using System;

namespace DDGofAbstractFactory.Factory.AbstractFactory
{
    //ConcreteFactory2
    public sealed class PizzaFactory : MassasAbstractFactory
    {
        public override MassaBase CriarMassa(TipoMassa tipoMassa)
        {
            var tipoPizza = (TipoPizza)tipoMassa;

            switch (tipoPizza)
            {
                case TipoPizza.Mussarela:
                {
                    return new PizzaMussarela();
                }
                case TipoPizza.Calabreza:
                {
                   return new PizzaCalabreza();
                }
                default:
                 throw new ArgumentOutOfRangeException("Tipo não implementado");
            }
        }
    }
}
