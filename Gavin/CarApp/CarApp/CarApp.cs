using Microsoft.VisualBasic;

namespace CarApp
{
    internal class Program
    {
   
        static int distance = 1;
        static bool menuRunning = true;
        static string lineSeparator = new String('-', 30);
        static double fuelPrice;
        static Car myCar;

        static void Main()
        {
            while (menuRunning)
            {
                Console.WriteLine(lineSeparator);
                Console.WriteLine(
                    "1. Input Car Details \n" +
                    "2. See Car Details \n" +
                    "3. Drive \n" +
                    "4. Calculate Trip Price \n" +
                    "5. Show Previous Trips \n" +
                    "6. Palindrome Test \n" +
                    "7. Stop Program");
                Console.WriteLine(lineSeparator);

                Console.WriteLine("\nSelect Function");
                int menu = int.Parse(Console.ReadLine());

                switch (menu)
                {
                    case 1: //Input Car Details
                        InputCarDetails();
                        break;
                    case 2: //See Car Details
                        if (myCar == null)
                        {
                            Console.WriteLine("Input Car Details First");
                        }
                        else
                        {
                            PrintCarDetails();
                        }
                        break;
                    case 3: //Drive
                        if (myCar == null)
                        {
                            Console.WriteLine("Input Car Details First");
                        }
                        else
                        {
                            myCar.EngineStatus();
                            if (myCar.IsEngineOn)
                            {
                                Console.WriteLine("Enter Distance to drive: ");
                                distance = int.Parse(Console.ReadLine());

                                DateTime tripDate = DateTime.Today;
                                DateTime startTime = DateTime.Now;
                                myCar.Drive(distance);
                                DateTime endTime = DateTime.Now;
                                
                                

                                Trip trip = new Trip(distance, startTime, endTime, tripDate);
                                myCar.AddTrip(trip);
                            }
                            else
                            {
                                Console.WriteLine("Car Engine Is Off!");
                            }
                        }
                        break;
                    case 4: //Calculate Trip Price
                        if (myCar == null)
                        {
                            Console.WriteLine("Input Car Details First");
                        }
                        else
                        {
                            double fuelPrice = CheckFuelPrice();             
                            
                            Trip lastTrip = myCar.Trips[myCar.Trips.Count - 1];

                            double tripCost = lastTrip.CalculateTripPrice(myCar, fuelPrice);
                            Console.WriteLine($"Trip cost is: {tripCost}DKK");
                        }
                        break;
                    case 5: //Show Previous Trips
                        if (myCar == null)
                        {
                            Console.WriteLine("Input Car Details First");
                        }
                        else
                        {
                            myCar.ShowPreviousTrips();
                        }
                        break;
                    case 6: //Palindrome Test
                        IsPalindrome();
                        break;
                    case 7: //Stop Program
                        menuRunning = false;
                        break;

                }
            }
        }

        static void InputCarDetails()
        {
            //Getting user input for variables.
            Console.WriteLine("Enter Brand: ");
            string brand = Console.ReadLine();

            Console.WriteLine("Enter Model: ");
            string model = Console.ReadLine();

            Console.WriteLine("Enter Fuel Type (Benzin, Diesel, Electric or Hybrid): ");
            string fuelInput = Console.ReadLine();

            FuelType fuelType;

            switch (fuelInput.ToLower())
            {
                case "benzin":
                    fuelType = FuelType.Benzin;
                    break;
                case "diesel":
                    fuelType = FuelType.Diesel;
                    break;
                case "electric":
                    fuelType = FuelType.Electric;
                    break;
                case "hybrid":
                    fuelType = FuelType.Hybrid;
                    break;
                default:
                    fuelType = FuelType.Benzin;
                    break;
            }

            Console.WriteLine("Enter Year: ");
            int year = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Gear Type (Auto or Manuel): ");
            char gearType = Console.ReadLine()[0];

            Console.WriteLine("Enter Km/L: ");
            double kmPerL = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter Mileage");
            int mileage = int.Parse(Console.ReadLine());

            //Creating Car object
            myCar = new Car(brand, model, fuelType, year, mileage, gearType, kmPerL);

        }            

        static bool IsPalindrome()
        {
            string odometer = myCar.Mileage.ToString();
            int length = odometer.Length;

            for (int i = 0; i < length / 2; i++)
            {
                if (odometer[i] != odometer[length - 1 - i])
                {
                    Console.WriteLine($"Mileage {myCar.Mileage} isn't a Palindrome");
                    return false;
                }
            }
            Console.WriteLine($"Mileage {myCar.Mileage} is a Palindrome");
            return true;
        }

        static double CheckFuelPrice()
        {
            switch (myCar.FuelType)
            {
                case FuelType.Benzin:
                    return 13.49;
                case FuelType.Diesel:
                    return 10.00;
                case FuelType.Electric:
                    return 5.00;
                case FuelType.Hybrid:
                    return 7.00;
                default:
                    return 13.49;
            }
        }

        static void PrintCarDetails()
        {
            Console.WriteLine(lineSeparator);
            Console.WriteLine(
                $"Brand: {myCar.Brand} \n" +
                $"Model: {myCar.Model} \n" +
                $"Fuel Type: {myCar.FuelType} \n" +
                $"Year: {myCar.Year} \n" +
                $"Gear Type: {myCar.GearType} \n" +
                $"Km/L: {myCar.KmPerLiter} \n" +
                $"Mileage: {myCar.Mileage}");
            Console.WriteLine(lineSeparator);

        }
    }        
}
