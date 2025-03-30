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

namespace K6_FlyingBalls
{
    public partial class Form1 : Form
    {
        Scene scene;
        public int TimerTicks { get; set; }
        public bool Started { get; set; } = true;

        public Form1()
        {
            InitializeComponent();
            scene = new Scene(this.Height, this.Width);
            timer1.Interval = 100;
            timer1.Start();
            TimerTicks = 0;
            this.DoubleBuffered = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ++TimerTicks;
            if (TimerTicks % 10 == 0)
            {
                scene.AddBall();
            }
            scene.Move();
            updateStatusLabels();
            Invalidate();
        }

        private void updateStatusLabels()
        {
            tsslHits.Text = "Hits: " + scene.Hits;
            tsslMiss.Text = "Misses: " + scene.Misses;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            scene.Draw(e.Graphics);
        }

        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
            scene.Height = this.Height;
            scene.Width = this.Width;
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            scene.Hit(e.Location);
            Invalidate();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            scene = new Scene(this.Height, this.Width);
            timer1.Interval = 100;
            timer1.Start();
            TimerTicks = 0;
            pauseToolStripMenuItem.Text = "Pause";
            Invalidate();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                OpenScene(openFileDialog.FileName);
            }
            Invalidate();
        }

        private void OpenScene(string path)
        {
            using (FileStream fileStream = new FileStream(path, FileMode.OpenOrCreate))
            {
                IFormatter formatter = new BinaryFormatter();
                scene = (Scene)formatter.Deserialize(fileStream);
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string path = saveFileDialog.FileName;
                SaveScene(path);
            }
        }

        private void SaveScene(string path)
        {
            using (FileStream fileStream = new FileStream(path, FileMode.Create))
            {
                IFormatter formatter = new BinaryFormatter();
                formatter.Serialize(fileStream, scene);
            }
        }

        private void pauseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Started = !Started;
            if (Started)
            {
                timer1.Start();
                pauseToolStripMenuItem.Text = "Pause";
            }
            else
            {
                timer1.Stop();
                pauseToolStripMenuItem.Text = "Resume";
            }
        }
    }
}
