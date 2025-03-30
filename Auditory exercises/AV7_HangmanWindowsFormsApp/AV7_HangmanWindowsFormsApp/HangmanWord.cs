using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AV7_HangmanWindowsFormsApp
{
    public class HangmanWord
    {
        public string Word { get; set; }
        public HashSet<char> LettersNotGuessed { get; set; }
        public HashSet<char> UsedLetters { get; set; } = new HashSet<char>();
        public int NumTries { get; set; } = 0;
        public int MaxTries { get; set; }

        public HangmanWord(string word, int maxTries)
        {
            Word = word;
            MaxTries = maxTries;

            LettersNotGuessed = new HashSet<char>();

            foreach (char c in word)
            {
                LettersNotGuessed.Add(Char.ToLower(c));
            }
        }

        public void GuessLetter(char letter)
        {
            if (Word.ToLower().Contains(Char.ToLower(letter)))
            {
                LettersNotGuessed.Remove(Char.ToLower(letter));
            }
            else if (!UsedLetters.Contains(Char.ToLower(letter)))
            {
                NumTries++;
            }

            UsedLetters.Add(Char.ToLower(letter));
        }

        public string UpdateAlphabet()
        {
            StringBuilder sb = new StringBuilder();

            for (char i = 'a'; i <= 'z'; i++)
            {
                if (UsedLetters.Contains(i))
                {
                    sb.Append(Char.ToUpper(i));
                }
                else
                {
                    sb.Append("_");
                }

                sb.Append(" ");
            }

            return sb.ToString();
        }

        public string UpdateWord()
        {
            StringBuilder sb = new StringBuilder();

            foreach (char letter in Word)
            {
                if (LettersNotGuessed.Contains(Char.ToLower(letter)))
                {
                    sb.Append("_");
                }
                else
                {
                    sb.Append(letter);
                }

                sb.Append(" ");
            }

            return sb.ToString();
        }

        public int PercentageOfFailedAttempts()
        {
            return (int)(100.0 * (double)NumTries / MaxTries);
        }

        public bool GameOver()
        {
            return NumTries == MaxTries || LettersNotGuessed.Count == 0;
        }

        public override string ToString()
        {
            return Word.ToString();
        }
    }
}
