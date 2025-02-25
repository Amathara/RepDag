namespace Opgave_20
{
    internal class Program

    {        
        static double length, width, radius;

        static void Main(string[] args)
        {
            Console.WriteLine("1. Square or 2. Circle?");
            int menu = int.Parse(Console.ReadLine());

            switch (menu)
            {
                case 1:
                    Console.WriteLine("Input length: ");
                    length = double.Parse(Console.ReadLine());

                    Console.WriteLine("Input width: ");
                    width = double.Parse(Console.ReadLine());

                    double squareArea = Area(length, width);
                    Console.WriteLine($"Area of Square is: {squareArea}");
                    break;

                case 2:
                    Console.WriteLine("Input radius");
                    radius = double.Parse(Console.ReadLine());

                    double circleArea = Area(radius);
                    Console.WriteLine($"Area of Circle is: {circleArea}");
                    break;
            }

            Console.ReadKey();
        }

        static double Area(double length, double width)
        {
            return length * width;
        }

        static double Area(double radius)
        {
            return Math.PI * (radius*radius);
        }
    }
}
