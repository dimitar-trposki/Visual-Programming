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
    public partial class AddPaper : Form
    {
        public ScientificWork scientificWork { get; set; }
        public AddPaper()
        {
            InitializeComponent();
        }

        private void tbTitle_Validating(object sender, CancelEventArgs e)
        {
            if(tbTitle.Text.Length == 0)
            {
                errorProviderAddPaper.SetError(tbTitle, "Внесете наслов на научниот труд");
                e.Cancel = true;
            }
            else
            {
                errorProviderAddPaper.SetError(tbTitle, null);
                e.Cancel = false;
            }
        }

        private void tbKeywords_Validating(object sender, CancelEventArgs e)
        {
            if (tbKeywords.Text.Length == 0)
            {
                errorProviderAddPaper.SetError(tbKeywords, "Внесете клучни зборови");
                e.Cancel = true;
            }
            else
            {
                errorProviderAddPaper.SetError(tbKeywords, null);
                e.Cancel = false;
            }
        }

        private void tbAuthor1_Validating(object sender, CancelEventArgs e)
        {
            if (tbAuthor1.Text.Length == 0)
            {
                errorProviderAddPaper.SetError(tbAuthor1, "Внесете автор");
                e.Cancel = true;
            }
            else
            {
                errorProviderAddPaper.SetError(tbAuthor1, null);
                e.Cancel = false;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if(tbTitle.Text.Length == 0)
            {
                errorProviderAddPaper.SetError(tbTitle, "Внесете наслов на научниот труд");
            }
            else
            {
                scientificWork = new ScientificWork(tbTitle.Text, tbKeywords.Text);
                Author author = new Author(tbAuthor1.Text);
                scientificWork.AddAuthor(author);
                if (tbAuthor2.Text.Length > 0)
                {
                    author = new Author(tbAuthor2.Text);
                    scientificWork.AddAuthor(author);
                }
                if (tbAuthor3.Text.Length > 0)
                {
                    author = new Author(tbAuthor3.Text);
                    scientificWork.AddAuthor(author);
                }
                if (tbAuthor4.Text.Length > 0)
                {
                    author = new Author(tbAuthor4.Text);
                    scientificWork.AddAuthor(author);
                }
                if (tbAuthor5.Text.Length > 0)
                {
                    author = new Author(tbAuthor5.Text);
                    scientificWork.AddAuthor(author);
                }
                DialogResult = DialogResult.OK;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
