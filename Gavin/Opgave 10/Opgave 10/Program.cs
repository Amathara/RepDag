namespace Opgave_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose option: ");

            Console.WriteLine(
                "1. Monday \n"+
                "2. Tuesday \n"+
                "3. Wendesday \n"+
                "4. Thursday \n"+
                "5. Friday \n"+
                "6. Saturday \n"+
                "7. Sunday \n");
            
            int menu = int.Parse(Console.ReadLine());


            switch (menu)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;

            }

            Console.ReadKey();
        }
    }
}
