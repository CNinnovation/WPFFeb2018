using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionSample
{
    public class GreetingService
    {
        public string Greet(string name) => $"Hello, {name}";
    }
}
