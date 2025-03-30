using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K7_SlidingBalls
{
    [Serializable]
    public class Scene
    {
        public List<Ball> Balls { get; set; }
        public static int SPEED { get; set; }
        public static Random random = new Random();
        public int Counter { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public int dx { get; set; }
        public int dy { get; set; }
        public Ball selectedBall { get; set; }

        public Scene(int width, int height)
        {
            Balls = new List<Ball>();
            this.Width = width;
            this.Height = height;
            dx = 0;
            dy = 0;
            selectedBall = null;
        }

        public void AddBall(Ball ball)
        {
            Balls.Add(ball);
        }

        public void AddRandomBall(Point p)
        {
            int colorNumber = random.Next(2);
            switch (colorNumber)
            {
                case 0: AddBall(new Ball(p, Color.Green)); break;
                case 1: AddBall(new Ball(p, Color.Blue)); break;
            }
        }

        public void SelectRedBall(Point p)
        {
            foreach (Ball ball in Balls)
            {
                if (ball.Color.Equals(Color.Red) && ball.IsHit(p))
                {
                    selectedBall = ball;
                    break;
                }
            }
        }

        public void MoveRedBall()
        {
            if (selectedBall == null)
            {
                return;
            }

            dx = 0;
            dy = 0;

            Random r = new Random();
            int direction = random.Next(4);
            switch (direction)
            {
                case 0: dx = -10; break;
                case 1: dx = +10; break;
                case 2: dy = -10; break;
                case 3: dy = +10; break;
            }
            selectedBall.Move(dx, dy);

            if (selectedBall.OutOfBounds(Width, Height))
            {
                Balls.Remove(selectedBall);
                selectedBall = null;
                Counter--;
            }

            /*foreach (Ball ball in Balls)
            {
                if (ball.Color.Equals(Color.Green))
                {
                    if (selectedBall.OverlapsGreen(ball))
                    {
                        Balls.Remove(ball);
                        Counter--;
                    }
                }
            }*/

            for (int i = 0; i < Balls.Count(); i++)
            {
                if (Balls[i].Color.Equals(Color.Green))
                {
                    if (selectedBall != null && selectedBall.OverlapsGreen(Balls[i]))
                    {
                        Balls.RemoveAt(i);
                        Counter--;
                    }
                }
            }
        }

        public void Draw(Graphics g)
        {
            foreach (Ball b in Balls)
            {
                b.Draw(g);
            }
        }
    }
}
