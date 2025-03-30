using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AV8_DrawingShapes
{
    public abstract class Shape
    {
        public Color Color { get; set; }

        public Point location { get; set; } //for the center of the object

        public int size { get; set; }//circle - radius, square - side

        public bool IsSelected { get; set; } = false;

        public Shape(Color color, Point location, int size)
        {
            Color = color;
            this.location = location;
            this.size = size;
        }

        public abstract void Draw(Graphics g); //Graphics is for shape-drawing

        public abstract void Pulse();

        public abstract bool Hit(Point point); 
    }
}
