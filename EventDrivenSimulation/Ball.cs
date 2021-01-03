using System.Windows.Shapes;

namespace EventDrivenSimulation
{
    internal class Ball
    {
        private double _velocityX = 1.0;
        private double _velocityY = 1.0;
        private const double radius = 3;

        public Ellipse Ellipse { get; set; }

        public double PositionX { get; set; }

        public double PositionY { get; set; }

        public void Move(double delta)
        {
            bool hitLeftWall = PositionX + _velocityX * delta < radius;
            bool hitRightWall = PositionX + _velocityX * delta > 1.0 - radius;

            if (hitLeftWall || hitRightWall)
            {
                _velocityX = -_velocityX;
            }

            bool hitTopWall = PositionY + _velocityY * delta < radius;
            bool hitBottomWall = PositionY + _velocityY * delta > 1.0 - radius;

            if (hitTopWall || hitBottomWall)
            {
                _velocityY = -_velocityY;
            }

            PositionX += _velocityX * delta;
            PositionY += _velocityY * delta;
        }
    }
}
