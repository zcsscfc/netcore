using System;
using Microsoft.Extensions.DependencyInjection;

namespace netCoreDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IServiceCollection services = new ServiceCollection().AddSingleton<IFoo, Foo>()
            .AddSingleton<IBar>(new Bar())
            .AddSingleton<IBaz>(_ => new Baz())
            .AddSingleton<IGux, Gux>();

            IServiceProvider serviceProvider = services.BuildServiceProvider();

            Console.WriteLine("serviceProvider.GetService<IFoo>(): {0}", serviceProvider.GetService<IFoo>());
            Console.WriteLine("serviceProvider.GetService<IBar>(): {0}", serviceProvider.GetService<IBar>());
            Console.WriteLine("serviceProvider.GetService<IBaz>(): {0}", serviceProvider.GetService<IBaz>());
            Console.WriteLine("serviceProvider.GetService<IGux>(): {0}", serviceProvider.GetService<IGux>());
            Console.ReadKey();
        }
    }
}
