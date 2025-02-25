namespace Opgave_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            
            
            //Opgave 7


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

            else
            {
                Console.WriteLine("Number is positive");
            }

            Console.ReadLine();
        }
    }
}
