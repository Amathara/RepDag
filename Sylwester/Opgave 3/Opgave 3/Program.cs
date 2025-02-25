namespace Opgave_3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            float weight = 70f;

            float height = 1.75f;


            float bMI = weight / (height * height);


            Console.WriteLine($"BMI: {bMI:F2}");

            Console.ReadLine();


        }
    }
}
