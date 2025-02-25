namespace Opgave_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input Number: ");
            double num = double.Parse(Console.ReadLine());

            if (num > 0)
            {
                Console.WriteLine("Number is positive");
            }
            else if (num < 0)
            {
                Console.WriteLine("Number is negative");
            }
            else
            {
                Console.WriteLine("Number is 0");
            }

            Console.ReadKey();
        }
    }
}
