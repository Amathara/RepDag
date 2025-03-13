namespace Opgave_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Opgave 9
            //Er der skudår? Vi skal lave en if-else som tjekker om der er skudår.

            Console.WriteLine("Kan du finde et skudår? \nSkriv et årstal:");
             int årstal = Convert.ToInt32(Console.ReadLine());

             if ((årstal % 4 == 0 && årstal % 100 != 0) || (årstal % 400 == 0))
             {
                 Console.WriteLine("Yay! Du fandt et skudår");
             }

             else {
                 Console.WriteLine("Du fandt IKKE et skudår");
             }
             Console.ReadLine();

        }
    }
}
