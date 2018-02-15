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
            var controller = new MyController(new GreetingService());  //injection
            string result = controller.Index("Stephanie");
            Console.WriteLine(result);
        }
    }
}
