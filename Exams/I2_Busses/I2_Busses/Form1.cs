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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddBus_Click(object sender, EventArgs e)
        {
            NewBus newBus = new NewBus();
            if (newBus.ShowDialog() == DialogResult.OK)
            {
                lbBusses.Items.Add(newBus.Bus);
            }
        }

        private void btnRemoveBus_Click(object sender, EventArgs e)
        {
            if (lbBusses.SelectedIndex != -1)
            {
                if (MessageBox.Show("Дали сте сигурни дека сакате да го избришете автобусот?", "Предупредување", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int index = lbBusses.SelectedIndex;
                    lbBusses.Items.RemoveAt(index);
                    lbLines.Items.Clear();
                    tbAveragePrice.Text = string.Empty;
                    tbMostExpensiveLine.Text = string.Empty;
                }
            }
        }

        private void btnAddLine_Click(object sender, EventArgs e)
        {
            if (lbBusses.SelectedIndex != -1)
            {
                NewLine newLine = new NewLine();
                Bus bus = lbBusses.SelectedItem as Bus;
                if (newLine.ShowDialog() == DialogResult.OK)
                {
                    bus.AddDestination(newLine.Line);
                    showDestinations();
                }
            }
        }

        private void showDestinations()
        {
            if (lbBusses.SelectedIndex != -1)
            {
                Bus bus = lbBusses.SelectedItem as Bus;
                lbLines.Items.Clear();
                for (int i = 0; i < bus.Destinations.Count; i++)
                {
                    lbLines.Items.Add(bus.Destinations[i]);
                }
                if (bus.Destinations.Count > 0)
                {
                    tbMostExpensiveLine.Text = bus.mostExpensiveDestination().ToString();
                    tbAveragePrice.Text = bus.averagePrice();
                }
                else
                {
                    tbMostExpensiveLine.Text = string.Empty;
                    tbAveragePrice.Text = string.Empty;
                }
                lbLines.SelectedIndex = -1;
            }
        }

        private void lbBusses_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbBusses.SelectedIndex != -1)
            {
                Bus bus = lbBusses.SelectedItem as Bus;
                showDestinations();
            }
        }
    }
}
