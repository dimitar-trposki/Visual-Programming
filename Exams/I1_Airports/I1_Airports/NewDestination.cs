using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace I1_Airports
{
    public partial class NewDestination : Form
    {
        public Destination Destination { get; set; }

        public NewDestination()
        {
            InitializeComponent();
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                this.Destination = new Destination(tbName.Text, (int)nudDistance.Value, (int)nudPrice.Value);
                this.DialogResult = DialogResult.OK;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
