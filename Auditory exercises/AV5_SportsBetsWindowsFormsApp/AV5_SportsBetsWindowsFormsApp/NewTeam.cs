using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AV5_SportsBetsWindowsFormsApp
{
    public partial class NewTeam : Form
    {
        public SoccerTeam soccerTeam {  get; set; }
        public NewTeam()
        {
            InitializeComponent();
        }

        private void btnAddTeam_Click(object sender, EventArgs e)
        {
            if (tbName.Text.Length == 0)
            {
                ErrorProvider errorProvider1 = new ErrorProvider();
                errorProvider1.SetError(tbName, "Внесете име на тим");
            }

            if (tbCountry.Text.Length == 0)
            {
                ErrorProvider errorProvider2 = new ErrorProvider();
                errorProvider2.SetError(tbCountry, "Внесете држава");
            }

            if (tbName.Text.Length > 0 && tbCountry.Text.Length > 0)
            {
                soccerTeam = new SoccerTeam(tbName.Text, tbCountry.Text);
                DialogResult = DialogResult.OK;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
