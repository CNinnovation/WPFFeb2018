using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace TheSimplestMVVMAppWithWPF.ViewModels
{
    // BindableBase - from Prism.Core
    // z.B. Observable, BindableObject, BindableBase - implement INotifyPropertyChanged
    public class MainWindowViewModel : BindableBase
    {
        public MainWindowViewModel()
        {
            Input = "empty";
            Output = "empty";
            ActionCommand = new DelegateCommand(OnAction);  // DelegateCommand from Prism.Core
        }

        private string _input;
        // string is the Model
        public string Input
        {
            get => _input;
            set => SetProperty(ref _input, value);
           //set
           // {
           //     //if (_input != value)
           //     //{
           //     //    _input = value;
           //     //    OnPropertyChanged(new PropertyChangedEventArgs(nameof(Input)));
           //     //}

           //     _input = value;
           //     OnPropertyChanged(new PropertyChangedEventArgs(nameof(Input)));
           // }
        }

        private string _output;

        // string is the Model
        public string Output
        {
            get => _output;
            set => SetProperty(ref _output, value);
        }


        public ICommand ActionCommand { get; }

        public void OnAction()
        {
            Output = Input;
        }
    }
}
