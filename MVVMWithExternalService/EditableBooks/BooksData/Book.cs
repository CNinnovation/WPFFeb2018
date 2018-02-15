using System.ComponentModel.DataAnnotations;

namespace BooksData
{
    public class Book 
    {
        public Book()
        {

        }
        public int BookId { get; set; }

        [StringLength(50)]
        public string Title { get; set; }
        public string Publisher { get; set; }
        public string Isbn { get; set; }
    }
}
