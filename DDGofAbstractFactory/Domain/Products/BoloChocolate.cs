using System.Collections;

namespace DDGofAbstractFactory.Domain.Products
{
    //ProductA1
    public sealed class BoloChocolate : Bolo
    {
        public BoloChocolate() : base("Bolo de Chocolate", Enums.TipoMassa.Bolo)
        {
            Ingredientes.Add("Com cobertura de chocolate Nestlé");
        }        
    }
}
