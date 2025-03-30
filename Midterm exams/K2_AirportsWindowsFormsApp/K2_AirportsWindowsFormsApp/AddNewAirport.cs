using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace K2_AirportsWindowsFormsApp
{
    public partial class AddNewAirport : Form
    {
        public AddNewAirport()
        {
            InitializeComponent();
        }

        public Airport airport;

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (tbCityAirport.Text.Length == 0)
            {
                errorProviderNewAirport.SetError(tbCityAirport, "Внесете град.");
            }
            else if (tbNameAirport.Text.Length == 0)
            {
                errorProviderNewAirport.SetError(tbNameAirport, "Внесете име.");
            }
            else if (tbShortName.Text.Length == 0)
            {
                errorProviderNewAirport.SetError(tbShortName, "Внесете кратенка со точно 3 големи букви.");
            }
            else
            {
                airport = new Airport(tbCityAirport.Text, tbNameAirport.Text, tbShortName.Text);
                DialogResult = DialogResult.OK;
            }
        }

        private void tbCityAirport_Validating(object sender, CancelEventArgs e)
        {
            if (tbCityAirport.Text.Length == 0)
            {
                errorProviderNewAirport.SetError(tbCityAirport, "Внесете град");
                e.Cancel = true;
            }
            else
            {
                errorProviderNewAirport.SetError(tbCityAirport, null);
                e.Cancel = false;
            }
        }

        private void tbNameAirport_Validating(object sender, CancelEventArgs e)
        {
            if (tbNameAirport.Text.Length == 0)
            {
                errorProviderNewAirport.SetError(tbNameAirport, "Внесете име");
                e.Cancel = true;
            }
            else
            {
                errorProviderNewAirport.SetError(tbNameAirport, null);
                e.Cancel = false;
            }
        }

        private void tbShortName_Validating(object sender, CancelEventArgs e)
        {
            bool areUpper = true;
            for (int i = 0; i < tbShortName.Text.Length; i++)
            {
                if (!Char.IsUpper(tbShortName.Text.ElementAt(i)))
                {
                    areUpper = false;
                    break;
                }
            }

            if (tbShortName.Text.Length == 3 && areUpper)
            {
                errorProviderNewAirport.SetError(tbShortName, null);
                e.Cancel = false;
            }
            else
            {
                errorProviderNewAirport.SetError(tbShortName, "Внесете кратенка со точно 3 големи букви.");
                e.Cancel = true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
