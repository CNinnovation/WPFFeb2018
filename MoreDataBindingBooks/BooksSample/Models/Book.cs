using System.Collections.Generic;

namespace BooksSample.Models
{
    public class Book
    {
        public Book()
        {

        }
        public Book(string title, string publisher, string isbn, params string[] authors)
        {
            Title = title;
            Publisher = publisher;
            Isbn = isbn;
            Authors = new List<string>(authors);
        }

        public string Title { get; set; }
        public string Publisher { get; set; }
        public string Isbn { get; set; }
        public List<string> Authors { get; }

        public override string ToString() => Title;
    }
}
