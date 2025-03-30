using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace K8_PulsingCircles
{
    [Serializable]
    public class Scene
    {
        public List<Circle> Circles { get; set; }
        public int Counter { get; set; }
        public Color Color { get; set; }

        public Scene()
        {
            Circles = new List<Circle>();
            Counter = 0;
            Color = Color.Red;
        }

        public void AddCircle(Circle circle)
        {
            Circles.Add(circle);
        }

        public void Draw(Graphics g)
        {
            foreach (Circle circle in Circles)
            {
                circle.Draw(g);
            }
        }

        public void PulseCircles()
        {
            foreach (Circle circle in Circles)
            {
                circle.Pulse();
            }
        }
    }
}
