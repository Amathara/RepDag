using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarApp
{
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

        //Constructor:
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
        // Method: Get car info.
        public string GetCarInfo()
        {
            return $"Brand: {_brand}\n\nModel: {_model}\n\nYear: {_year}\n\nGear: {_gear}\n\nMilage: {_odometer}\n\nFuel Type: {_fuelType}\n\n Engine is on: {_isEngineOn};\n\n Can drive: {_kmPerLiter} km per liter of fuel";
        }
    }
}
