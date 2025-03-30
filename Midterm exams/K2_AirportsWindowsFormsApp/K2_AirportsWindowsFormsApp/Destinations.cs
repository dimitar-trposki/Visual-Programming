using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K2_AirportsWindowsFormsApp
{
    public class Destinations
    {
        public string Name { get; set; }
        public int Distance { get; set; }
        public int Price { get; set; }

        public Destinations(string name, int distance, int price)
        {
            Name = name;
            Distance = distance;
            Price = price;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Name + " " + Distance + "km - " + Price + "EUR");
            return sb.ToString();
        }
    }
}
