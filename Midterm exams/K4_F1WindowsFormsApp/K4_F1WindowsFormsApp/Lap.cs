using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K4_F1WindowsFormsApp
{
    public class Lap
    {
        public int Minutes { get; set; }
        public int Seconds { get; set; }

        public Lap(int minutes, int seconds)
        {
            Minutes = minutes;
            Seconds = seconds;
        }

        public override string ToString()
        {
            return $"{Minutes}:{Seconds}";
        }
    }
}
