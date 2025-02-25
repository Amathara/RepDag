namespace Opgave_15
{
    using System.Globalization;
    using System.Linq;
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many numbers would you like?");
            int size = int.Parse(Console.ReadLine());

            int[] num = new int[size];

            for (int i = 0; i < size; i++)
            {
                Console.WriteLine($"Enter number {i + 1}");
                num[i] = int.Parse(Console.ReadLine());
            }

            int sum = num.Sum();

            Console.WriteLine($"Total sum is: {sum}");

            Console.ReadKey();
        }
    }
}
