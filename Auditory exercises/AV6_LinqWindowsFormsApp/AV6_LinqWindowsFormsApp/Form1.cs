using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AV6_LinqWindowsFormsApp
{
    public partial class Form1 : Form
    {
        List<String> list = new List<String>();
        List<string> filtered = new List<string>();

        public bool asc { get; set; } = true;
        public string sortCriteria { get; set; } = "Content";


        public Form1()
        {
            InitializeComponent();
            list.Add("Napredno");
            list.Add("Vizuelno");
            list.Add("napredno programiranje");
            FillList();
        }

        public void FillList()
        {
            lbSubjects.Items.Clear();
            list.ForEach(word => lbSubjects.Items.Add(word));
            /*foreach (String s in list)
            {
                lbSubjects.Items.Add(s);
            }*/
        }

        private void btnAddSubject_Click(object sender, EventArgs e)
        {
            if (tbAddSubject.Text.Length > 0)
            {
                list.Add(tbAddSubject.Text);
                FillList();
                tbAddSubject.Clear();
            }
        }

        private void sort()
        {
            Func<string, int> funcByLength = word => word.Length;
            Func<string, string> funcByWord = word => word;

            List<string> sorted = new List<string>();

            if (asc && sortCriteria.Equals("Content"))
            {
                sorted = filtered.OrderBy(funcByWord).ToList();
            }
            else if (asc && sortCriteria.Equals("Length"))
            {
                sorted = filtered.OrderBy(funcByLength).ToList();
            }
            else if (!asc && sortCriteria.Equals("Content"))
            {
                sorted = filtered.OrderByDescending(funcByWord).ToList();
            }
            else if (!asc && sortCriteria.Equals("Length"))
            {
                sorted = filtered.OrderByDescending(funcByLength).ToList();
            }

            sorted.ForEach(word => lbFilteredSubjects.Items.Add(word));
        }

        private void filter()
        {
            lbFilteredSubjects.Items.Clear();
            if (tbFilter.Text.Length > 0)
            {
                //list.Where(word => word.ToLower().Contains(tbFilter.Text.ToLower())).ToList().ForEach(word => lbFilteredSubjects.Items.Add(word));
                this.filtered = list.Where(word => word.ToLower().Contains(tbFilter.Text.ToLower())).ToList();
            }
        }

        private void tbFilter_TextChanged(object sender, EventArgs e)
        {
            lbFilteredSubjects.Items.Clear();
            if(tbFilter.Text.Length > 0)
            {
                filter();
                sort();
            }
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (tbFilter.Text.Length > 0)
            {
                asc = radioButton1.Checked;
                filter();
                sort();
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (tbFilter.Text.Length > 0)
            {
                asc = !radioButton2.Checked;
                filter();
                sort();
            }

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked && tbFilter.Text.Length > 0)
            {
                sortCriteria = "Length";
                filter();
                sort();
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked && tbFilter.Text.Length > 0)
            {
                sortCriteria = "Content";
                filter();
                sort();
            }
        }
    }
}
