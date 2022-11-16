using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace DDGofMediator
{
    public class Program
    {
        /* Mediator
         * 
         * define um objeto que encapsula a forma como um conjunto de objetos interage
         */

        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
