using System;
using CarApp;


public class Car
{
    //Property
    public string Brand { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public double Mileage { get; set; }
    public double KmPerL { get; set; }
    public char GearType { get; set; }
    public bool IsEngineOn { get; set; }
    public enum FuelType
    {
        Gasoline,
        Diesel,
        Electric,
        Hybrid
    }
    public FuelType Fuel { get; set; }
    public List<Trip> tripList { get; set; } = new List<Trip>();

    //Constructor
    public Car(string brand, string model, int year, double mileage, double kmPerL, char gearType, FuelType fuel, bool isEngineOn)
    {
        this.Brand = brand;
        this.Model = model;
        this.Year = year;
        this.Mileage = mileage;
        this.KmPerL = kmPerL;
        this.GearType = gearType;
        this.Fuel = fuel;
        this.IsEngineOn = isEngineOn;

    }

    //Drive method
    public void Drive(double distance)
    {
        if (IsEngineOn == true && distance > 0)
        {
            //Updating mileage
            Mileage += distance;
            
            //Creating new trip based on distance and time
            Trip newTrip = new Trip(distance, DateTime.Now);

            //Adding new trip to list of trips
            tripList.Add(newTrip);

            //Calculate fuel consumption
            double fuelUsed = newTrip.FuelConsumption(KmPerL);

            //Print trip info
            Console.WriteLine($"You drove {distance}");
            Console.WriteLine($"New Mileage is: {Mileage}");
            Console.WriteLine($"Fuel Used: {fuelUsed}");
        }
        else if (IsEngineOn == false)
        {
            Console.WriteLine("Engine is turned off");
            EngineStatus();
        }
    }

    //Engine status method
    public void EngineStatus()
    {
        Console.WriteLine("Start Engine? (Yes or No)");
        string input = Console.ReadLine().ToLower();

        if (input == "yes" || input == "y")
        {
            IsEngineOn = true;
            Console.WriteLine("Engine is on");
        }
        else
        {
            Console.WriteLine("Engine is off");
        }

        
    }
}

