namespace Opgave_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Angiv nummer: ");
            int number = int.Parse(Console.ReadLine());

            if (number == 0)
            {
                Console.WriteLine("Number is zero");
            }
            else if (number < 0)
            {
                Console.WriteLine("Number is negativ");
            }
        


            Console.WriteLine("Hello, World!");

          
        }
    }
}
