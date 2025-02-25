using System.Xml.Linq;

namespace Opgave_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
         float celsius = 0f;

         float fahren = 212f;

         float cTF;
         float fTC;

            CelsiuToFar();

            Console.WriteLine($"Omregning fra {celsius:F1} Celsius til Fahrenheit: {cTF:F1}");

            FarToCel();

            Console.WriteLine($"Omregning fra {fahren:F1} Fahrenheit til Celsius: {fTC:F1}");

            Console.ReadLine();

            void CelsiuToFar ()
            {
               cTF = celsius * (9f / 5f) + 32f;
            }

            void FarToCel()
            {
                fTC = (fahren - 32f) * (5f / 9f);
            }
        }
    }
}
