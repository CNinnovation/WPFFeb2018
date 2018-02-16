using System.Collections.Generic;
using System.Threading.Tasks;
using BooksLib.Models;

namespace BooksLib.Services
{
    public interface IBooksService
    {
        Task<IEnumerable<Book>> GetBooksAsync();
    }
}