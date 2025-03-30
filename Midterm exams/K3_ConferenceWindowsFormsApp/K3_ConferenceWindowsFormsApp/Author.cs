using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K3_ConferenceWindowsFormsApp
{
    public class Author
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Count { get; set; }

        public Author(string line)
        {
            string[] l = line.Split(' ');
            Name = l[1];
            Surname = l[0];
            Count = 1;
        }

        public string ToStringLeft()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Surname + ", " + Name.ElementAt(0) + ".");
            return sb.ToString();
        }

        public void countIncrement()
        {
            Count++;
        }

        public override string ToString()
        {
            return $"{Surname} {Name} - {Count}";
        }
    }
}
