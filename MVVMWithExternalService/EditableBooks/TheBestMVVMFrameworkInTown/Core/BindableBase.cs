using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace TheBestMVVMFrameworkInTown.Core
{
    public abstract class BindableBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string propertyName)
        {
            // C# 6
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

            // C# 5
            //var handler = PropertyChanged;
            //if (handler != null)
            //{
            //    handler.Invoke(this, new PropertyChangedEventArgs(propertyName));
            //}
        }

        public bool SetProperty<T>(ref T item, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(item, value)) return false;

            item = value;
            OnPropertyChanged(propertyName);
            return true;
        }
    }
}
