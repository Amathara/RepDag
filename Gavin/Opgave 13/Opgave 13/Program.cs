namespace Opgave_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 1;
            bool count = true;

            while (count)
            {
                Console.WriteLine(num);
                num++;
                if (num == 11)
                {
                    count = false;
                }
            }

            Console.ReadKey();
        }
    }
}
