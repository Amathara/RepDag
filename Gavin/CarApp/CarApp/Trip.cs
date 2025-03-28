using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace CarApp
{
    public class Trip
    {
        //Properties
        public double Distance { get; set; }
        public double FuelUsed { get; set; }
        public DateTime Date { get; set; }

        //Constructor
        public Trip(double distance, DateTime date)
        {
            this.Distance = distance;
            this.Date = date;
        }

        public double FuelConsumption(double kmPerL)
        {
            FuelUsed = Distance / kmPerL;
            return FuelUsed;
        }

    }
}
