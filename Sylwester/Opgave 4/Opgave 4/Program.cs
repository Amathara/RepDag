using System.Xml.Linq;

namespace Opgave_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberA = 6;

            int numberB = 4;

            int sum = numberA + numberB;

            int dif = numberA - numberB;

            int product = numberA * numberB;

            double quotient = numberA / (double)numberB;

            int remainder = numberA % numberB;

            Console.WriteLine($"A = {numberA} and B = {numberB}");

            Console.WriteLine($"Sum: {sum}, difference: {dif}, produkt: {product}, kvotient: {quotient:F2} og modulus: {remainder}");


            Console.ReadLine();



        }
    }
}
