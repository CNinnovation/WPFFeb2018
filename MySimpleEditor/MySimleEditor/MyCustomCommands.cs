using System.Windows.Input;

namespace MySimleEditor
{
    public class MyCustomCommands
    {
        private static RoutedUICommand _schlumpfi;
        public static RoutedUICommand Schlumpfi => _schlumpfi ?? (_schlumpfi = new RoutedUICommand("Schlumpfi", "Schlumpfi", typeof(RoutedUICommand)));
    }
}
