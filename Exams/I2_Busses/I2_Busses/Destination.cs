using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I2_Busses
{
    public class Destination
    {
        public string LineDestination { get; set; }
        public int DepartureHour { get; set; }
        public int DepartureMinute { get; set; }
        public int Price { get; set; }

        public Destination(string lineDestination, int departureHour, int departureMinute, int price)
        {
            LineDestination = lineDestination;
            DepartureHour = departureHour;
            DepartureMinute = departureMinute;
            Price = price;
        }

        public override string ToString()
        {
            return String.Format("{0}:{1} - {2} - {3} Ден.", DepartureHour, DepartureMinute, LineDestination, Price);
        }
    }
}
