namespace Opgave_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 10;
            int num2 = 5;

            int sum = num1 + num2;
            int difference = num1 - num2;
            int product = num1 * num2;
            int quotient = num1 / num2;
            int remainder = num1 % num2;

            Console.WriteLine(
                $"Sum: {sum}\n"+
                $"Difference: {difference}\n"+
                $"Product: {product}\n"+
                $"Quotient: {quotient}\n"+
                $"Remainder: {remainder}");



            Console.ReadKey();
        }
    }
}
