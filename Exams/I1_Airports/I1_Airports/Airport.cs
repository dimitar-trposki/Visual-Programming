using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I1_Airports
{
    public class Airport
    {
        public string City { get; set; }
        public string Name { get; set; }
        public string Shortcut { get; set; }
        public List<Destination> Destinations { get; set; }

        public Airport(string city, string name, string shortcut)
        {
            City = city;
            Name = name;
            Shortcut = shortcut;
            Destinations = new List<Destination>();
        }

        public void addDestination(Destination destination)
        {
            Destinations.Add(destination);
        }

        public Destination MostExpensiveDestination()
        {
            Destination destination = Destinations.ElementAt(0);
            for (int i = 1; i < Destinations.Count; i++)
            {
                if (destination.Price < Destinations[i].Price)
                {
                    destination = Destinations[i];
                }
            }
            return destination;
        }

        public string AverageDestination()
        {
            double sum = 0;
            for (int i = 0; i < Destinations.Count; i++)
            {
                sum += Destinations[i].Distance;
            }
            return String.Format("{0:F1}", sum / Destinations.Count);
        }

        public override string ToString()
        {
            return String.Format("{0} - {1} - {2}", Shortcut, Name, City);
        }
    }
}