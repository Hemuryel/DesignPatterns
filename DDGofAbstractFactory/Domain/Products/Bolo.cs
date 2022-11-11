using DDGofAbstractFactory.Domain.Enums;

namespace DDGofAbstractFactory.Domain.Products
{
    //AbstractProductA
    public abstract class Bolo : MassaBase
    {
        public Bolo(string nome, TipoMassa tipo) : base(nome, tipo)
        {
        }
    }
}
