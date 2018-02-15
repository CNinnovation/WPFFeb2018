using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionSample
{
    public class MyController
    {
        private readonly IGreetingService _greetingService;
        public MyController(IGreetingService greetingService)
        {
            _greetingService = greetingService;
        }

        public string Index(string name)
        {
            if (name == null) throw new ArgumentNullException(nameof(name));

            string result = _greetingService.Greet(name);
            return $"the answer from the service: {result}";          
        }
    }
}
