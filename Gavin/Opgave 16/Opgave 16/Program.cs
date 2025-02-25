namespace Opgave_16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int factorial = 1;

            Console.WriteLine("Input number: ");
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                factorial *= i;
            }

            Console.WriteLine($"Factorial of {num} is: {factorial}");

            Console.ReadKey();
        }
    }
}
