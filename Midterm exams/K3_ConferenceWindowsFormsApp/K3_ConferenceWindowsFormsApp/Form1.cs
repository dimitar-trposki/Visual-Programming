using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace K3_ConferenceWindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void addAuthors(ScientificWork work)
        {
            work.AuthorList.ForEach(author =>
            {
                if (!lbAuthorsAndPapers.Items.Cast<Author>().Any(a => a.Name == author.Name))
                {
                    lbAuthorsAndPapers.Items.Add(author);
                }
                else
                {
                    int counter = 0;
                    Author author2 = null;
                    foreach (ScientificWork scientificWork in lbAllPapers.Items)
                    {
                        foreach (Author author1 in scientificWork.AuthorList)
                        {
                            if (author1.Name == author.Name)
                            {
                                author2 = author1;
                                lbAuthorsAndPapers.Items.Remove(author1);
                                counter++;
                                break;
                            }
                        }
                    }
                    
                    author2.Count = counter;
                    lbAuthorsAndPapers.Items.Add((Author)author2);
                }
            });
        }

        private void btnAddNewPaper_Click(object sender, EventArgs e)
        {
            AddPaper addPaper = new AddPaper();
            addPaper.ShowDialog();

            if (addPaper.DialogResult == DialogResult.OK)
            {
                lbAllPapers.Items.Add(addPaper.scientificWork);
                addAuthors(addPaper.scientificWork);
            }
        } 

        private void btnDeletePaper_Click(object sender, EventArgs e)
        {
            lbAllPapers.Items.Remove(lbAllPapers.SelectedItem);
        }
    }
}
