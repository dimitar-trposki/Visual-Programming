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

namespace K10_Polygons
{
    public partial class Form1 : Form
    {
        Scene Scene;
        public Form1()
        {
            InitializeComponent();
            Scene = new Scene();
            DoubleBuffered = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Scene.Draw(e.Graphics);
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Scene = new Scene();
            Invalidate();
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

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                SaveScene(saveFileDialog.FileName);
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                OpenScene(openFileDialog.FileName);
            }
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            Scene.AddPoint(e.Location);
            tsslTotal.Text = "# Polygons: " + Scene.Polygons.Count;
            Invalidate();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            Scene.UpdateCursor(e.Location);
            tsslCursor.Text = e.Location.X + ", " + e.Location.Y;
            Invalidate();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                Scene.MovePolygon(0, -5);
            }
            else if (e.KeyCode == Keys.Down)
            {
                Scene.MovePolygon(0, 5);
            }
            else if (e.KeyCode == Keys.Left)
            {
                Scene.MovePolygon(-5, 0);
            }
            else if (e.KeyCode == Keys.Right)
            {
                Scene.MovePolygon(5, 0);
            }
            Invalidate();
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                Scene.UpdateColor(dlg.Color);
            }
        }
    }
}
