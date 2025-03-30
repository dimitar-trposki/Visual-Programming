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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddDriver_Click(object sender, EventArgs e)
        {
            AddDriver addDriver = new AddDriver();
            addDriver.ShowDialog();

            if (addDriver.DialogResult == DialogResult.OK)
            {
                if (addDriver.f1Driver.FirstOrNot)
                {
                    List<F1Driver> drivers = new List<F1Driver>();
                    foreach (F1Driver item in lbDrivers.Items)
                    {
                        drivers.Add(item);
                    }
                    lbDrivers.Items.Clear();
                    lbDrivers.Items.Add(addDriver.f1Driver);
                    drivers.ForEach(driver => lbDrivers.Items.Add(driver));
                }
                else
                {
                    lbDrivers.Items.Add(addDriver.f1Driver);
                }
            }
        }

        private void btnRemoveDriver_Click(object sender, EventArgs e)
        {
            if (lbDrivers.SelectedItems.Count > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Дали сте сигурни дека сакате да го избришете избраниот возач?", "Validate", MessageBoxButtons.YesNo);
                if (dialogResult.Equals(DialogResult.Yes))
                {
                    lbDrivers.Items.Remove(lbDrivers.SelectedItem);
                    lbLaps.Items.Clear();
                    tbFastestLap.Clear();
                }
            }
        }

        private void FillRightLB()
        {
            if (lbDrivers.SelectedItems.Count > 0)
            {
                lbLaps.Items.Clear();
                ((F1Driver)lbDrivers.SelectedItem).laps.ForEach(lap =>
                {
                    if (lap.Seconds > (int)nudTime.Value)
                    {
                        lbLaps.Items.Add(lap);
                    }
                });
            }
        }

        private void FindMax(F1Driver driver)
        {
            if (lbDrivers.SelectedItems.Count > 0)
            {
                tbFastestLap.Clear();
                if (driver.laps.Count > 0)
                {
                    Lap fastest = driver.laps.ElementAt(0);
                    foreach (Lap item in driver.laps)
                    {
                        if (item.Minutes < fastest.Minutes)
                        {
                            fastest = item;
                        }
                        else if (item.Minutes == fastest.Minutes)
                        {
                            if (item.Seconds < fastest.Seconds)
                            {
                                fastest = item;
                            }
                        }
                    }
                    tbFastestLap.Text = fastest.ToString();
                }
            }
        }

        private void btnAddLap_Click(object sender, EventArgs e)
        {
            if (lbDrivers.SelectedItems.Count > 0)
            {
                F1Driver driver = (F1Driver)lbDrivers.SelectedItem;
                driver.AddLap(new Lap((int)nudMinutes.Value, (int)nudSeconds.Value));
                FillRightLB();
                nudMinutes.Value = 0;
                nudSeconds.Value = 0;
                FindMax((F1Driver)lbDrivers.SelectedItem);
            }
        }

        private void lbDrivers_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillRightLB();
            FindMax((F1Driver)lbDrivers.SelectedItem);
        }

        private void nudSeconds_ValueChanged(object sender, EventArgs e)
        {
            if ((int)nudSeconds.Value == -1 && (int)nudMinutes.Value >= 1)
            {
                nudSeconds.Value = 59;
                nudMinutes.Value -= 1;
            }
            else if ((int)nudSeconds.Value == -1 && (int)nudMinutes.Value == 0)
            {
                nudSeconds.Value = 0;
            }
            else if ((int)nudSeconds.Value == 60)
            {
                nudSeconds.Value = 0;
                nudMinutes.Value += 1;
            }
        }

        private void nudTime_ValueChanged(object sender, EventArgs e)
        {
            FillRightLB();
        }
    }
}
