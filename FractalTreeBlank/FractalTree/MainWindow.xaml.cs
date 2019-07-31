using System;
using System.Threading;
using System.Windows;
using System.Windows.Media;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace FractalTree
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly Brush _brush = Brushes.SteelBlue;

        public MainWindow()
        {
            Loaded += (sender, args) => DrawFractal(new Point(400, 450), 200, Math.PI / 2, 10);
            InitializeComponent();
        }

        private void DrawFractal(Point start, double length, double angle, int level)
        {
           // Sleep();

            canvas.Children.Add(new Line
                {
                    Stroke = _brush,
                    X1 = start.X,
                    Y1 = start.Y,
                    X2 = start.X + length * Math.Cos(angle),
                    Y2 = start.Y - length * Math.Sin(angle),
                    StrokeThickness = 1
                });

            //canvas.Children.Add(new Line
            //{
            //    Stroke = _brush,
            //    X1 = start.X,
            //    Y1 = start.Y,
            //    X2 = start.X + length / 2 * Math.Cos(angle * 1.5),
            //    Y2 = start.Y - length / 2 * Math.Sin(angle * 1.5),
            //    StrokeThickness = 1
            //});

            //canvas.Children.Add(new Line
            //{
            //    Stroke = _brush,
            //    X1 = start.X + length * Math.Cos(angle),
            //    Y1 = start.Y - length * Math.Sin(angle),
            //    X2 = start.X + length * Math.Cos(angle) + length / 2 * Math.Cos(angle*1.5),
            //    Y2 = start.Y - length * Math.Sin(angle) - length / 2 * Math.Sin(angle*1.5),
            //    StrokeThickness = 1
            //});

            //canvas.Children.Add(new Line
            //{
            //    Stroke = _brush,
            //    X1 = start.X + length * Math.Cos(angle),
            //    Y1 = start.Y - length * Math.Sin(angle),
            //    X2 = start.X + length * Math.Cos(angle) + length / 2 * Math.Cos(angle / 2),
            //    Y2 = start.Y - length * Math.Sin(angle) - length / 2 * Math.Sin(angle / 2),
            //    StrokeThickness = 1
            //});

            //  canvas.Children.Add(myLine);

            //Задержка в отрисовке для создания анимации

            if (--level >= 0)
            {
                DrawFractal(new Point(start.X + length * Math.Cos(angle), start.Y - length * Math.Sin(angle)),length/1.5, angle +20, level);
                DrawFractal(new Point(start.X + length * Math.Cos(angle), start.Y - length * Math.Sin(angle)),length/1.5, angle -20, level);
            }
            

        }

        private void Sleep(int ms = 1)
        {
            Dispatcher.Invoke(DispatcherPriority.Background, new ThreadStart(delegate { }));
            Thread.Sleep(ms);
        }
    }
}
