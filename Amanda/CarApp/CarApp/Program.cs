using System.Collections;
using System.Runtime.InteropServices;
using System.Transactions;

namespace CarApp
{
    internal class Program
    {


        static void Main(string[] args)
        {
            // Object!! Adding a specific car manually IN the code, not the console.
            Car baseCar = new Car("Toytoa", "Corolla", 2020, 'A', 2609, "Benzin", true, 30);



            /*
            For at få info om "myCar"
            Console.WriteLine(myCar.GetCarInfo());

            

            Console.WriteLine(myCar.Drive(50));
            */

            // Start menuen:
            Console.WriteLine("Hej!");

            // Tilføjer et delay før næste linje kommer:
            System.Threading.Thread.Sleep(2300);

            bool running = true;
            while (running)
            {

                // Menu til at kalde "metoder"
                Console.WriteLine("Hvad vil du nu? \n " +
                "\n 1. Tilføje en bil til listen!\n " +
                "\n 2. Køre en tur i standardbilen!\n " +
                "\n 3. Beregne pris for køretur $ (indtast manuelt detaljer) \n " +
                "\n 4. Vide om vi har et plaindrom (i standardbil)\n " +
                "\n 5. Se bildetaljer for standardbil! \n" +
                "\n 6. Jeg vil se mig ALLE bilers detaljer! \n " +
                "\n 7. Afslut programmet :( ");

                int valg = int.Parse(Console.ReadLine());

                switch (valg)
                {
                    case 1:
                        tilføjBil();
                        Console.WriteLine("\nTryk <Enter> for at komme tilbage til menuen.\n");
                       
                        break;
                    case 2:
                        Console.WriteLine(baseCar.Drive(50));
                        Console.WriteLine("\nTryk <Enter> for at komme tilbage til menuen.\n");
                        break;
                    case 3:

                        beregnPris();
                        break;
                    case 4:
                        Console.WriteLine("\nDenne option er under konstruktion.");
                        Console.WriteLine("\nTryk <Enter> for at komme tilbage til menuen.\n");
                        //harViPalindrom(kiloStand);
                        break;
                    case 5:

                        Console.WriteLine(baseCar.GetCarInfo());
                        Console.WriteLine("\nTryk <Enter> for at komme tilbage til menuen.\n");
                        break;
                    case 6:
                        Console.WriteLine("\nDenne option er under konstruktion.");
                        Console.WriteLine("\nTryk <Enter> for at komme tilbage til menuen.\n");
                        //visAlleBilDetaljer();
                        break;

                    case 7:
                        Console.WriteLine("Ses!");
                        running = false;
                        break;

                }
                Console.ReadLine();
                // Case 1: Tilføj en bil.
                //Metode
                void tilføjBil()
                {
                    // List to store multiple cars
                    List<Car> carCollection = new List<Car>();

                    // Asking the user for a name to assign to the car
                    Console.WriteLine("Navngiv bilen:");
                    string carName = Console.ReadLine();

                    // Asking the user for car details
                    Console.WriteLine("Skriv Bilmærke:");
                    string brand = Console.ReadLine();

                    Console.WriteLine("Skriv bilmodel:");
                    string model = Console.ReadLine();

                    Console.WriteLine("Skriv årgang (fx. 2020):");
                    int year = int.Parse(Console.ReadLine());

                    Console.WriteLine("Skriv geartype (A for automatisk og M for manuel):");
                    char gear = char.Parse(Console.ReadLine());

                    Console.WriteLine("Skriv kilometerstand (fx. 2609):");
                    double odometer = double.Parse(Console.ReadLine());

                    Console.WriteLine("Skriv drivstofstype (vælg mellem Benzin og Diesel):");
                    string fuelType = Console.ReadLine();

                    Console.WriteLine("Er motoren tændt? (true/false):");
                    bool isEngineOn = bool.Parse(Console.ReadLine());

                    Console.WriteLine("Hvor mange km kan den køre på litren?");
                    double kmPerLiter = double.Parse(Console.ReadLine());

                    // Creating a new car object with the provided data
                    Car newCar = new Car(brand, model, year, gear, odometer, fuelType, isEngineOn, kmPerLiter);

                    // Adding the car to the list
                    carCollection.Add(newCar);

                    // Displaying the car info
                    Console.WriteLine($"\nBil '{carName}' Information:");
                    Console.WriteLine(newCar.GetCarInfo());
                }

                // Case 3: (Er ikke forbundet med car klassen endnu!!)
                // Metode
                void beregnPris()
                    
                {
                    Console.WriteLine("For at kunne beregne prisen for din tur skal vi først bruge nogle oplysninger:");
                    Console.WriteLine("Bruger bilen diesel eller benzin?");
                    string fuelType = Console.ReadLine();

                    // Definerer fuelPrice
                    double fuelPrice = 0;


                    if (fuelType.ToLower() == "diesel")
                    {
                        fuelPrice = 12.29;
                    }
                    else if (fuelType.ToLower() == "benzin")
                    {
                        fuelPrice = 13.49;
                    }
                    else
                    {
                        fuelPrice = 13.49;
                    }





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
                // Case 6:
               
            }
        }
    }
}
