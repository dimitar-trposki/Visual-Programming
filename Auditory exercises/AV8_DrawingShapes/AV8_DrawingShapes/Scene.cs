using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AV8_DrawingShapes
{
    public class Scene
    {
        public List<Shape> Shapes { get; set; } = new List<Shape>();
        public Shape SelectedShape { get; set; } = null;
        public Scene() { Shapes = new List<Shape>(); }

        public void AddShape(Shape s)
        {
            Shapes.Add(s);
        }

        public void Draw(Graphics g)
        {
            foreach (var shape in Shapes)
            {
                shape.Draw(g);
            }
        }

        public void Hit(Point point)
        {
            foreach (var shape in Shapes)
            {
                if (shape.Hit(point))
                {
                    if (SelectedShape == null)
                    {
                        SelectedShape = shape;
                        shape.IsSelected = !shape.IsSelected;
                    }
                    else //a form is selected
                    {
                        SelectedShape.IsSelected = false;
                        SelectedShape = shape;
                        SelectedShape.IsSelected = true;
                    }
                }
            }
        }

        public void Pulse()
        {
            foreach (var shape in Shapes)
            {
                shape.Pulse();
            }
        }
    }
}
