using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K10_Polygons
{
    [Serializable]
    public class Scene
    {
        public List<Polygon> Polygons { get; set; }
        public Polygon CurrentPolygon { get; set; }
        public Color Color { get; set; } = Color.Blue;

        public Scene()
        {
            Polygons = new List<Polygon>();
            CurrentPolygon = new Polygon();
        }

        public void AddPoint(Point p)
        {
            CurrentPolygon.AddPoints(p);
            if (CurrentPolygon.IsClosed)
            {
                CurrentPolygon.UpdateColor(Color);
                Polygons.Add(CurrentPolygon);
                CurrentPolygon = new Polygon();
            }
        }

        public void UpdateColor(Color color)
        {
            this.Color = color;
        }

        public void UpdateCursor(Point p)
        {
            CurrentPolygon.UpdateCursor(p);
        }

        public void Draw(Graphics g)
        {
            CurrentPolygon.Draw(g);
            foreach (Polygon p in Polygons)
            {
                p.Draw(g);
            }
        }

        public void MovePolygon(int dx, int dy)
        {
            foreach (Polygon p in Polygons)
            {
                p.Move(dx, dy);
            }
        }
    }
}