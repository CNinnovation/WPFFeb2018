using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionSample
{
    public class MyController
    {
        public string Index(string name)
        {
            var greetingService = new GreetingService();
            string result = greetingService.Greet(name);
            return $"the answer from the service: {result}";          
        }
    }
}
