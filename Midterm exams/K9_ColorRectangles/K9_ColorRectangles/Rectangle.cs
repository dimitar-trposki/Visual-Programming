using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K9_ColorRectangles
{
    [Serializable]
    public class Rectangle
    {
        public Point LeftTop { get; set; }
        public Point RightBottom { get; set; }
        public Color Color { get; set; }
        public bool IsSelected { get; set; }

        public Rectangle(Point leftTop, Point rightBottom, Color color)
        {
            this.LeftTop = leftTop;
            this.RightBottom = rightBottom;
            this.Color = color;
            IsSelected = false;
        }

        public void Draw(Graphics g)
        {
            Brush brush = new SolidBrush(Color);
            g.FillRectangle(brush, LeftTop.X, LeftTop.Y, RightBottom.X - LeftTop.X, RightBottom.Y - LeftTop.Y);
            brush.Dispose();

            if (IsSelected)
            {
                Pen pen = new Pen(Color.Red, 2);
                g.DrawRectangle(pen, LeftTop.X, LeftTop.Y, RightBottom.X - LeftTop.X, RightBottom.Y - LeftTop.Y);
                pen.Dispose();
            }
        }

        public bool IsHit(Point point)
        {
            System.Drawing.Rectangle rectangle = new System.Drawing.Rectangle(LeftTop.X, LeftTop.Y, RightBottom.X - LeftTop.X, RightBottom.Y - LeftTop.Y);
            return rectangle.Contains(point);
        }
    }
}
