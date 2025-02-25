namespace Opgave_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input radius: ");
            double radius = double.Parse(Console.ReadLine());

            double area = Area(radius);
            Console.WriteLine($"Area is: {area}");

            double circumference = Circumference(radius);
            Console.WriteLine($"Circumference is: {circumference}");

            Console.ReadKey();
        }

        static double Area(double radius)
        {
            return (Math.PI * (radius * radius));
        }

        static double Circumference(double radius) 
        {
            return (2 * Math.PI * radius); 
        }


    }
}
