using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace K9_ColorRectangles
{
    public partial class Form1 : Form
    {
        Scene Scene;
        public int Counter { get; set; }
        public Point FirstCoordinate { get; set; }
        public Point SecondCoordinate { get; set; }
        public bool IsDrawing { get; set; }

        public Form1()
        {
            InitializeComponent();
            Scene = new Scene();
            Counter = 0;
            FirstCoordinate = new Point();
            SecondCoordinate = new Point();
            DoubleBuffered = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (Counter == 0)
                {
                    FirstCoordinate = e.Location;
                    IsDrawing = true;
                }
                Counter++;
                if (Counter == 2)
                {
                    SecondCoordinate = e.Location;
                    Scene.AddRectangle(new Rectangle(FirstCoordinate, SecondCoordinate, Scene.Color));
                    FirstCoordinate = new Point();
                    SecondCoordinate = new Point();
                    Counter = 0;
                    IsDrawing = false;
                }
            }
            else if (e.Button == MouseButtons.Right)
            {
                Scene.SelectedRectangle(e.Location);
            }
            tsslTotal.Text = "Rectangles: " + Scene.Rectangles.Count;
            Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Scene.Draw(e.Graphics);

            if (IsDrawing)
            {
                Pen pen = new Pen(Color.Black);
                pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
                int width = Scene.Cursor.X - FirstCoordinate.X;
                int height = Scene.Cursor.Y - FirstCoordinate.Y;
                e.Graphics.DrawRectangle(pen, FirstCoordinate.X, FirstCoordinate.Y, width, height);
                pen.Dispose();
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            Scene.Cursor = e.Location;
            if (IsDrawing)
            {
                Invalidate();
            }
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                Scene.Color = dlg.Color;
            }
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
            }
            Invalidate();
        }

        private void OpenScene(string path)
        {
            using (FileStream fileStream = new FileStream(path, FileMode.OpenOrCreate))
            {
                IFormatter formatter = new BinaryFormatter();
                Scene = (Scene)formatter.Deserialize(fileStream);
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
                formatter.Serialize(fileStream, Scene);
            }
        }

        private void Form1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                Scene.ClearRectangles();
                tsslTotal.Text = "Rectangles: " + Scene.Rectangles.Count;
                Invalidate();
            }
        }
    }
}
