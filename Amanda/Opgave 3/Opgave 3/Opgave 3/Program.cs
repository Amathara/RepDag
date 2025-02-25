namespace Opgave_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Opgave 3
            //BMI opgave
            //formel: BMI=vægten/højde^2
            
            Console.WriteLine("Nu skal vi udregne BMI!");
            Console.WriteLine("Indtast vægt (kg):");
            double vægt = Double.Parse(Console.ReadLine());

            Console.WriteLine("Indtast højde (meter - brug komma, IKKE punktum):");
            double højde = Double.Parse(Console.ReadLine());

            

          

            double bmi = vægt / (højde * højde);

            Console.WriteLine($"Dit bmi er:{bmi}");

            
        }
    }
}
