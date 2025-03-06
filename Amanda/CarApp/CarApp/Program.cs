namespace CarApp
{
    internal class Program
    {


        static void Main(string[] args)
        {
            // Object!! Adding a specific car.
            Car myCar = new Car("Toytoa", "Corolla", 2020, 'A', 2609, "Benzin", true, 30);



            /*

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
                "\n 1. Tilføje bildetaljer.\n " +
                "\n 2. Køre en tur!\n " +
                "\n 3. Beregne pris for køretur $ \n " +
                "\n 4. Vide om vi har et plaindrom?\n " +
                "\n 5. Se bildetaljer! \n" +
                "\n 6. Jeg vil se mig ALLE bilers detaljer! \n " +
                "\n 7. Afslut programmet :( ");

                int valg = int.Parse(Console.ReadLine());

                switch (valg)
                {
                    case 1:
                        Console.WriteLine("Denne option er under konstruktion.\nTryk 'Enter' for at komme tilbage til menuen.");
                        Console.ReadLine();
                        break;
                    case 2:
                        Console.WriteLine(myCar.Drive(50));
                        break;
                    case 3:

                        //beregnPris();
                        break;
                    case 4:
                        Console.WriteLine("Denne option er under konstruktion.\nTryk 'Enter' for at komme tilbage til menuen.");
                        Console.ReadLine();
                        //harViPalindrom(kiloStand);
                        break;
                    case 5:

                        Console.WriteLine(myCar.GetCarInfo());
                        break;
                    case 6:
                        Console.WriteLine("Denne option er under konstruktion.\nTryk 'Enter' for at komme tilbage til menuen.");
                        Console.ReadLine();
                        //visAlleBilDetaljer();
                        break;

                    case 7:
                        Console.WriteLine("Ses!");
                        running = false;
                        break;

                }
                Console.ReadLine();

            }
        }
    }
}
