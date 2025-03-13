namespace Opgave_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Opgave 8
            Console.WriteLine("Har du bestået prøven? \nSkriv din karakter (mellem -3 til 12):");
              int karakter = Convert.ToInt32(Console.ReadLine());

              if (karakter >= 2)
              {
                  Console.WriteLine("Yay! Du bestod");
              }

              else
              {
                  Console.WriteLine("Desværre, du bestod ikke denne gang.");
              }
            
            Console.ReadLine();
        }
    }
}
