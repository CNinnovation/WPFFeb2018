using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using BooksLib.Models;
using Newtonsoft.Json;

namespace BooksLib.Services
{
    public class HttpBooksClientService : HttpClientService<Book>
    {
        public HttpBooksClientService(UrlService urlService)
            : base(urlService)
        {

        }
    }

    public class HttpBooksService : IBooksService
    {
        private HttpBooksClientService _booksService;
        private UrlService _urlService;
        public HttpBooksService(HttpBooksClientService booksService, UrlService urlService)
        {
            _booksService = booksService;
            _urlService = urlService;
        }

        public async Task<IEnumerable<Book>> GetBooksAsync()
        {
            var books = await _booksService.GetAllAsync(_urlService.BooksApi);
            return books;
            //HttpClient client = new HttpClient();
            //HttpResponseMessage response = await client.GetAsync("http://localhost:55427/api/Books");
            //response.EnsureSuccessStatusCode();
            //string json = await response.Content.ReadAsStringAsync();
            //IEnumerable<Book> books = JsonConvert.DeserializeObject<IEnumerable<Book>>(json);
            //return books;
        }
    }
}
