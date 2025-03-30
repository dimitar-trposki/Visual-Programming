using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K4_F1WindowsFormsApp
{
    public class F1Driver
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public bool FirstOrNot { get; set; }
        public List<Lap> laps { get; set; }

        public F1Driver(string name, int age, bool firstOrNot)
        {
            Name = name;
            Age = age;
            FirstOrNot = firstOrNot;
            laps = new List<Lap>();
        }

        public void AddLap(Lap lap)
        {
            laps.Add(lap);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Name + " (" + Age + ") - ");
            if (FirstOrNot)
            {
                sb.Append("F");
            }
            else
            {
                sb.Append("S");
            }
            return sb.ToString();
        }
    }
}
