using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AV9_DrawingLines
{
    public class Scene
    {

        public List<Line> Lines { get; set; }
        public Point LastPoint { get; set; }
        public Color Color { get; set; }
        public int Thickness { get; set; }
        public bool Positioner { get; set; }
        public Point Cursor { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public Stack<Line> UndoRedo { get; set; }

        public Scene(int Width, int Height)
        {
            Lines = new List<Line>();
            Color = Color.Red;
            Thickness = 1;
            LastPoint = Point.Empty;
            Positioner = false;
            this.Width = Width;
            this.Height = Height;
            UndoRedo = new Stack<Line>();
        }

        public void AddPoint(Point point)
        {
            if (!LastPoint.IsEmpty)
            {
                Lines.Add(new Line(LastPoint, point, Color, Thickness));
                LastPoint = new Point();
            }
            else
            {
                LastPoint = point;
            }
        }

        public void Draw(Graphics g)
        {
            foreach (Line line in Lines)
            {
                line.Draw(g);
            }

            if (Positioner)
            {
                Pen p = new Pen(Color.Black);
                p.DashStyle = DashStyle.Dash;
                g.DrawLine(p, new Point(0, Cursor.Y), new Point(Width, Cursor.Y));
                g.DrawLine(p, new Point(Cursor.X, 0), new Point(Cursor.X, Height));
            }
        }

        public void Undo()
        {
            if (Lines.Count > 0)
            {
                Line l = Lines[Lines.Count - 1];
                UndoRedo.Push(l);
                Lines.RemoveAt(Lines.Count - 1);
                if (Lines.Count == 0)
                {
                    LastPoint = Point.Empty;
                }
                else
                {
                    LastPoint = Lines[Lines.Count - 1].Right;
                }
            }
        }


        public void Redo()
        {
            if (UndoRedo.Count > 0)
            {
                Line l = UndoRedo.Pop();
                Lines.Add(l);
                LastPoint = l.Right;
            }
        }
    }
}
