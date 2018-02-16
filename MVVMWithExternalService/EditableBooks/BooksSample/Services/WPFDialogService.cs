using BooksLib.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace BooksSample.Services
{
    public class WPFDialogService : IDialogService
    {
        public Task ShowMessageAsync(string message)
        {
            MessageBox.Show(message);
            return Task.CompletedTask;
        }
    }
}
