using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AV5_SportsBetsWindowsFormsApp
{
    public class SoccerTeam
    {
        public string Name { get; set; }
        public string Country { get; set; }

        public SoccerTeam() { }

        public SoccerTeam(string name, string country)
        {
            Name = name;
            Country = country;
        }

        public override string ToString()
        {
            return $"{Name} ({Country})";
        }
    }
}
