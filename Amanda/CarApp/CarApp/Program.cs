namespace CarApp
{
    internal class Program
    {


        static void Main(string[] args)
        {
            // Object!! Adding a specific car.
            Car myCar = new Car("Toytoa", "Corolla", 2020, 'A', 2609, "Benzin", true, 30);

            Console.WriteLine(myCar.GetCarInfo());

            Console.ReadLine();
            

        }
    }
}
