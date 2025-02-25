namespace Opgave_21
{
    internal class Program
    {
        static double length, width, height, radius;
        static void Main(string[] args)
        {
            Console.WriteLine("1. Cube or 2. Cylinder?");
            int menu = int.Parse(Console.ReadLine());

            switch (menu)
            {
                case 1:
                    Console.WriteLine("Input Length: ");
                    length = double.Parse(Console.ReadLine());

                    Console.WriteLine("Input Width: ");
                    width = double.Parse(Console.ReadLine());

                    Console.WriteLine("Input Height: ");
                    height = double.Parse(Console.ReadLine());

                    double cubeVolume = Volume(length, width, height);
                    Console.WriteLine($"Volume of Cube is {cubeVolume}");
                    break;

                case 2:
                    Console.WriteLine("Input Radius: ");
                    radius = double.Parse(Console.ReadLine());

                    Console.WriteLine("Input Height: ");
                    height = double.Parse(Console.ReadLine());

                    double cylinderVolume = Volume(radius, height);
                    Console.WriteLine($"Volume of Cylinder is {cylinderVolume}");
                    break;
            }

            Console.ReadKey();

        }

        static double Volume(double length, double width, double height)
        {
            return length * width * height;
        }

        static double Volume(double radius, double height)
        {
            return Math.PI * (radius * radius) * height;
        }
    }
}
