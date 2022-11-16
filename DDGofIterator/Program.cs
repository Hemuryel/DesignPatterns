using System;

namespace DDGofIterator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Cria uma coleção
            ConcreteCollection colecao = new ConcreteCollection();

            colecao.AddCliente(new Cliente("Pedro", 10));
            colecao.AddCliente(new Cliente("Maria", 11));
            colecao.AddCliente(new Cliente("Manoel", 12));
            colecao.AddCliente(new Cliente("Miriam", 13));
            colecao.AddCliente(new Cliente("Jefferson", 14));

            // Cria o iterator que vai encapsular a iteração
            Iterator iterator = colecao.CreateIterator();

            Console.WriteLine("### Usando o padrão Iterador ###\n");
            Console.WriteLine("Pressione algo para iniciar");
            Console.ReadKey();

            //  iterator      
            Console.WriteLine("Iterando sobre a coleção de Clientes :\n ");

            for (Cliente cliente = iterator.First(); !iterator.IsDone; cliente = iterator.Next())
            {
                Console.WriteLine($"ID : {cliente.Id} & Nome : {cliente.Nome}");
            }
            Console.Read();
        }
    }
}
