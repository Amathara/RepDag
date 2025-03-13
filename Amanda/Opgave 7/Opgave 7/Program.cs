namespace Opgave_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Opgave 7
            //Er tallet negativt, positivt eller lig 0?

              Console.WriteLine("Skriv et tal:");
               double tal = Convert.ToDouble(Console.ReadLine());

               if (tal > 0)
               {
                   Console.WriteLine("Du skrev et positivt tal");
               }

               else if (tal <0)
                   {

                   Console.WriteLine("Du skrev et negativt tal");
               }
              else if (tal == 0)
               {
                   Console.WriteLine("Du skrev 0");
               }

                   Console.ReadLine(); 

        }
    }
}
