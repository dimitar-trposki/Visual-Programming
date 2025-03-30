using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K8_PulsingCircles
{
    [Serializable]
    public class Circle
    {
        public Point Center { get; set; }
        public Color Color { get; set; }
        public int Radius { get; set; } = 30;

        public Circle(Point p, Color color)
        {
            this.Center = p;
            this.Color = color;
        }

        public void Draw(Graphics g)
        {
            Brush brush = new SolidBrush(Color);
            g.FillEllipse(brush, Center.X - Radius, Center.Y - Radius, 2 * Radius, 2 * Radius);
        }

        public void Pulse()
        {

            if (Radius == 60)
            {
                Radius = 30;
            }
            Radius += (int)(Radius * 0.1);

        }
    }
}
