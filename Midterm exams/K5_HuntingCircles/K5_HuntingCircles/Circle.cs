using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K5_HuntingCircles
{
    [Serializable]
    public class Circle
    {
        public Point Center { get; set; }
        public int Radius { get; set; }
        public Color Color { get; set; }
        public bool Saved { get; set; }
        public bool MarkedForDeletion { get; set; }

        public Circle(Point center)
        {
            this.Center = center;
            this.Color = Color.Red;
            this.Radius = 25;
            this.Saved = false;
            this.MarkedForDeletion = false;
        }

        public void Draw(Graphics g)
        {
            Brush brush = new SolidBrush(Color);
            g.FillEllipse(brush, Center.X - Radius, Center.Y - Radius, 2 * Radius, 2 * Radius);
            brush.Dispose();

            if (Saved)
            {
                Pen pen = new Pen(Color.Yellow, 2);
                g.DrawEllipse(pen, Center.X - Radius, Center.Y - Radius, 2 * Radius, 2 * Radius);
                pen.Dispose();
            }

            if (MarkedForDeletion)
            {
                Pen pen = new Pen(Color.Black, 2);
                g.DrawEllipse(pen, Center.X - Radius, Center.Y - Radius, 2 * Radius, 2 * Radius);
                pen.Dispose();
            }
        }

        public bool Overlap(Circle circle)
        {
            return Math.Sqrt(Math.Pow(Center.X - circle.Center.X, 2) + Math.Pow(Center.Y - circle.Center.Y, 2)) <= (Radius + circle.Radius);
        }

        public bool IsHit(Point p)
        {
            return Math.Sqrt(Math.Pow(Center.X - p.X, 2) + Math.Pow(Center.Y - p.Y, 2)) <= Radius;
        }
    }
}
