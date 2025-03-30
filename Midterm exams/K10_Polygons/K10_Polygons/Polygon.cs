using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K10_Polygons
{
    [Serializable]
    public class Polygon
    {
        public List<Point> Points { get; set; }
        public bool IsClosed { get; set; } = false;
        public bool IsCloseToStart { get; set; } = false;
        public Point Cursor { get; set; } = new Point();
        public Color Color { get; set; }

        public Polygon()
        {
            Points = new List<Point>();
            //Cursor = new Point();
        }

        public void UpdateColor(Color color)
        {
            Color = color;
        }

        public void AddPoints(Point p)
        {
            IsCloseToStart = NearStart();
            if (IsCloseToStart)
            {
                Points.Add(Points[0]);
                IsClosed = true;
                IsCloseToStart = false;
            }
            else
            {
                Points.Add(p);
            }
        }

        public void UpdateCursor(Point p)
        {
            Cursor = p;
            IsCloseToStart = NearStart();
        }

        public bool NearStart()
        {
            if (Points.Count < 3)
            {
                return false;
            }
            Point FirstPoint = Points[0];
            double distance = Math.Sqrt(Math.Pow(FirstPoint.X - Cursor.X, 2) + Math.Pow(FirstPoint.Y - Cursor.Y, 2));
            return distance <= 5;
        }

        public void Move(int dx, int dy)
        {
            for (int i = 0; i < Points.Count; i++)
            {
                Points[i] = new Point(Points[i].X + dx, Points[i].Y + dy);
            }
        }

        public void Draw(Graphics g)
        {
            Pen dashedPen = new Pen(Color.Black, 2);
            Pen pen = new Pen(Color.Black, 2);
            dashedPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            Brush brush = new SolidBrush(Color);


            if (Points.Count >= 2)
            {
                g.DrawLines(pen, Points.ToArray());
                if (IsCloseToStart)
                {
                    Point firstPoint = Points[0];
                    g.DrawRectangle(dashedPen, (float)(firstPoint.X - 2.5), (float)(firstPoint.Y - 2.5), 5, 5);
                }
                if (IsClosed)
                {
                    g.FillPolygon(brush, Points.ToArray());
                }
            }
            if (Points.Count > 0 && !IsClosed)
            {
                Point lastPoint = Points[Points.Count - 1];
                g.DrawLine(dashedPen, lastPoint, Cursor);
            }

            dashedPen.Dispose();
            brush.Dispose();
            pen.Dispose();
        }
    }
}
