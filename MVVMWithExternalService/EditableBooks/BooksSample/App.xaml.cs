using BooksLib.Models;
using BooksLib.Services;
using BooksLib.ViewModels;
using BooksSample.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace BooksSample
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            RegisterServices();
            base.OnStartup(e);
        }

        private void RegisterServices()
        {
            var services = new ServiceCollection();
            services.AddTransient<BooksViewModel>();
            services.AddSingleton<IBooksService, BooksService>();
            services.AddSingleton<HttpBooksClientService>();
            services.AddSingleton<UrlService>();
            // services.AddSingleton<IBooksService, HttpBooksService>();
            services.AddSingleton<IDialogService, WPFDialogService>();
            Container = services.BuildServiceProvider();
        }

        public IServiceProvider Container { get; private set; }
    }
}
