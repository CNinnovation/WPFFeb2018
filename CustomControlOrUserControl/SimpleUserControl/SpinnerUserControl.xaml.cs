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

namespace SimpleUserControl
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class SpinnerUserControl : UserControl
    {
        public SpinnerUserControl()
        {
            InitializeComponent();
        }

        public int Min
        {
            get { return (int)GetValue(MinProperty); }
            set { SetValue(MinProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Minimum.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty MinProperty =
            DependencyProperty.Register(nameof(Min), typeof(int), typeof(SpinnerUserControl), new PropertyMetadata(0));

        public int Max
        {
            get { return (int)GetValue(MaxProperty); }
            set { SetValue(MaxProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Max.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty MaxProperty =
            DependencyProperty.Register(nameof(Max), typeof(int), typeof(SpinnerUserControl), new PropertyMetadata(100));

        public int Value
        {
            get { return (int)GetValue(ValueProperty); }
            set { SetValue(ValueProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Value.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ValueProperty =
            DependencyProperty.Register("Value", typeof(int), typeof(SpinnerUserControl), new PropertyMetadata(0, OnValueChanged, CoerceValue));

        private static object CoerceValue(DependencyObject d, object baseValue)
        {
            SpinnerUserControl it = (SpinnerUserControl)d;
            int val = (int)baseValue;
            if (val > it.Max) val = it.Max;
            if (val < it.Min) val = it.Min;
            return val;
        }

        private static void OnValueChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {

        }


        private void OnUp(object sender, RoutedEventArgs e)
        {
            Value++;
        }

        private void OnDown(object sender, RoutedEventArgs e)
        {
            Value--;
        }
    }
}
