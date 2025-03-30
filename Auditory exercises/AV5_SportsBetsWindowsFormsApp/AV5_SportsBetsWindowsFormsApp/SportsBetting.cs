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
    public partial class SportsBetting : Form
    {
        public SportsBetting()
        {
            InitializeComponent();
            lbTeams.Items.Add(new SoccerTeam("Real Madrid", "Spain"));
            lbTeams.Items.Add(new SoccerTeam("Barcelona", "Spain"));
            lbTeams.Items.Add(new SoccerTeam("PSG", "France"));
        }

        private void btnAddTeam_Click(object sender, EventArgs e)
        {
            NewTeam newTeam = new NewTeam();
            newTeam.ShowDialog();
            //DialogResult result = newTeam.ShowDialog();

            if (newTeam.DialogResult == DialogResult.OK)
            {
                lbTeams.Items.Add(newTeam.soccerTeam);
            }
        }

        private void btnAddMatch_Click(object sender, EventArgs e)
        {
            foreach (Game item in lbMatches.Items)
            {
                if (mtbCode.Text.Equals(item.Code))
                {
                    return;
                }
            }

            if (mtbCode.Text.Length == 0)
            {
                ErrorProvider errorCode = new ErrorProvider();
                errorCode.SetError(mtbCode, "Внесете шифра");
                return;
            }

            if (lbTeams.SelectedItems.Count == 2)
            {
                Game game = new Game(lbTeams.SelectedItems[0] as SoccerTeam, lbTeams.SelectedItems[1] as SoccerTeam, nud1.Value, nudX.Value, nud2.Value, mtbCode.Text);

                lbMatches.Items.Add(game);
            }
            else
            {
                MessageBox.Show("Изберете точна два тима!");
            }
            ClearAllProperties();
        }

        private void ClearAllProperties()
        {
            lbTeams.SelectedItems.Clear();
            nud1.Value = 1.00m;
            nudX.Value = 1.00m;
            nud2.Value = 1.00m;
            mtbCode.Clear();
            errorCode.Clear();
        }

        private void tbCode_TextChanged(object sender, EventArgs e)
        {
            lbMatches.ClearSelected();

            foreach (Game item in lbMatches.Items)
            {
                if (item.Code.Equals(tbCode.Text))
                {
                    lbMatches.SelectedItem = item;
                    break;
                }
            }
        }

        void calculateCoefficient()
        {
            decimal coef = 1;
            foreach (Ticket item in lbTickets.Items)
            {
                int tip = item.Tip;
                switch (tip)
                {
                    case 0:
                        coef *= item.Game.Coef1;
                        break;
                    case 1:
                        coef *= item.Game.CoefX;
                        break;
                    case 2:
                        coef *= item.Game.Coef2;
                        break;
                }
            }
            textBox1.Text = (Math.Round(coef, 2)).ToString();
            decimal result = coef * Convert.ToDecimal(numericUpDown1.Value);
            result = Math.Round(result, 2);
            textBox2.Text = result.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ticket ticket = new Ticket(lbMatches.SelectedItem as Game, comboBox1.SelectedIndex);
            lbTickets.Items.Add(ticket);
            calculateCoefficient();
            lbMatches.ClearSelected();
            tbCode.Clear();
            comboBox1.SelectedIndex = -1;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            calculateCoefficient();
        }
    }
}
