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
        //Private Attributes
        private double distance;
        private DateTime tripDate, startTime, endTime;
        
        //Public Property
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

        //Constructor
        public Trip(double distance, DateTime startTime, DateTime endTime, DateTime tripDate)
        {
            this.distance = distance;
            this.startTime = startTime;
            this.endTime = endTime;
            this.tripDate = tripDate;
            
        }

        //Calculate duration method
        public TimeSpan CalculateDuration()
        {
            return EndTime - StartTime;
        }

        //Calculate fuel used method
        public double CalculateFuelUsed(Car car)
        {
            return distance / car.KmPerLiter;
        }

        //Calculate trip price method
        public double CalculateTripPrice(Car car, double fuelPrice)
        {
            return CalculateFuelUsed(car) * fuelPrice;
        }
    }
}
