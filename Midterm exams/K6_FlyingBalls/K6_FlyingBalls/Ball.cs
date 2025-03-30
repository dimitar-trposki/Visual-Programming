using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K6_FlyingBalls
{
    [Serializable]
    public class Ball
    {
        public Point Center { get; set; }
        public int State { get; set; }
        public static int RADIUS { get; set; } = 40;
        public static Random Random { get; set; } = new Random();

        public Ball(Point center)
        {
            this.Center = center;
            State = Random.Next(3);
        }

        public void Draw(Graphics g)
        {
            Color color;
            switch (State)
            {
                case 0: color = Color.Red; break;
                case 1: color = Color.Green; break;
                default: color = Color.Blue; break;
            }

            Brush b = new SolidBrush(color);
            g.FillEllipse(b, Center.X - RADIUS, Center.Y - RADIUS, 2 * RADIUS, 2 * RADIUS);
            b.Dispose();
        }

        public void Move(int dx, int dy)
        {
            Center = new Point(Center.X + dx, Center.Y + dy);
        }

        public bool IsHit(Point p)
        {
            double distance = Math.Sqrt(Math.Pow(Center.X - p.X, 2) + Math.Pow(Center.Y - p.Y, 2));
            if (distance <= RADIUS)
            {
                ++State;
            }
            return distance <= RADIUS;
        }
    }
}
