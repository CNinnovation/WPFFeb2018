using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionSample
{
    class Program
    {
        static void Main(string[] args)
        {
            RegisterServices();

            var controller = ServiceProvider.GetService<MyController>();
            string result = controller.Index("Stephanie");
            Console.WriteLine(result);
        }

        static void RegisterServices()
        {
            var services = new ServiceCollection();
            services.AddSingleton<IGreetingService, GreetingService>();
            services.AddTransient<MyController>();
            ServiceProvider = services.BuildServiceProvider();
        }

        public static IServiceProvider ServiceProvider { get; private set; }
    }
}
