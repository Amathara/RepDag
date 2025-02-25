namespace Opgave_18
{
    internal class Program
    {
        static string words = "abcd";

        static void Main(string[] args)
        {
            Console.WriteLine("Input words!");
            words = Console.ReadLine();

            Console.WriteLine(Reverse(words));

            Console.ReadKey();

        }

        static string Reverse(string words)
        {

            char[] chars = words.ToCharArray();

            Array.Reverse(chars); //For real??
           
            return new string(chars);
        }
    }
}
