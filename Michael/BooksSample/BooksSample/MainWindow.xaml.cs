using BooksSample.Models;
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

namespace BooksSample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ObservableCollection<Book> BookList = new ObservableCollection<Book>(new Book().GetBooks());
        public MainWindow()
        {
            InitializeComponent();
            DataContext = BookList;
        }

        private void addBook(object sender, RoutedEventArgs e)
        {
            //Book b = new Book("","","");
            //ListBoxItem lbi = new ListBoxItem();
            //lbi.Content = new Book("Test Book", "Lesin", "999999999-99999");
            //ItemContainerTemplate t = new ItemContainerTemplate();
            BookList.Add(new Book(txtTitle.Text, txtPublisher.Text, txtISBN.Text));
        }

        public static readonly RoutedUICommand deleteBook = new RoutedUICommand("Delete the selected Book", "DoSomething", typeof(MainWindow));

        private void OnDeleteBook(object sender, ExecutedRoutedEventArgs e)
        {
            ObservableCollection<Book> TempBookList = new ObservableCollection<Book>(BookList);
            if (BookList.Count > 0)
            {
                foreach (var item in TempBookList)
                {
                    if (item.Id == (int)e.Parameter)
                    {
                        BookList.Remove(item);
                    }
                }
                TempBookList = BookList;

            }
        }

        private void OnDeleteBookCanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            if (BookList.Count > 0)
            {
                e.CanExecute = true;
            }
            else
            {
                e.CanExecute = false;
            }
        }


        public static readonly RoutedUICommand editBook = new RoutedUICommand("Edit the selected Book", "DoSomething", typeof(MainWindow));
        private void OnEditBook(object sender, ExecutedRoutedEventArgs e)
        {
            foreach (var item in BookList)
            {
                if (item.Id == (int)e.Parameter)
                {
                    item.Title = txtTitle.Text;
                    item.Publisher = txtPublisher.Text;
                    item.Isbn = txtISBN.Text;
                }
            }
        }

        public static readonly RoutedUICommand changeColor = new RoutedUICommand("Change Color", "DoSomething", typeof(MainWindow));
        private void OnChangeColor(object sender, ExecutedRoutedEventArgs e)
        {
            List<Brush> BrushList = new List<Brush>();
            BrushList.Add((Brush)(new BrushConverter().ConvertFromString("#3366ff")));
            BrushList.Add((Brush)(new BrushConverter().ConvertFromString("#33cccc")));
            BrushList.Add((Brush)(new BrushConverter().ConvertFromString("#00ff00")));
            BrushList.Add((Brush)(new BrushConverter().ConvertFromString("#669900")));
            BrushList.Add((Brush)(new BrushConverter().ConvertFromString("#ffcc66")));
            BrushList.Add((Brush)(new BrushConverter().ConvertFromString("#ff3300")));
            BrushList.Add((Brush)(new BrushConverter().ConvertFromString("#cc6699")));
            BrushList.Add((Brush)(new BrushConverter().ConvertFromString("#cc66ff")));
            BrushList.Add((Brush)(new BrushConverter().ConvertFromString("#ffffff")));
            BrushList.Add((Brush)(new BrushConverter().ConvertFromString("#996633")));
            BrushList.Add((Brush)(new BrushConverter().ConvertFromString("#000066")));
            BrushList.Add((Brush)(new BrushConverter().ConvertFromString("#9EB01C")));

            Random x = new Random();
            BookListItems.Background = BrushList[x.Next(BrushList.Count)];

            //foreach (var item in BookList)
            //{
            //    if (item.Id == (int)e.Parameter)
            //    {
            //        item.Background = BrushList[x.Next(BrushList.Count)];
            //    }
            //}


        }

    }
}
