using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarApp
{
    // Adding "Car" class:
    internal class Car
    {
        string _brand;
        string _model;
        int _year;
        char _gear;
        double _odometer;
        string _fuelType;
        bool _isEngineOn;
        double _kmPerLiter;

        //Constructor: (Models how we input the data later in our "Object")
        public Car(string brand,string model, int year, char gear, double odometer, string fuelType, bool isEngineOn, double kmPerLiter)
        {
            _brand = brand;
            _model = model;
            _year = year;
            _gear = gear;
            _odometer = odometer;
            _fuelType = fuelType;
            _isEngineOn = isEngineOn;
            _kmPerLiter = kmPerLiter;
                
        }
        // Method: Get car info.is WITHIN the class, so it has the info it needs. Method is made public so I can add info in my "object" later.
        public string GetCarInfo()
        {
            return $"Brand: {_brand}\n\nModel: {_model}\n\nYear: {_year}\n\nGear: {_gear}\n\nMilage: {_odometer} km\n\nFuel Type: {_fuelType}\n\nEngine is on: {_isEngineOn}\n\nCan drive: {_kmPerLiter} km per liter of fuel";
        }
    }
}
