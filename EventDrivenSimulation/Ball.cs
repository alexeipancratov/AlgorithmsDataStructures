using System.Windows.Media;
using System.Windows.Shapes;

namespace EventDrivenSimulation
{
    internal class Ball
    {
        private double _velocityX = 1.0;
        private double _velocityY = 1.0;
        private const double _canvasSize = 500;
        private const double _radius = 5;

        public Ellipse Ellipse { get; }

        public double PositionX { get; set; }

        public double PositionY { get; set; }

        public Ball()
        {
            Ellipse = new Ellipse
            {
                Width = _radius,
                Height = _radius,
                Fill = Brushes.Black
            };
        }

        public void Move(double delta)
        {
            AdjustVelocityDirection(delta);

            PositionX += _velocityX * delta;
            PositionY += _velocityY * delta;
        }

        private void AdjustVelocityDirection(double delta)
        {
            bool hitLeftWall = PositionX + _velocityX * delta < 0;
            bool hitRightWall = PositionX + _radius + _velocityX * delta > _canvasSize;

            if (hitLeftWall || hitRightWall)
            {
                _velocityX = -_velocityX;
            }

            bool hitTopWall = PositionY + _velocityY * delta < 0;
            bool hitBottomWall = PositionY + _radius + _velocityY * delta > _canvasSize;

            if (hitTopWall || hitBottomWall)
            {
                _velocityY = -_velocityY;
            }
        }
    }
}
