using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace K4_F1WindowsFormsApp
{
    public partial class AddDriver : Form
    {
        public F1Driver f1Driver {  get; set; }

        public AddDriver()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (tbName.Text.Length == 0)
            {
                errorProviderName.SetError(tbName, "Внесете име");
            }
            else
            {
                f1Driver = new F1Driver(tbName.Text, (int)nudAge.Value, cbFirstDriver.Checked);
                DialogResult = DialogResult.OK;
            }
        }

        private void tbName_Validating(object sender, CancelEventArgs e)
        {
            if(tbName.Text.Length == 0)
            {
                errorProviderName.SetError(tbName, "Внесете име");
                e.Cancel = true;
            }
            else
            {
                errorProviderName.SetError(tbName, null);
                e.Cancel = false;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
