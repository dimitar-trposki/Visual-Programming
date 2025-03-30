using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace K7_SlidingBalls
{
    public partial class Form1 : Form
    {
        Scene Scene;
        public Form1()
        {
            InitializeComponent();
            Scene = new Scene(this.Width, this.Height);
            DoubleBuffered = true;
            timer1.Interval = 50;
            timer1.Start();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                Scene.Counter++;
                tsslNumBalls.Text = "Number of balls: " + Scene.Counter;
                Scene.AddBall(new Ball(e.Location, Color.Red));
            }

            if (e.Button == MouseButtons.Left)
            {
                if (Scene.selectedBall == null)
                {
                    Scene.SelectRedBall(e.Location);
                    timer1.Start();
                }
            }
            Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Scene.Draw(e.Graphics);
        }

        private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Scene.Counter++;
                tsslNumBalls.Text = "Number of balls: " + Scene.Counter;
                Scene.AddRandomBall(e.Location);
            }
            Invalidate();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Scene = new Scene(this.Width, this.Height);
            tsslNumBalls.Text = "Number of balls: 0";
            Invalidate();
        }

        private void OpenScene(string path)
        {
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                IFormatter formatter = new BinaryFormatter();
                Scene = (Scene)formatter.Deserialize(fs);
                fs.Close();
            }
        }

        private void SaveScene(string path)
        {
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                IFormatter formatter = new BinaryFormatter();
                formatter.Serialize(fs, Scene);
                fs.Close();
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                OpenScene(dlg.FileName);
                Invalidate();
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                SaveScene(dlg.FileName);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tsslNumBalls.Text = "Number of balls: " + Scene.Counter;

            if (Scene.selectedBall != null)
            {
                Scene.MoveRedBall();
                Invalidate();
            }
        }
    }
}
