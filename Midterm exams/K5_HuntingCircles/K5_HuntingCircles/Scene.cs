using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K5_HuntingCircles
{
    [Serializable]
    public class Scene
    {
        public List<Circle> Circles { get; set; }
        public int Points { get; set; }
        public Random Random { get; set; }
        public Circle MarkedForDeleteion { get; set; }

        public Scene()
        {
            Circles = new List<Circle>();
            Points = 0;
            Random = new Random();
            MarkedForDeleteion = null;
        }

        public void AddCircle(Circle circle)
        {
            foreach (Circle c in Circles)
            {
                if (c.Overlap(circle))
                {
                    return;
                }
            }
            Circles.Add(circle);
        }

        public void MarkCircle(Point location)
        {
            foreach (Circle c in Circles)
            {
                if (c.IsHit(location) && !c.MarkedForDeletion)
                {
                    Points += 5;
                    c.Saved = true;
                    return;
                }
            }
        }

        public void Draw(Graphics g)
        {
            foreach (Circle circle in Circles)
            {
                circle.Draw(g);
            }
        }

        public bool GameOver()
        {
            foreach (Circle circle in Circles)
            {
                if (!circle.Saved)
                {
                    return false;
                }
            }
            return true;
        }

        public void PickCircleToDelete()
        {
            if (MarkedForDeleteion != null)
            {
                Points -= 10;
                Circles.Remove(MarkedForDeleteion);
            }

            if (Circles.Count > 0 && !GameOver())
            {
                Circle selected = Circles[Random.Next(0, Circles.Count())];

                while (selected.Saved && !selected.MarkedForDeletion)
                {
                    selected = Circles[Random.Next(0, Circles.Count())];
                }

                selected.MarkedForDeletion = true;
                MarkedForDeleteion = selected;
            }
        }
    }
}
