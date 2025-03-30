using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AV9_DrawingLines
{
    public partial class Form1 : Form
    {
        public Scene Scene { get; set; }

        public Form1()
        {
            InitializeComponent();
            Scene = new Scene(this.Width, this.Height);
            this.DoubleBuffered = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            Scene.AddPoint(e.Location);
            Invalidate();
            UpdateStatusStrip();
            Scene.UndoRedo.Clear();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Scene.Draw(e.Graphics);
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                Scene.Color = dlg.Color;
            }
        }

        private void thinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            thickToolStripMenuItem.Checked = false;
            normalToolStripMenuItem.Checked = false;
            thinToolStripMenuItem.Checked = true;
            Scene.Thickness = 1;
        }

        private void normalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            thinToolStripMenuItem.Checked = false;
            thickToolStripMenuItem.Checked = false;
            normalToolStripMenuItem.Checked = true;
            Scene.Thickness = 2;
        }

        private void thickToolStripMenuItem_Click(object sender, EventArgs e)
        {
            thinToolStripMenuItem.Checked = false;
            normalToolStripMenuItem.Checked = false;
            thickToolStripMenuItem.Checked = true;
            Scene.Thickness = 3;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            Scene.Cursor = e.Location;
            Invalidate();
        }

        private void positionerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Scene.Positioner = !Scene.Positioner;
            positionerToolStripMenuItem.Checked = !positionerToolStripMenuItem.Checked;
        }

        private void UpdateStatusStrip()
        {
            countOfLinesStatusLabel.Text = $"Lines: {Scene.Lines.Count}";
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Scene.Undo();
            Invalidate();
            UpdateStatusStrip();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Scene.Redo();
            Invalidate();
            UpdateStatusStrip();
        }
    }
}
