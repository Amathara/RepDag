using System.ComponentModel.DataAnnotations;

namespace Opgave_22
{
    internal class Program
    {
        static double length, width, height;

        static void Main(string[] args)
        {
            Console.WriteLine("1. Triangle or 2. Square?");
            int menu = int.Parse(Console.ReadLine());

            switch (menu)
            {
                case 1:
                    Console.WriteLine("Input Height: ");
                    height = double.Parse(Console.ReadLine());

                    Console.WriteLine("Input Length: ");
                    length = double.Parse(Console.ReadLine());

                    double triangleArea = Area(height, length, 0.5);
                    Console.WriteLine($"Area of Triangle is: {triangleArea}");
                    break;

                case 2:
                    Console.WriteLine("Input length: ");
                    length = double.Parse(Console.ReadLine());

                    Console.WriteLine("Input width: ");
                    width = double.Parse(Console.ReadLine());

                    double squareArea = Area(length, width);
                    Console.WriteLine($"Area of Square is: {squareArea}");
                    break;
            }

            Console.ReadKey();
        }

        static double Area(double height, double length, double multiplier)
        {
            return 0.5*height*length;
        }

        static double Area(double length, double width)
        {
            return length * width;
        }
    }
}
