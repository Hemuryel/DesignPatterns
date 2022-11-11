using DDGofAbstractFactory.Domain.Enums;
using DDGofAbstractFactory.Domain.Products;
using System;
namespace DDGofAbstractFactory.Factory.AbstractFactory
{
    //AbstractFactory
    public abstract class MassasAbstractFactory
    {
        public abstract MassaBase CriarMassa(TipoMassa tipoMassa);
        public static MassasAbstractFactory CriarFabricaMassas(TipoMassa tipoMassa)
        {
            switch (tipoMassa)
            {
                case TipoMassa.Pizza:
                {
                    return new PizzaFactory();
                }
                case TipoMassa.Bolo:
                {
                    return new BoloFactory();
                }
                default:
                    throw new ArgumentOutOfRangeException(nameof(tipoMassa), tipoMassa, null);
            }
        }
    }
}
