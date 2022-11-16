using System;

namespace DDGofMediator
{
    class Program
    {
        /* Mediator
         * 
         * define um objeto que encapsula a forma como um conjunto de objetos interage
         */
        static void Main(string[] args)
        {
            FacebookGroupMediator facebookMediator = 
                new ConcreteFacebookGroupMediator();

            User macoratti = new ConcreteUser(facebookMediator, "Macoratti");
            User miriam = new ConcreteUser(facebookMediator, "Miriam");
            User jessica = new ConcreteUser(facebookMediator, "Jessica");
            User yuri = new ConcreteUser(facebookMediator, "Yuri");

            facebookMediator.RegisterUser(macoratti);
            facebookMediator.RegisterUser(miriam);
            facebookMediator.RegisterUser(jessica);
            facebookMediator.RegisterUser(yuri);
            
            macoratti.Send("O canal macoratti.net " +
                "Esta apresentando uma serie sobre Padrões de Projetos");

            yuri.Send("Onde posso encontrar os vídeos ?");

            macoratti.Send("Veja a playist 'Design Patterns'");
            
            Console.Read();
        }
    }
}
