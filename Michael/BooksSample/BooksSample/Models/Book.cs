using System.Collections.ObjectModel;

namespace BooksSample.Models
{
    public class Book
    {
        public static int _id { get; set; }

        public Book()
        {

        }

        public Book(string title, string publisher, string isbn)
        {
            Id = _id;
            Title = title;
            Publisher = publisher;
            Isbn = isbn;
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string Publisher { get; set; }
        public string Isbn { get; set; }

        public override string ToString() => Title;

        public ObservableCollection<Book> GetBooks()
        {
            ObservableCollection<Book> ret = new ObservableCollection<Book>();
            ret.Add(new Book("Professional C# 5", "Wrox Press1", "13478234"));
            _id++;
            ret.Add(new Book("Professional C# 6", "Wrox Press2", "23478234"));
            _id++;
            ret.Add(new Book("Professional C# 7", "Wrox Press3", "33478234"));
            _id++;
            ret.Add(new Book("Professional C# 8", "Wrox Press4", "43478234"));
            return ret;
        }
    }
}
