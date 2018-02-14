using System.Collections.Generic;
using System.ComponentModel;
using TheBestMVVMFrameworkInTown.Core;

namespace BooksSample.Models
{
    public class Book : BindableBase
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

        private string _title;

        public string Title
        {
            get => _title;
            set => SetProperty(ref _title, value);
        }

        private string _publisher;

        public string Publisher
        {
            get => _publisher;
            set => SetProperty(ref _publisher, value);
        }
        public string Isbn { get; set; }
        public List<string> Authors { get; }


        public override string ToString() => Title;
    }
}
