using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AV10_DrawingPolygons
{
    [Serializable]
    public class Scene
    {
        public List<Polygon> Polygons { get; set; }
        public Polygon CurrentPolygon { get; set; }

        public Scene()
        {
            Polygons = new List<Polygon>();
            CurrentPolygon = new Polygon();
        }

        public void AddPoint(Point p)
        {
            CurrentPolygon.AddPoint(p);
            if (CurrentPolygon.IsClosed)
            {
                Polygons.Add(CurrentPolygon);
                CurrentPolygon = new Polygon();
            }
        }

        public void UpdateCursor(Point p)
        {
            CurrentPolygon.UpdateCursor(p);
        }

        public void Draw(Graphics g)
        {
            CurrentPolygon.Draw(g);
            foreach (Polygon polygon in Polygons)
            {
                polygon.Draw(g);
            }
        }
    }
}
