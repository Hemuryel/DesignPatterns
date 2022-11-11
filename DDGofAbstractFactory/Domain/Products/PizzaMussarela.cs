namespace DDGofAbstractFactory.Domain.Products
{
    //ProductB2
    public sealed class PizzaMussarela : Pizza
    {
        public PizzaMussarela() : base("Pizza Mussarela", Enums.TipoMassa.Pizza)
        {
            Ingredientes.Add("Queijo mussarela gratinado e molho de tomate");
        }
    }
}
