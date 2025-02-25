namespace Opgave_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Grade (A,B,C,D,F)");
            char grade = char.Parse(Console.ReadLine().ToLower());

            if (grade == 'f')
            {
                Console.WriteLine("You done fucked up");
            }
            else
            {
                Console.WriteLine("You pass");
            }

            Console.ReadKey();
        }
    }
}
