using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AV4_iKnowWindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lbCourses.Items.AddRange(new string[] { "ООП", "НП", "СП" });
        }

        private void lbCourses_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (tbNewCourse.Text.Length > 0)
            {
                bool flag = false;
                foreach (string item in lbCourses.Items)
                {
                    if (item.Equals(tbNewCourse.Text))
                    {
                        flag = true;
                    }
                }
                if (!flag)
                {
                    lbCourses.Items.Add(tbNewCourse.Text);
                }
                else
                {
                    MessageBox.Show("Курсот веќе постои.");
                }

            }
            else
            {
                MessageBox.Show("Нема што да се додаде, внесете име на курс.");
            }
            tbNewCourse.Clear();
        }

        private void btnMoveLeft_Click(object sender, EventArgs e)
        {
            var checkedItems = new List<string>();
            foreach (string item in clbEnrolledCourses.CheckedItems)
            {
                checkedItems.Add(item);
            }

            foreach (string item in checkedItems)
            {
                lbCourses.Items.Add(item);
                clbEnrolledCourses.Items.Remove(item);
            }

            if (clbEnrolledCourses.SelectedItems.Count > 0)
            {
                lbCourses.Items.Add(clbEnrolledCourses.SelectedItem);
                clbEnrolledCourses.Items.Remove(clbEnrolledCourses.SelectedItem);
            }
        }

        private void btnMoveRight_Click(object sender, EventArgs e)
        {
            List<string> items = new List<string>();
            foreach (string item in lbCourses.SelectedItems)
            {
                items.Add(item);
            }

            foreach (string item in items)
            {
                clbEnrolledCourses.Items.Add(item);
                lbCourses.Items.Remove(item);
            }

            /*if (lbCourses.SelectedItems.Count > 0)
            {
                clbEnrolledCourses.Items.Add(lbCourses.SelectedItem);
                lbCourses.Items.Remove(lbCourses.SelectedItem);
            }*/
        }
    }
}
