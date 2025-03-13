using System;
using CarApp;

public enum FuelType 
{ 
    Benzin, 
    Diesel, 
    Electric, 
    Hybrid 
}
public class Car
{
    private string brand, model;
    private int year, mileage;
    private double kmPerLiter;
    private char gearType;
    private bool isEngineOn;
    private FuelType fuelType;
    private List<Trip> trips;
    

    public string Brand
    {
        get { return brand; }
        set
        {
            if (!string.IsNullOrWhiteSpace(value))
            {
                brand = value;
            }
            else
            {
                Console.WriteLine("Invalid Brand Input");
            }
        }
    }

    public string Model
    {
        get { return model; }
        set
        {
            if (!string.IsNullOrWhiteSpace(value))
            {
                model = value;
            }
            else
            {
                Console.WriteLine("Invalid Model Input");
            }
        }
    }

    public FuelType FuelType 
    { 
        get { return fuelType; } 
        set { fuelType = value; } 
    }

    public int Year
    {
        get { return year; }
        set { year = value; }
    }

    public int Mileage
    {
        get { return mileage; }
        set { mileage = value; }
    }

    public char GearType
    {
        get { return gearType; }
        set { gearType = value; }
    }

    public bool IsEngineOn
    {
        get { return isEngineOn; }
        set { isEngineOn = value; }
    }

    public double KmPerLiter
    {
        get { return kmPerLiter; }
        set { kmPerLiter = value; }
    }

    //Read Only 
    public List<Trip> Trips
    {
        get { return trips; }
    }

    public void AddTrip(Trip trip)
    {
        trips.Add(trip);
    }

    public void ShowPreviousTrips()
    {
        if (Trips.Count == 0)
        {
            Console.WriteLine("No Previous Trips");
            return;
        }
        else
        {
            Console.WriteLine("Previous Trips: ");
            foreach (Trip trip in Trips)
            {
                Console.WriteLine($"Date: {trip.TripDate}");
                Console.WriteLine($"Distance: {trip.Distance}");
                Console.WriteLine($"Duration: {trip.CalculateDuration()}");
                Console.WriteLine($"Fuel Used: {trip.CalculateFuelUsed(this)}");
            }
        }
    }


    public Car(string brand, string model, FuelType fuelType, int year, int mileage, char gearType, double kmPerLiter)
    {
        this.brand = brand;
        this.model = model;
        this.year = year;
        this.mileage = mileage;
        this.gearType = gearType;
        this.kmPerLiter = kmPerLiter;
        this.fuelType = fuelType;
        this.trips = new List<Trip>();
    }

    public void Drive(int distance)
    {
        if (IsEngineOn)
        {
            Mileage += distance;
            Console.WriteLine($"Drove {distance}km. New Mileage: {Mileage}");
        }
        else
        {
            Console.WriteLine("Engine is off");
        }
    }

    public void EngineStatus()
    {
        //Ask for input and convert to lowercase
        Console.WriteLine("Start Engine? (Yes or No): ");
        string input = Console.ReadLine().ToLower();

        if (input == "yes" || input == "y")
        {
            IsEngineOn = true;
            Console.WriteLine("Vroom Vroom");
        }
        else
        {
            IsEngineOn = false;
            Console.WriteLine("Engine is off");

        }
    }
}

