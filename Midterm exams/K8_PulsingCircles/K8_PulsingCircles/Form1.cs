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

namespace K8_PulsingCircles
{
    public partial class Form1 : Form
    {
        public Scene Scene { get; set; }
        public Form1()
        {
            InitializeComponent();
            Scene = new Scene();
            tllsTotal.Text = "Total: " + Scene.Counter;
            timer1.Interval = 100;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Scene.AddCircle(new Circle(e.Location, Scene.Color));
                Scene.Counter++;
                tllsTotal.Text = "Total: " + Scene.Counter;
            }
            Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Scene.Draw(e.Graphics);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Scene = new Scene();
            tllsTotal.Text = "Total: " + Scene.Counter;
            Invalidate();
        }

        private void OpenFile(string path)
        {
            FileStream fs = new FileStream(path, FileMode.Open);
            IFormatter formatter = new BinaryFormatter();
            Scene = (Scene)formatter.Deserialize(fs);
            fs.Close();
        }

        private void SaveFile(string path)
        {
            FileStream fs = new FileStream(path, FileMode.OpenOrCreate);
            IFormatter formatter = new BinaryFormatter();
            formatter.Serialize(fs, Scene);
            fs.Close();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                SaveFile(saveFileDialog.FileName);
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                OpenFile(openFileDialog.FileName);
                Invalidate();
            }
            tllsTotal.Text = "Total: " + Scene.Counter;
        }

        private void colorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                Scene.Color = colorDialog.Color;
            }
        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (startToolStripMenuItem.Text.Equals("Start"))
            {
                timer1.Start();
                startToolStripMenuItem.Text = "Stop";
            }
            else if (startToolStripMenuItem.Text.Equals("Stop"))
            {
                timer1.Stop();
                startToolStripMenuItem.Text = "Start";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Scene.PulseCircles();
            Invalidate();
        }
    }
}
