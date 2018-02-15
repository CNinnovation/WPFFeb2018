using BooksData;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace TestBooksData
{
    class Program
    {
        static void Main(string[] args)
        {
            RegisterServices();
            CreateDatabase();
           // CreateRecords();
            ReadRecords();
        }

        private static void ReadRecords()
        {
            var context = Container.GetService<BooksContext>();
            var books = context.Books.Where(b => b.Publisher == "Ravensburger");
            foreach (var book in books)
            {
                Console.WriteLine($"{book.Title} {book.Publisher}");
            }
        }

        private static void CreateRecords()
        {
            var context = Container.GetService<BooksContext>();
            context.Books.Add(
                new Book { Isbn = "234344", Title = "Kakerlakenkekse und Teerbonbons", Publisher = "Ravensburger" });
            context.Books.Add(
                new Book { Isbn = "374755", Title = "Rotzschleimtorte für alle", Publisher = "Ravensburger" });
            context.SaveChanges();
        }

        private static void RegisterServices()
        {
            string connectionString = @"server=(localdb)\mssqllocaldb;database=ETCBooks2;trusted_connection=true";
            var services = new ServiceCollection();
            services.AddDbContext<BooksContext>(options =>
            {
                options.UseSqlServer(connectionString);
            });
            Container = services.BuildServiceProvider();
        }

        public static IServiceProvider Container { get; private set; }

        private static void CreateDatabase()
        {
            var context = Container.GetService<BooksContext>();
            bool created = context.Database.EnsureCreated();
            Console.WriteLine($"database created {created}");

        }
    }
}
