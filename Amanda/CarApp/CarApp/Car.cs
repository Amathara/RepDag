using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarApp
{

    internal class CarPark
    {
        List <String>
    }
    // Adding "Car" class - To be able to make a car list
    internal class Car

    {
        public enum FuelType
        {
            Benzin,
            Diesel,
            Electric,
            Hybrid
        }
        

        private string _brand;
        private string _model;
        private int _year;
        private char _gear;
        private double _odometer;
        public string fuelType;
        private bool _isEngineOn;
        private double _kmPerLiter;
        public double fuelPrice;
        private List<Trip> trips;
        //Constructor: (Models how we input the data later in our "Object")
        public Car(string brand, string model, int year, char gear, double odometer, string fuelTypeInput, bool isEngineOn, double kmPerLiter)
        {
            _brand = brand;
            _model = model;
            _year = year;
            _gear = gear;
            _odometer = odometer;
            fuelType = fuelTypeInput;
            _isEngineOn = isEngineOn;
            _kmPerLiter = kmPerLiter;
            fuelPrice = GetFuelPrice(fuelType);
            trips = new List<Trip>();
        }
        // Methode til at "printe" car info: Get car info.is WITHIN the class, so it has the info it needs. Method is made public so I can add info in my "object" later.
        public string GetCarInfo()
        {
            return $"Brand: {_brand}\n\nModel: {_model}\n\nYear: {_year}\n\nGear: {_gear}\n\nMilage: {_odometer} km\n\nFuel Type: {fuelType}\n\nEngine is on: {_isEngineOn}\n\nCan drive: {_kmPerLiter} km per liter of fuel";
        }

        // Metode til at "køre" bilen:
        public string Drive(double distance)
        {
            double newDistance = _odometer + distance;

            return $"Wohooo, du kører en tur på 50 km!\nDin bil har nu kørt i alt {newDistance} km";

        }

        static double GetFuelPrice(string fuelType)

        {
            // Sammenligning med enum values - Her siger vi hvad der skal ske når vi kalder et et enum type.
            double fuelPrice = 0;
            if (fuelType == Convert.ToString(FuelType.Benzin))
            {
                fuelPrice = 14.69;
            }
            else if (fuelType == Convert.ToString(FuelType.Diesel))
            {
                fuelPrice = 14.29;
            }
            else if (fuelType == Convert.ToString(FuelType.Electric))
            {
                fuelPrice = 2.12; // Har bare fundet på en pris selv, her
            }
            else if (fuelType == Convert.ToString(FuelType.Hybrid))
            {
                fuelPrice = 14.69;
            }

            else
            {
                Console.WriteLine("Hey, du! Vælg en type drivstof fra listen!");
            }
            return fuelPrice;
        }
        // Metode
        public void beregnPris()

        {
            Console.WriteLine("For at kunne beregne prisen for din tur skal vi først bruge nogle oplysninger:");
     
            

            Console.WriteLine("Hvor mange kilometer kan den køre på literen?");


            double kmPerLiter = double.Parse(Console.ReadLine());

            Console.WriteLine("Hvor mange kilometer har bilen kørt i alt?");
            int kiloStand = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Tak for info :)");

            Console.WriteLine("NU kan vi regne!");

            Console.WriteLine("Hvor mange kilometer vil du køre i dag?");
            int distance = Convert.ToInt32(Console.ReadLine());

            double fuelNeeded = distance / kmPerLiter;
            double tripCost = fuelNeeded * fuelPrice;
            // Tre måder at gøre det på!
            //Console.WriteLine("Jamen så har du brug for" + " " + fuelNeeded + " " + "liter" + " " + fuelType + " " + "og turen vil koste dig" + " " + tripCost + " " + "kr");
            Console.WriteLine($"Jamen så har du brug for {fuelNeeded} liter {fuelType} og turen vil koste dig {tripCost} kr");
            // string carinfo = String.Format("Jamen så har du brug for {0} liter {1} og turen vil koste dig {2} kr.", fuelNeeded, fuelType, tripCost);
            //Console.WriteLine(carinfo);
            double newKiloStand = kiloStand + distance;


            Console.WriteLine("Desuden er din bils nye kilometerstand" + " " + newKiloStand + " " + "km");

        }
        // Method to drive and log a trip
        public void Drive(Trip newTrip)
        {
            trips.Add(newTrip);
            _odometer += newTrip.Distance;
        }

        // Method to print all trips
        public void PrintAllTrips()
        {
            foreach (var trip in trips)
            {
                trip.PrintTripDetails();
                Console.WriteLine("-------------------------");
            }
        }
}
