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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddAirport_Click(object sender, EventArgs e)
        {
            NewAirport newAirport = new NewAirport();
            if (newAirport.ShowDialog() == DialogResult.OK)
            {
                lbAirports.Items.Add(newAirport.Airport);
            }
        }

        private void btnDeleteAirport_Click(object sender, EventArgs e)
        {
            if (lbAirports.SelectedIndex != -1)
            {
                if (MessageBox.Show("Дали сте сигурни дека сакате да го избришете аеродромот?", "Предупредување", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int index = lbAirports.SelectedIndex;
                    lbAirports.Items.RemoveAt(index);
                    lbDestinations.Items.Clear();
                    tbMostExpensiveDestination.Text = "";
                    tbAverageDistance.Text = "";
                }
            }
        }

        private void btnAddDestination_Click(object sender, EventArgs e)
        {
            if (lbAirports.SelectedIndex != -1)
            {
                NewDestination newDestination = new NewDestination();
                Airport airport = lbAirports.SelectedItem as Airport;
                if (newDestination.ShowDialog() == DialogResult.OK)
                {
                    airport.addDestination(newDestination.Destination);
                    showDestinations();
                }
            }
        }

        private void showDestinations()
        {
            if (lbAirports.SelectedIndex != -1)
            {
                Airport airport = lbAirports.SelectedItem as Airport;
                lbDestinations.Items.Clear();
                for (int i = 0; i < airport.Destinations.Count; i++)
                {
                    lbDestinations.Items.Add(airport.Destinations[i]);
                }
                if (airport.Destinations.Count > 0)
                {
                    tbMostExpensiveDestination.Text = airport.MostExpensiveDestination().ToString();
                    tbAverageDistance.Text = airport.AverageDestination();
                }
                else
                {
                    tbMostExpensiveDestination.Text = "";
                    tbAverageDistance.Text = "";
                }
                lbDestinations.SelectedIndex = -1;
            }
        }

        private void lbAirports_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbAirports.SelectedIndex != -1)
            {
                Airport airport = lbAirports.SelectedItem as Airport;
                showDestinations();
            }
        }
    }
}
