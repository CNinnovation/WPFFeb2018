using BooksLib.Models;
using BooksLib.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TheBestMVVMFrameworkInTown.Core;
using TheBestMVVMFrameworkInTown.MVVM;

namespace BooksLib.ViewModels
{
    public class BooksViewModel : ViewModelBase
    {
        private readonly IBooksService _booksService;
        private readonly IDialogService _dialogService;
        private readonly ObservableCollection<Book> _books = new ObservableCollection<Book>();
        public BooksViewModel(IBooksService booksService, IDialogService dialogService)
        {
            _booksService = booksService;
            _dialogService = dialogService;

            // _books = new ObservableCollection<Book>(_booksService.GetBooks());
            Task t = RefreshBooksAsync();

            AddBooksCommand = new DelegateCommand(OnAddBook, CanAddBook);
            ShowMessageCommand = new DelegateCommand(OnShowMessage);
        }

        public async Task RefreshBooksAsync()
        {
            _books.Clear();
            var books = await _booksService.GetBooksAsync();
            foreach (var book in books)
            {
                _books.Add(book);
            }
        }

        private async void OnShowMessage()
        {
            await _dialogService.ShowMessageAsync("Hello from the View-Model");
        }

        public IEnumerable<Book> Books => _books;

        private Book _selectedBook;

        public Book SelectedBook
        {
            get => _selectedBook;
            set => SetProperty(ref _selectedBook, value);
        }


        public ICommand AddBooksCommand { get; }

        public ICommand ShowMessageCommand { get; }

        public void OnAddBook()
        {
           _books.Add(new Book("Professional C# 8", "Wrox Press", "3478234", "Christian Nagel"));
        }

        public bool CanAddBook() => true;
    }
}
