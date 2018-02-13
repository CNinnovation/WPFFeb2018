using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace AnimationWPF
{
    /// <summary>
    /// Interaction logic for EasingChartControl.xaml
    /// </summary>
    public partial class EasingChartControl : UserControl
    {
        private const double _samplingInterval = 0.01;

        public EasingChartControl() => InitializeComponent();

        private SolidColorBrush blackBrush = new SolidColorBrush(Colors.Black);

        public void Draw(EasingFunctionBase easingFunction)
        {
            canvas1.Children.Clear();

            var pathSegments = new PathSegmentCollection();

            for (double i = 0; i < 1; i += _samplingInterval)
            {
                double x = i * canvas1.Width;
                double y = easingFunction.Ease(i) * canvas1.Height;

                var segment = new LineSegment();
                segment.Point = new Point(x, y);

                pathSegments.Add(segment);
            }
            var p = new Path();
            p.Stroke = blackBrush;
            p.StrokeThickness = 3;
            PathFigureCollection figures = new PathFigureCollection();
            figures.Add(new PathFigure() { Segments = pathSegments });
            p.Data = new PathGeometry() { Figures = figures };
            canvas1.Children.Add(p);
        }
    }
}
