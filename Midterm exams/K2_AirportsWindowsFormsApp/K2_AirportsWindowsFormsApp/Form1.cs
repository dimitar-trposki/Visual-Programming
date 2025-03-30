using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace K2_AirportsWindowsFormsApp
{
    public partial class FormAirports : Form
    {
        public FormAirports()
        {
            InitializeComponent();
        }

        private void btnAddAirport_Click(object sender, EventArgs e)
        {
            AddNewAirport newAirport = new AddNewAirport();
            newAirport.ShowDialog();

            if (newAirport.DialogResult == DialogResult.OK)
            {
                lbAirports.Items.Add(newAirport.airport);
            }
        }

        private void btnRemoveAirport_Click(object sender, EventArgs e)
        {
            if (lbAirports.SelectedItems.Count > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Дали сте сигурни дека сакате да го избришете избраниот аеродром?", "Ne", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    lbAirports.Items.Remove(lbAirports.SelectedItem);
                    lbDestinations.Items.Clear();
                    tbAverageDIstance.Clear();
                    tbMostExpensiveDestination.Clear();
                }
            }
        }

        private void btnAddDestination_Click(object sender, EventArgs e)
        {
            if (lbAirports.SelectedItems.Count > 0)
            {
                AddNewDestination newDestination = new AddNewDestination();

                newDestination.ShowDialog();
                if (newDestination.DialogResult == DialogResult.OK)
                {
                    ((Airport)lbAirports.SelectedItem).AddDestination(newDestination.destination);
                    fillList();
                }
            }
        }

        private void fillList()
        {
            lbDestinations.Items.Clear();
            List<Destinations> list = new List<Destinations>();
            list = ((Airport)lbAirports.SelectedItem).destinations;
            foreach (Destinations dest in list)
            {
                lbDestinations.Items.Add(dest);
            }
            tbMostExpensiveDestination.Text = ((Airport)lbAirports.SelectedItem).mostExpensiveDest();
            tbAverageDIstance.Text = ((Airport)lbAirports.SelectedItem).avgDistance();
        }

        private void lbAirports_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbAirports.SelectedItems.Count > 0)
            {
                fillList();
            }
        }
    }
}
