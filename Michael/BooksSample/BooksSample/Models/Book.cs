namespace BooksSample.Models
{
    public class Book
    {
        public Book(string title, string publisher, string isbn)
        {
            Title = title;
            Publisher = publisher;
            Isbn = isbn;
        }

        public string Title { get; set; }
        public string Publisher { get; set; }
        public string Isbn { get; set; }

        public override string ToString() => Title;
    }
}
