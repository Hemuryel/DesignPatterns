using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace AluraLoja
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var context = new LojaContext())
            {
                var serviceProvider = context.GetInfrastructure<IServiceProvider>();
                var loggerFactory = serviceProvider.GetService<ILoggerFactory>();
                loggerFactory.AddProvider(SqlLoggerProvider.Create());

                var cliente = context
                    .Clientes
                    .Include(c => c.EnderecoDeEntrega)
                    .FirstOrDefault();

                Console.WriteLine($"\n### Endereço de entrega: {cliente.EnderecoDeEntrega.Logradouro}");

                var produto = context
                    .Produtos
                    .Include(p => p.Compras)
                    .Where(p => p.Id == 12)
                    .FirstOrDefault();

                // Carregamento explícito
                context.Entry(produto)
                    .Collection(p => p.Compras)
                    .Query()
                    .Where(c => c.Preco > 10)
                    .Load();

                Console.WriteLine($"Mostrando as compras do produto {produto.Nome}");
                foreach (var item in produto.Compras)
                {
                    Console.WriteLine(item.Quantidade);
                }
            }
        }

        private static void ExibirProdutosDaPromocao()
        {
            using (var context = new LojaContext())
            {
                var serviceProvider = context.GetInfrastructure<IServiceProvider>();
                var loggerFactory = serviceProvider.GetService<ILoggerFactory>();
                loggerFactory.AddProvider(SqlLoggerProvider.Create());

                var promocao = context
                    .Promocoes
                    .Include(p => p.Produtos)
                    .ThenInclude(pp => pp.Produto)
                    .FirstOrDefault();

                Console.WriteLine("\nMostrando os produtos da promoção...");
                foreach (var item in promocao.Produtos)
                {
                    Console.WriteLine(item.Produto);
                }
            }
        }

        private static void IncluirPromocao()
        {
            using (var context = new LojaContext())
            {
                var serviceProvider = context.GetInfrastructure<IServiceProvider>();
                var loggerFactory = serviceProvider.GetService<ILoggerFactory>();
                loggerFactory.AddProvider(SqlLoggerProvider.Create());

                var promocao = new Promocao();
                promocao.Descricao = "Queima Total Janeiro 2017";
                promocao.DataInicio = new DateTime(2017, 1, 1);
                promocao.DataTermino = new DateTime(2017, 1, 31);

                var produtos = context
                    .Produtos
                    .Where(p => p.Categoria == "Bebidas")
                    .ToList();

                foreach (var item in produtos)
                {
                    promocao.IncluirProduto(item);
                }

                context.Promocoes.Add(promocao);
                ExibirEntries(context.ChangeTracker.Entries());
                context.SaveChanges();
            }

            using (var context2 = new LojaContext())
            {
                var promocao = context2.Promocoes.FirstOrDefault();
                Console.WriteLine("\nMostrando os produtos da promoção...");
                foreach (var item in promocao.Produtos)
                {
                    Console.WriteLine(item.Produto);
                }
            }
        }

        private static void UmParaUm()
        {
            var fulano = new Cliente();
            fulano.Nome = "Fulano de Tal";
            fulano.EnderecoDeEntrega = new Endereco()
            {
                Numero = 12,
                Logradouro = "Rua dos Inválidos",
                Complemento = "Sobrado",
                Bairro = "Centro",
                Cidade = "Florianópolis"
            };

            using (var context = new LojaContext())
            {
                context.Clientes.Add(fulano);
                context.SaveChanges();
            }
        }

        private static void MuitosParaMuitos()
        {
            var p1 = new Produto() { 
                Nome = "Suco de Laranja", 
                Categoria = "Bebidas", 
                PrecoUnitario = 8.79, 
                Unidade = "Litros" };

            var p2 = new Produto()
            {
                Nome = "Café",
                Categoria = "Bebidas",
                PrecoUnitario = 12.45,
                Unidade = "Gramas"
            };

            var p3 = new Produto()
            {
                Nome = "Macarrão",
                Categoria = "Alimentos",
                PrecoUnitario = 4.23,
                Unidade = "Gramas"
            };

            var promocaoDePascoa = new Promocao();
            promocaoDePascoa.Descricao = "Páscoa Feliz";
            promocaoDePascoa.DataInicio = DateTime.Now;
            promocaoDePascoa.DataTermino = DateTime.Now.AddMonths(3);

            promocaoDePascoa.IncluirProduto(p1);
            promocaoDePascoa.IncluirProduto(p2);
            promocaoDePascoa.IncluirProduto(p3);

            using (var context = new LojaContext())
            {
                var serviceProvider = context.GetInfrastructure<IServiceProvider>();
                var loggerFactory = serviceProvider.GetService<ILoggerFactory>();
                loggerFactory.AddProvider(SqlLoggerProvider.Create());

                var promocao = context.Promocoes.Find(1);
                context.Promocoes.Remove(promocao);

                //context.Promocoes.Add(promocaoDePascoa);
                ExibirEntries(context.ChangeTracker.Entries());

                context.SaveChanges();
            }
        }

        //static void Main(string[] args)
        //{
        //    //GravarUsandoEntity();
        //    //RecuperarProdutos();
        //    //ExcluirProdutos();
        //    //RecuperarProdutos();
        //    //AtualizarProduto();

        //    using (var context = new LojaContext())
        //    {
        //        var serviceProvider = context.GetInfrastructure<IServiceProvider>();
        //        var loggerFactory = serviceProvider.GetService<ILoggerFactory>();
        //        loggerFactory.AddProvider(SqlLoggerProvider.Create());

        //        var produtos = context.Produtos.ToList();
        //        foreach (var p in produtos)
        //        {
        //            Console.WriteLine(p);
        //        }

        //        ExibirEntries(context.ChangeTracker.Entries());

        //        //var p1 = produtos.Last();
        //        //p1.Nome = "007";

        //        var novoProduto = new Produto()
        //        {
        //            Nome = "Desinfetante",
        //            Categoria = "Limpeza",
        //            PrecoUnitario = 2.99
        //        };
        //        context.Produtos.Add(novoProduto);

        //        ExibirEntries(context.ChangeTracker.Entries());

        //        context.SaveChanges();

        //        ExibirEntries(context.ChangeTracker.Entries());

        //        //var p1 = produtos.First();
        //        //p1.Nome = "Harry Potter";
        //        //context.SaveChanges();

        //        //Console.WriteLine("==========");
        //        //produtos = context.Produtos.ToList();
        //        //foreach (var p in produtos)
        //        //{
        //        //    Console.WriteLine(p);
        //        //}
        //    }
        //}

        private static void ExibirEntries(IEnumerable<EntityEntry> entries)
        {
            Console.WriteLine("==========");
            foreach (var e in entries)
            {
                Console.WriteLine(e.Entity.ToString() + " - " + e.State);
            }
        }

        private static void ExcluirProdutos()
        {
            using (var repo = new ProdutoDAOEntity())
            {
                IList<Produto> produtos = repo.Produtos();
                foreach (var item in produtos)
                {
                    repo.Remover(item);
                }
            }
        }

        private static void RecuperarProdutos()
        {
            using (var repo = new ProdutoDAOEntity())
            {
                IList<Produto> produtos = repo.Produtos();
                Console.WriteLine($"Foram encontrados {produtos.Count} produto(s).");
                foreach (var item in produtos)
                {
                    Console.WriteLine(item.Nome);
                }
            }
        }

        private static void GravarUsandoEntity()
        {
            Produto p = new Produto();
            p.Nome = "Harry Potter e a Ordem da Fênix";
            p.Categoria = "Livros";
            p.PrecoUnitario = 19.89;

            using (var repo = new ProdutoDAOEntity())
            {
                repo.Adicionar(p);
            }
        }

        private static void AtualizarProduto()
        {
            GravarUsandoEntity();
            RecuperarProdutos();

            using (var repo = new ProdutoDAOEntity())
            {
                Produto primeiro = repo.Produtos().First();
                primeiro.Nome = "Cassino Royale - Editado";
                repo.Atualizar(primeiro);
            }

            RecuperarProdutos();
        }
    }
}