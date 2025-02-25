namespace Opgave_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Opgave 2
            //Omregning mellem celcius og fahrenheit
            /* formler:
            F=c*(9/5)+32
            C=f-32*(5/9)
             */
            Console.WriteLine("Først omregner vi fra Fahrenheit til Celcius!");
             Console.WriteLine("Intast temp i Fahrenheit:");
             double f = Convert.ToDouble(Console.ReadLine());

             double c = ((f - 32.0) * (5.0 / 9.0));

             Console.WriteLine($"{f}°F is {c}°C");

             Console.WriteLine("Nu omregner vi fra Celcius til Fahrenheit!");
             Console.WriteLine("Intast temp i Celcius:");

             double newC = Convert.ToDouble(Console.ReadLine());

             double newF = (newC*(9.0 / 5.0)+32);

             Console.WriteLine($"{newC}°C is {newF}°F");

            Console.ReadLine();

        }
    }
}
