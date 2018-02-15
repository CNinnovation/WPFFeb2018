using System;
using System.Collections.Generic;
using System.Text;

namespace BooksLib.Services
{

    public class UrlService
    {
        public string BaseAddress => "http://localhost:55427/";

        public string BooksApi => $"api/Books/";
    }
}
