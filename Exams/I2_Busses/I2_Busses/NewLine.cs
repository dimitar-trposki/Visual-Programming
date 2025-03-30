using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace I2_Busses
{
    public partial class NewLine : Form
    {
        public Destination Line { get; set; }
        public NewLine()
        {
            InitializeComponent();
        }

        private void tbDestination_Validating(object sender, CancelEventArgs e)
        {
            if (tbDestination.Text.Length == 0)
            {
                errorProvider1.SetError(tbDestination, "Полето за дестинација не смее да биде празно!");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(tbDestination, null);
                e.Cancel = false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                this.Line = new Destination(tbDestination.Text, (int)nudHour.Value, (int)nudMinutes.Value, (int)nudPrice.Value);
                this.DialogResult = DialogResult.OK;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
