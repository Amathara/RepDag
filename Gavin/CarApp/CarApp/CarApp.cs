using Microsoft.VisualBasic;

namespace CarApp
{
    internal class Program
    {
        //Menu
        static bool menuActive = true;

        //Instantiating and initializing Car class into userCar
        static Car userCar = new Car("Empty", "Empty", 0, 0, 0, 'A', Car.FuelType.Gasoline, false);

        //Main menu
        static void Main(string[] args)
        {
            while (menuActive)
            {
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1. Input Car Details");
                Console.WriteLine("2. See Car Details");
                Console.WriteLine("3. Drive");
                Console.WriteLine("4. Show Previous Trips");
                Console.WriteLine("5. Exit Program");

                int menuChoice = int.Parse(Console.ReadLine());

                //Switch case for menu selection
                switch (menuChoice)
                {
                    case 1:
                        InputCarDetails();
                        break;
                    case 2:
                        PrintCarDetails();
                        break;



                }
            }
        }

        //Method for inputting car details
        static void InputCarDetails()
        {
            //Get user input and assign to instantiated Car
            Console.WriteLine("Enter Brand: ");
            userCar.Brand = Console.ReadLine().ToString();

            Console.WriteLine("Enter Model: ");
            userCar.Model = Console.ReadLine().ToString();

            Console.WriteLine("Enter Year: ");
            userCar.Year = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Mileage: ");
            userCar.Mileage = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter Km/L: ");
            userCar.KmPerL = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter Gear Type (M or A): ");
            userCar.GearType = char.Parse(Console.ReadLine());

            Console.WriteLine("Enter Fuel Type (Gasoline, Diesel, Electric, Hybrid): ");
            string fuelInput = Console.ReadLine().ToLower();

            //Check fuelInput strings index 0, and use that for switch case
            char fuelChar = fuelInput[0];

            switch (fuelChar)
            {
                case 'g':
                    userCar.Fuel = Car.FuelType.Gasoline;
                    break;
                case 'd':
                    userCar.Fuel = Car.FuelType.Diesel;
                    break;
                case 'e':
                    userCar.Fuel = Car.FuelType.Electric;
                    break;
                case 'h':
                    userCar.Fuel = Car.FuelType.Hybrid;
                    break;
                default:
                    Console.WriteLine("Input Invalid. Defaulting to Gasoline");
                    userCar.Fuel = Car.FuelType.Gasoline;
                    break;
            }

            //Engine off by default
            userCar.IsEngineOn = false;

            Console.WriteLine("Car Created");
        }

        //Method for printing userCar info
        static void PrintCarDetails()
        {
            Console.WriteLine("Car Details:");
            Console.WriteLine($"Brand : {userCar.Brand}");
            Console.WriteLine($"Model : {userCar.Model}");
            Console.WriteLine($"Year : {userCar.Year}");
            Console.WriteLine($"Mileage : {userCar.Mileage}");
            Console.WriteLine($"Km/L : {userCar.KmPerL}");
            Console.WriteLine($"Gear Type : {userCar.GearType}");
            Console.WriteLine($"Fuel Type : {userCar.Fuel}");
        }
    }
}
