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

namespace K5_HuntingCircles
{
    public partial class Form1 : Form
    {
        public Scene Scene { get; set; }
        public bool gameStarted { get; set; }
        public Form1()
        {
            InitializeComponent();
            Scene = new Scene();
            DoubleBuffered = true;
            gameStarted = false;
            timer1.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && !gameStarted)
            {
                Scene.AddCircle(new Circle(e.Location));
            }
            else if (e.Button == MouseButtons.Left && gameStarted)
            {
                Scene.MarkCircle(e.Location);
                tsslPoints.Text = "Points: " + Scene.Points.ToString();
            }
            Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Scene.Draw(e.Graphics);
        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gameStarted = true;
            timer1.Enabled = true;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Scene.PickCircleToDelete();
            tsslPoints.Text = "Points: " + Scene.Points.ToString();

            if (Scene.GameOver())
            {
                Scene.PickCircleToDelete();
                Invalidate();
                timer1.Stop();
                if (MessageBox.Show("New game", "New game", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Scene = new Scene();
                    gameStarted = false;
                    tsslPoints.Text = "Points: 0";
                }
                else
                {
                    this.Close();
                }
            }
            Invalidate();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void SaveScene(string path)
        {
            FileStream fs = new FileStream(path, FileMode.OpenOrCreate);
            IFormatter formatter = new BinaryFormatter();
            formatter.Serialize(fs, Scene);

            fs.Close();
        }

        private void OpenScene(string path)
        {
            FileStream fs = new FileStream(path, FileMode.Open);
            IFormatter formatter = new BinaryFormatter();
            Scene = (Scene)formatter.Deserialize(fs);

            fs.Close();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Scene = new Scene();
            Invalidate();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                OpenScene(openFileDialog.FileName);
                Invalidate();
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                SaveScene(saveFileDialog.FileName);
            }
        }
    }
}
