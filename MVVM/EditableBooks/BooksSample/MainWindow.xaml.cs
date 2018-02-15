using BooksLib.Services;
using BooksLib.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Extensions.DependencyInjection;

namespace BooksSample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            // ViewModel = new BooksViewModel(new BooksService());
            ViewModel = (Application.Current as App).Container.GetService<BooksViewModel>();

            InitializeComponent();
            DataContext = this;
        }

        public BooksViewModel ViewModel { get; }


        //private void OnChangeBook(object sender, RoutedEventArgs e)
        //{
        //    var book = _books.Single(b => b.Title == "Professional C# 6");
        //    book.Title = "Professional C# 7";
        //}

        //private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        //{

        //}
    }
}
