namespace Opgave_19
{
    internal class Program
    {
        static int vowelCount = 0;

        static void Main(string[] args)
        {
            Console.WriteLine("Input Text: ");
            string text = Console.ReadLine().ToLower();

            VowelCheck(text);
            Console.WriteLine($"There are {vowelCount} vowels in {text}");

            Console.ReadKey();
        }

        /*static void VowelCheck(string text) {

            char[] chars = text.ToCharArray();

            for (int i = 0; i < chars.Length; i++) {

                if (chars[i] == 'a'|| chars[i] == 'e'|| chars[i] == 'i' || chars[i] == 'o'
                        || chars[i] == 'u' || chars[i] == 'y' || chars[i] == 'æ' || chars[i] == 'ø' || chars[i] == 'å')
                {
                    vowelCount++;
                }
            }
        }*/

        static void VowelCheck(string text)
        {
            string vowels = "aeiouyæøå";

            foreach (char letter in text)
            {
                if (vowels.Contains(letter))
                {
                    vowelCount++;
                }
            }
        }
    }
}
