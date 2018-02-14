using BooksSample.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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

namespace BooksSample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ObservableCollection<Book> _books = new ObservableCollection<Book>(new BookFactory().GetBooks());
        public MainWindow()
        {
            InitializeComponent();

            //var cvs = new CollectionViewSource();
            //cvs.Source = _books;
            //cvs.View.Filter = o => (o as Book).Publisher == "Wrox Press";
            //DataContext = cvs;
            DataContext = _books;


            ICollectionView viewToASource = CollectionViewSource.GetDefaultView(_books);

            // normal
           // viewToASource.Filter = o => (o as Book).Publisher == "Wrox Press";

            // old
            viewToASource.Filter = new Predicate<object>(FilterByPublisher);

        }

        private bool FilterByPublisher(object o)
        {
            if (o is Book book)
            {
                if (book.Publisher == "Wrox Press")
                {
                    return true;
                }
            }
            return false;
        }

        private void OnAddBook(object sender, RoutedEventArgs e)
        {
            _books.Add(new Book("Professional C# 8", "Wrox Press", "3478234", "Christian nagel"));
        }

        private void OnChangeBook(object sender, RoutedEventArgs e)
        {
            var book = _books.Single(b => b.Title == "Professional C# 6");
            book.Title = "Professional C# 7";
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
