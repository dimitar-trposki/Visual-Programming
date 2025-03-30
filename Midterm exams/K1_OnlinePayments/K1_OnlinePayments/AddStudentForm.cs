using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace K1_OnlinePayments
{
    public partial class AddStudentForm : Form
    {
        public Student student { get; set; }

        public AddStudentForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (tbName.Text.Length > 0 && tbIndex.Text.Length > 0)
            {
                student = new Student(tbName.Text, tbIndex.Text, new List<int>());
                DialogResult = DialogResult.OK;
            }
            else
            {
                if (tbIndex.Text.Length == 0)
                {
                    errorProvider1.SetError(tbIndex, "Внесете индекс!");
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void tbName_Validating(object sender, CancelEventArgs e)
        {
            if (tbName.Text.Length == 0)
            {
                errorProvider1.SetError(tbName, "Внесете име");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(tbName, null);
                e.Cancel = false;
            }
        }

        private void tbIndex_Validating(object sender, CancelEventArgs e)
        {
            if (tbIndex.Text.Length == 0)
            {
                errorProvider1.SetError(tbIndex, "Внесете индекс");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(tbIndex, null);
                e.Cancel = false;
            }
        }
    }
}
