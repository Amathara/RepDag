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
            Mileage += distance;
            Console.WriteLine($"You drove {distance}. New Mileage is: {Mileage}");
        }
        else if (IsEngineOn == false)
        {
            Console.WriteLine("Engine is turned off. Turn on Engine? (Yes or No)");
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

