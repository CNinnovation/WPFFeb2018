using System.Collections.Generic;

namespace BooksSample.Models
{
    public class BookFactory
    {
        public IEnumerable<Book> GetBooks() =>
            new List<Book>()
            {
                new Book("Professional C# 5", "Wrox Press", "374782347", "Christian Nagel", "Jay Glynn", "Morgan Skinner"),
                new Book("Professional C# 6", "Wrox Press", "3848234342", "Christian Nagel"),
                new Book("Enterprise Services", "Addison Wesley", "34787234", "Christian Nagel"),
                new Book("Beginning Visual C# 2010", "Wrox Press", "3848438", "Karli Watson", "Christian Nagel", "Jacob Hammer Pedersen", "Jon D. Reid", "Morgan Skinner")
            };
    }
}
