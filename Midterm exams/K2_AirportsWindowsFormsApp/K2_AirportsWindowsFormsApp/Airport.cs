using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K2_AirportsWindowsFormsApp
{
    public class Airport
    {
        public string City { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
        public List<Destinations> destinations { get; set; }

        public Airport(string city, string name, string shortName)
        {
            City = city;
            Name = name;
            ShortName = shortName;
            destinations = new List<Destinations>();
        }

        public void AddDestination(Destinations destination)
        {
            destinations.Add(destination);
        }

        public string mostExpensiveDest()
        {
            if (destinations.Count > 0)
            {
                Destinations d = destinations.ElementAt(0);
                foreach (Destinations dest in destinations)
                {
                    if (d.Price < dest.Price)
                    {
                        d = dest;
                    }
                }
                return d.ToString();
            }

            return null;
        }

        public string avgDistance()
        {
            if (destinations.Count > 0)
            {
                float sum = 0;
                foreach (Destinations dest in destinations)
                {
                    sum += dest.Distance;
                }
                float avgDistance = sum / (float)destinations.Count;
                return avgDistance.ToString("F1");
            }
            return null;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(ShortName + " - " + Name + " - " + City);
            return sb.ToString();
        }
    }
}
