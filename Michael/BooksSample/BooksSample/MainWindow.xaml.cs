using BooksSample.Models;
using System;
using System.Collections.Generic;
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
        public MainWindow()
        {
            InitializeComponent();
        }

       
        private void addBook(object sender, RoutedEventArgs e)
        {
            //Book b = new Book("","","");
            

            ListBoxItem lbi = new ListBoxItem();
            lbi.Content = new Book("Test Book", "Lesin", "999999999-99999");
            BookList.Items.Add(lbi);
        }
    }
}
