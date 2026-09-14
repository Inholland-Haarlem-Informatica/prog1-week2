namespace Assignment10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Start();
            Console.ReadKey();
        }

        static void Start()
        {
            Console.Write("Enter a letter: ");
            char letter = char.Parse(Console.ReadLine());

            if (IsLetterVowel(letter))
            {
                Console.WriteLine($"{letter} is a vowel.");
            }
            else
            {
                Console.WriteLine($"{letter} is a consonant.");
            }
        }

        static bool IsLetterVowel(char letter)
        {
            if (letter == 'e' || letter == 'a' || letter == 'i' || letter == 'o' || letter == 'u')
            {
                return true;
            }

            return false;

        }
    }
}
