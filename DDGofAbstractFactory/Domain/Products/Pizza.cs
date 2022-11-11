using DDGofAbstractFactory.Domain.Enums;

namespace DDGofAbstractFactory.Domain.Products
{
    //AbstractProductB
    public abstract class Pizza : MassaBase
    {
        public Pizza(string nome, TipoMassa tipo) : base(nome, tipo)
        {
        }
    }
}
