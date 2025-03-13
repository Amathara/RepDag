namespace Opgave_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Opgave 11
            // Årets måneder!
            Console.WriteLine("Hej!\nLad os finde en måned!\nSkriv et tal mellem 1 og 12");
            int måned = Convert.ToInt32(Console.ReadLine());

            switch (måned)
            {
                case 1:
                    Console.WriteLine("Januar: en vintermåned der er mørk og grå. Giver tendens til vinterdeprression ;)");
                    break;
                case 2:
                    Console.WriteLine("Februar: også en vintermåned. Lidt mindre mørk og grå end januar.");
                    break;
                case 3:
                    Console.WriteLine("Marts");
                    break;
                case 4:
                    Console.WriteLine("April");
                    break;
                case 5:
                    Console.WriteLine("Maj");
                    break;
                case 6:
                    Console.WriteLine("Juni");
                    break;
                case 7:
                    Console.WriteLine("Juli");
                    break;
                case 8:
                    Console.WriteLine("August");
                    break;
                case 9:
                    Console.WriteLine("September");
                    break;
                case 10:
                    Console.WriteLine("Oktober");
                    break;
                case 11:
                    Console.WriteLine("November");
                    break;
                case 12:
                    Console.WriteLine("December!");
                    break;
            }
            Console.ReadLine();
        }
    }
}
