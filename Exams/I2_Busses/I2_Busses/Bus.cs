using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I2_Busses
{
    public class Bus
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public bool Local { get; set; }
        public List<Destination> Destinations { get; set; }

        public Bus(string id, string name, bool local)
        {
            Id = id;
            Name = name;
            Local = local;
            Destinations = new List<Destination>();
        }

        public void AddDestination(Destination destination)
        {
            Destinations.Add(destination);
        }

        public Destination mostExpensiveDestination()
        {
            Destination destination = Destinations.ElementAt(0);
            for (int i = 1; i < Destinations.Count; i++)
            {
                if (Destinations[i].Price > destination.Price)
                {
                    destination = Destinations[i];
                }
            }
            return destination;
        }

        public string averagePrice()
        {
            double sum = 0;
            for (int i = 0; i < Destinations.Count; i++)
            {
                sum += Destinations[i].Price;
            }
            return String.Format("{0:F1}", sum / Destinations.Count);
        }

        public override string ToString()
        {
            return String.Format("{0} - {1} - {2}", Name, Id, Local ? "L" : "M");
        }
    }
}
