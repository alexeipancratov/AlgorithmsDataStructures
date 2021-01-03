using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
using System.Windows.Threading;

namespace EventDrivenSimulation
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private const int numberOfPoints = 50;
        private Ball[] _balls = new Ball[numberOfPoints];
        private Random _random = new Random();

        public MainWindow()
        {
            InitializeComponent();

            InitializeBalls();

            Task.Run(() => RecalculateBalls());
        }

        private void InitializeBalls()
        {
            for (int i = 0; i < numberOfPoints; i++)
            {
                _balls[i] = new Ball
                {
                    Ellipse = new Ellipse
                    {
                        Stroke = Brushes.Black,
                        StrokeThickness = 2
                    },
                    PositionX = _random.Next((int)canvas.ActualWidth),
                    PositionY = _random.Next((int)canvas.ActualHeight)
                };

                canvas.Children.Add(_balls[i].Ellipse);
            }

            for (int i = 0; i < numberOfPoints; i++)
            {
                Canvas.SetLeft(_balls[i].Ellipse, _balls[i].PositionX);
                Canvas.SetTop(_balls[i].Ellipse, _balls[i].PositionY);
            }
        }

        private void RecalculateBalls()
        {
            while (true)
            {
                for (int i = 0; i < numberOfPoints; i++)
                {
                    _balls[i].PositionX = _random.Next((int)canvas.ActualWidth);
                    _balls[i].PositionY = _random.Next((int)canvas.ActualHeight);

                    Dispatcher.Invoke(() =>
                    {
                        Canvas.SetLeft(_balls[i].Ellipse, _balls[i].PositionX);
                        Canvas.SetTop(_balls[i].Ellipse, _balls[i].PositionY);
                    }, DispatcherPriority.Normal);
                }

                Thread.Sleep(250);
            }
        }
    }
}
