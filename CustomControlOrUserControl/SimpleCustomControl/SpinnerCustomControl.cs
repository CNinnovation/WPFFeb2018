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

namespace SimpleCustomControl
{
    /// <summary>
    /// Follow steps 1a or 1b and then 2 to use this custom control in a XAML file.
    ///
    /// Step 1a) Using this custom control in a XAML file that exists in the current project.
    /// Add this XmlNamespace attribute to the root element of the markup file where it is 
    /// to be used:
    ///
    ///     xmlns:MyNamespace="clr-namespace:SimpleCustomControl"
    ///
    ///
    /// Step 1b) Using this custom control in a XAML file that exists in a different project.
    /// Add this XmlNamespace attribute to the root element of the markup file where it is 
    /// to be used:
    ///
    ///     xmlns:MyNamespace="clr-namespace:SimpleCustomControl;assembly=SimpleCustomControl"
    ///
    /// You will also need to add a project reference from the project where the XAML file lives
    /// to this project and Rebuild to avoid compilation errors:
    ///
    ///     Right click on the target project in the Solution Explorer and
    ///     "Add Reference"->"Projects"->[Select this project]
    ///
    ///
    /// Step 2)
    /// Go ahead and use your control in the XAML file.
    ///
    ///     <MyNamespace:CustomControl1/>
    ///
    /// </summary>
    public class SpinnerCustomControl : Control
    {
        static SpinnerCustomControl()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(SpinnerCustomControl), new FrameworkPropertyMetadata(typeof(SpinnerCustomControl)));
        }

        public SpinnerCustomControl()
        {
            DataContext = this;
            UpCommand = new RoutedUICommand("Up", "Up", typeof(SpinnerCustomControl));
            DownCommand = new RoutedUICommand("Down", "Down", typeof(SpinnerCustomControl));
            CommandBindings.Add(new CommandBinding(UpCommand, OnUp));
            CommandBindings.Add(new CommandBinding(DownCommand, OnDown));
        }

        private void OnUp(object sender, ExecutedRoutedEventArgs e)
        {
            Value++;
        }

        private void OnDown(object sender, ExecutedRoutedEventArgs e)
        {
            Value--;
        }

        public int Min
        {
            get { return (int)GetValue(MinProperty); }
            set { SetValue(MinProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Minimum.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty MinProperty =
            DependencyProperty.Register(nameof(Min), typeof(int), typeof(SpinnerCustomControl), new PropertyMetadata(0));

        public int Max
        {
            get { return (int)GetValue(MaxProperty); }
            set { SetValue(MaxProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Max.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty MaxProperty =
            DependencyProperty.Register(nameof(Max), typeof(int), typeof(SpinnerCustomControl), new PropertyMetadata(100));

        public int Value
        {
            get { return (int)GetValue(ValueProperty); }
            set { SetValue(ValueProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Value.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ValueProperty =
            DependencyProperty.Register("Value", typeof(int), typeof(SpinnerCustomControl), new PropertyMetadata(0, OnValueChanged, CoerceValue));

        private static object CoerceValue(DependencyObject d, object baseValue)
        {
            int val = (int)baseValue;
            if (val > 100) val = 100;
            if (val < 0) val = 0;
            return val;
        }

        public RoutedUICommand UpCommand { get; private set; }
        public RoutedUICommand DownCommand { get; private set; }

        private static void OnValueChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {

        }
    }
}
