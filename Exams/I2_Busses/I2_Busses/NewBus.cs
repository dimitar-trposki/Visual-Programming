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

namespace I2_Busses
{
    public partial class NewBus : Form
    {
        public Bus Bus { get; set; }
        public NewBus()
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

        private void tbId_Validating(object sender, CancelEventArgs e)
        {
            if (tbId.Text.Length != 4)
            {
                errorProvider1.SetError(tbId, "Полето за регистрација треба да биде точно 4 цифри!");
                e.Cancel = true;
            }
            else if (!Regex.IsMatch(tbId.Text, "[0-9][0-9][0-9][0-9]"))
            {
                errorProvider1.SetError(tbId, "Полето за регистрација треба да биде точно 4 цифри!");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(tbId, null);
                e.Cancel = false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                this.Bus = new Bus(tbId.Text, tbName.Text, cbLocal.Checked);
                this.DialogResult = DialogResult.OK;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
