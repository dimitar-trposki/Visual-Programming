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
    public partial class AddNewDestination : Form
    {
        public Destinations destination { get; set; }
        public AddNewDestination()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (tbCityAirport.Text.Length == 0)
            {
                errorProviderDestination.SetError(tbCityAirport, "Внесете име");
                DialogResult = DialogResult.Cancel;
            }
            else
            {
                destination = new Destinations(tbCityAirport.Text, (int)nudDistance.Value, (int)nudPrice.Value);
                this.DialogResult = DialogResult.OK;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void tbCityAirport_Validating(object sender, CancelEventArgs e)
        {
            if (tbCityAirport.Text.Length == 0)
            {
                errorProviderDestination.SetError(tbCityAirport, "Внесете име");
                e.Cancel = true;
            }
            else
            {
                errorProviderDestination.SetError(tbCityAirport, null);
                e.Cancel = false;
            }
        }
    }
}
