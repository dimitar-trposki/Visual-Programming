using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace I1_Airports
{
    public partial class NewAirport : Form
    {
        public Airport Airport { get; set; }
        public NewAirport()
        {
            InitializeComponent();
        }

        private void tbCity_Validating(object sender, CancelEventArgs e)
        {
            if (tbCity.Text.Length == 0)
            {
                errorProvider1.SetError(tbCity, "Полето за град не смее да биде празно!");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(tbCity, null);
                e.Cancel = false;
            }
        }

        private void tbName_Validating(object sender, CancelEventArgs e)
        {
            if (tbName.Text.Length == 0)
            {
                errorProvider1.SetError(tbName, "Полето за име не смее да биде празно!");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(tbName, null);
                e.Cancel = false;
            }
        }

        private void textBox3_Validating(object sender, CancelEventArgs e)
        {
            if (textBox3.Text.Length != 3)
            {
                errorProvider1.SetError(textBox3, "Кратенката треба да се состои од три големи букви!");
                e.Cancel = true;
            }
            else if (!Regex.IsMatch(textBox3.Text, @"[A-Z][A-Z][A-Z]"))
            {
                errorProvider1.SetError(textBox3, "Кратенката треба да се состои од три големи букви!");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(textBox3, null);
                e.Cancel = false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                this.Airport = new Airport(tbCity.Text, tbName.Text, textBox3.Text);
                this.DialogResult = DialogResult.OK;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
