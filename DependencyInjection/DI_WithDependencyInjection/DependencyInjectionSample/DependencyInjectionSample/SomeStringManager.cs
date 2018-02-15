using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionSample
{
    public class SomeStringManager
    {
        public string WorkWithAString(string s)
        {
            if (s.Length < 5)
            {
                return s.ToUpper();
            }
            else if (s.Length > 12)
            {
                return s.ToLower();
            }
            else
            {
                return "abc";
            }
        }
    }
}
