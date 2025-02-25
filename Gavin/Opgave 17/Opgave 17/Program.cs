namespace Opgave_17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input number 1: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Input number 2: ");
            double num2 = double.Parse(Console.ReadLine());

            double result = Sum(num1, num2);

            Console.WriteLine($"Sum of {num1} and {num2} is: {result}");

            Console.ReadKey();

        }

        static double Sum(double num1, double num2)
        {
            return num1 + num2;
        }
    }
}
