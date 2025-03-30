using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K7_SlidingBalls
{
    [Serializable]
    public class Ball
    {
        public static int RADIUS = 30;
        public Point Center { get; set; }
        public Color Color { get; set; }
        public bool Selected { get; set; }

        public Ball(Point p, Color color)
        {
            this.Center = p;
            this.Color = color;
        }

        public bool IsHit(Point p)
        {
            return Math.Sqrt(Math.Pow(Center.X - p.X, 2) + Math.Pow(Center.Y - p.Y, 2)) <= RADIUS;
        }

        public void Draw(Graphics g)
        {
            Brush brush = new SolidBrush(Color);
            g.FillEllipse(brush, Center.X - RADIUS, Center.Y - RADIUS, 2 * RADIUS, 2 * RADIUS);
            brush.Dispose();
        }

        public bool OutOfBounds(int width, int height)
        {
            if (Center.X + RADIUS < 0 || Center.X - RADIUS > width)
            {
                return true;
            }

            if (Center.Y + RADIUS < 0 || Center.Y - RADIUS > height)
            {
                return true;
            }
            return false;
        }

        public bool OverlapsGreen(Ball ball)
        {
            return Math.Sqrt(Math.Pow(Center.X - ball.Center.X, 2) + Math.Pow(Center.Y - ball.Center.Y, 2)) <= (RADIUS + RADIUS);
        }

        public void Move(int dx, int dy)
        {
            Center = new Point(Center.X + dx, Center.Y + dy);
        }
    }
}
