using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K9_ColorRectangles
{
    [Serializable]
    public class Scene
    {
        public List<Rectangle> Rectangles { get; set; }
        public List<Rectangle> SelectedRectangles { get; set; }
        public Color Color { get; set; }
        public Point Cursor { get; set; }

        public Scene()
        {
            Rectangles = new List<Rectangle>();
            Color = Color.Blue;
            SelectedRectangles = new List<Rectangle>();
        }

        public void AddRectangle(Rectangle r)
        {
            Rectangles.Add(r);
        }

        public void SelectedRectangle(Point p)
        {
            foreach (Rectangle r in Rectangles)
            {
                if (r.IsHit(p) && !r.IsSelected)
                {
                    r.IsSelected = true;
                    SelectedRectangles.Add(r);
                }
                else if (r.IsHit(p) && r.IsSelected)
                {
                    r.IsSelected = false;
                    SelectedRectangles.Remove(r);
                }
            }
        }

        public void Draw(Graphics g)
        {
            foreach (Rectangle rect in Rectangles)
            {
                rect.Draw(g);
            }
        }

        public void ClearRectangles()
        {
            foreach (Rectangle rect in SelectedRectangles)
            {
                Rectangles.Remove(rect);
            }
            SelectedRectangles.Clear();
        }
    }
}
