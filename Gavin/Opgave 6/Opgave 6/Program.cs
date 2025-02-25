namespace Opgave_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 10;
            int num2 = 20;

            bool isEqual = num1 == num2;
            bool isNotEqual = num1 != num2;
            bool isGreater = num1 > num2;
            bool isLess = num1 < num2;
            bool isGreaterOrEqual = num1 >= num2;
            bool isLessOrEqual = num1 <= num2;

            Console.WriteLine($"{num1} Is Equal to {num2}: {isEqual}");
            Console.WriteLine($"{num1} Is Not Equal to {num2}: {isNotEqual}");
            Console.WriteLine($"{num1} Is Greater Than {num2}: {isGreater}");
            Console.WriteLine($"{num1} Is Less Than {num2}: {isLess}");
            Console.WriteLine($"{num1} Is Greater Than or Equal to {num2}: {isGreaterOrEqual}");
            Console.WriteLine($"{num1} Is Less Than Equal to {num2}: {isLessOrEqual}");


            Console.ReadKey();
        }
    }
}
