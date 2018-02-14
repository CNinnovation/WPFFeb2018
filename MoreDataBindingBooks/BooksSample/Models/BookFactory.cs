using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksSample.Models
{
    public class BookFactory
    {

        public IEnumerable<Book> GetBooks() =>
            new List<Book>()
            {
                new Book("Professional C# 5", "Wrox Press", "374782347", "Christian Nagel", "Jay Glynn", "Morgan Skinner"),
                new Book("Professional C# 6", "Wrox Press", "3848234342", "Christian Nagel"),
                new Book("Enterprise Services", "Addison Wesley", "34787234", "Christian Nagel")
            };
    }
}
