namespace Opgave_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(
                "Choose an option: \n" +
                "1. Convert Celsius to Freedom units \n" +
                "2. Convert Freedom units to Celsius \n" +
                "3. Exit Program \n");

            int choice = int.Parse(Console.ReadLine());

            double celsius = 0;
            double fahrenheit = 0;

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter Celsius Value: ");
                    celsius = Convert.ToDouble(Console.ReadLine());                    
                    fahrenheit = CelsiusToFahrenheit(celsius);
                    Console.WriteLine($"{celsius}° is {fahrenheit}F");
                    break;
                case 2:
                    Console.WriteLine("Enter Freedom Unit Value: ");
                    fahrenheit = Convert.ToDouble(Console.ReadLine());
                    celsius = FahrenheitToCelsius(fahrenheit);
                    Console.WriteLine($"{fahrenheit}F is {celsius}°");
                    break;
                case 3:
                    Console.WriteLine("Exiting..");
                    break;
            }

            Console.ReadKey();
        }

        static double CelsiusToFahrenheit(double celsius)
        {
            return (celsius * (9 / 5) + 32);
        }

        static double FahrenheitToCelsius(double fahrenheit)
        {
            return ((fahrenheit - 32) * (5 / 9));
        }
    }

}
