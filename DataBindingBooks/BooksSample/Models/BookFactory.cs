using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksSample.Models
{
    public class BookFactory
    {
        public Book GetTheBook() => new Book { Title = "Professional C# 6", Publisher = "Wrox Press", Isbn = "374782347" };

        public IEnumerable<Book> GetBooks() =>
            new List<Book>()
            {
                new Book { Title = "Professional C# 6", Publisher = "Wrox Press", Isbn = "374782347" },
                new Book { Title = "Enterprise Services", Publisher = "Addison Wesley", Isbn = "372348342347" },
                new Book { Title = "Professional C# 7", Publisher = "Wrox Press", Isbn = "73589" },
                new Book { Title = "Beginning Visual C#", Publisher = "Wrox Press", Isbn = "45494989" },
            };
    }
}
