namespace Opgave_3
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Input weight");
            double weight = double.Parse(Console.ReadLine());

            Console.WriteLine("Input Height");
            float height = float.Parse(Console.ReadLine());

            double bmi = BmiCalculator(weight, height);
            Console.WriteLine($"Your BMI is: {bmi}");

            Console.ReadKey();
        }

        static double BmiCalculator(double weight, double height)
        {
            return (weight / (height * height)); 
        }
    }
}
