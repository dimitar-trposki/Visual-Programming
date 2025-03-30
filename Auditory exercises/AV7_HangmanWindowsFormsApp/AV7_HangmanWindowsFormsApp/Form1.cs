using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AV7_HangmanWindowsFormsApp
{
    public partial class Form1 : Form
    {
        List<String> words = new List<String>()
        {
            "Argentina",
            "Brazil",
            "USA",
            "Chile",
            "Macedonia",
        };

        HangmanWord word;
        Random rnd = new Random();
        int timeLeft;
        public Form1()
        {
            InitializeComponent();
            string wordToGuess = words[rnd.Next(0, words.Count)];
            word = new HangmanWord(wordToGuess, wordToGuess.Length > 5 ? 6 : 3);
            tbGuessedLetters.Text = word.UpdateAlphabet();
            lblWordToGuess.Text = word.UpdateWord();
            lblTimer.Text = "02:00";
            timeLeft = 120;
            pbTimeLeft.Value = 100;
        }

        private void btnConfirmLetter_Click(object sender, EventArgs e)
        {
            if (tbLetter.Text.Length == 1)
            {
                word.GuessLetter(Convert.ToChar(tbLetter.Text));
                tbGuessedLetters.Text = word.UpdateAlphabet();
                lblWordToGuess.Text = word.UpdateWord();
                tbLetter.Text = string.Empty;
                pbFailedAttempts.Value = word.PercentageOfFailedAttempts();

                if (word.GameOver())
                {
                    MessageBox.Show("Игратa заврши. Зборот кој требаше да се погоди е " + word.ToString() + ".");
                    this.Close();
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timeLeft == 0)
            {
                MessageBox.Show("Игратa заврши. Зборот кој требаше да се погоди е " + word.ToString() + ".");
                this.Close();
            }

            timeLeft--;

            int minutes = timeLeft / 60;
            int seconds = timeLeft % 60;

            lblTimer.Text = $"{minutes}:{seconds}";

            pbTimeLeft.Value = (int)(100.0 * (timeLeft / 120.0));
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pbTimeLeft_Click(object sender, EventArgs e)
        {

        }
    }
}
