using DDGofAbstractFactory.Domain.Enums;
using DDGofAbstractFactory.Domain.Products;
using System;

namespace DDGofAbstractFactory.Factory.AbstractFactory
{
    //ConcreteFactory1
    public sealed class BoloFactory : MassasAbstractFactory
    {
        public override MassaBase CriarMassa(TipoMassa tipoMassa)
        {
            var tipoBolo = (TipoBolo)tipoMassa;

            switch (tipoBolo)
            {
                case TipoBolo.Chocolate:
                    {
                        return new BoloChocolate();
                    }
                case TipoBolo.Laranja:
                    {
                        return new BoloLaranja();
                    }
                default:
                    throw new ArgumentOutOfRangeException("Tipo não implementado");
            }
        }

    }
}
