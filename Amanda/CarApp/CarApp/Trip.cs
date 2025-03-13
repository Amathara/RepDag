using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarApp
{
    internal class Trip
    {
        // Attributter:
        private double distance;
        private DateTime tripDate;
        private DateTime startTime;
        private DateTime endTime;

        // Public Properties for encapsulation:
        public double Distance
        {
            get { return distance; }
            set { distance = value; }
        }

        public DateTime TripDate
        {
            get { return tripDate; }
            set { tripDate = value; }
        }
        public DateTime StartTime
        {
            get { return startTime; }
            set { startTime = value; }
        }
        public DateTime EndTime
        {
            get { return endTime; }
            set { endTime = value; }
        }
        //Constructor:
        public Trip(double distance, DateTime tripDate, DateTime startTime, DateTime endTime)
        {
         this.distance = distance;
         this.tripDate = tripDate;
         this.startTime = startTime;
         this.endTime = endTime;

        }
// Metode til at udregne en turs "Duration"
        public TimeSpan CalculateDuration()
        {
            return endTime - StartTime;
        }

        // Metode til at at udregne pris for tur:
        public double CalculateFuelUsed( double kmPerLiter)
        {
return distance / kmPerLiter;
        }

        // Metode til at printe Trip detailjer
        public void PrintTripDetails()
        {
            Console.WriteLine($"Tur Dato: {tripDate.ToShortDateString()}");
            Console.WriteLine($"Længde : {distance} km");
            Console.WriteLine($"Start Tid: {startTime}");
            Console.WriteLine($"Slut Tid: {endTime}");
            Console.WriteLine($"Turen tager så lang tid: {CalculateDuration()}");
        }

        // Liste over forskellige ture:
        List<Trip> trips = new List<Trip>
        {


        };
       
    }
}
