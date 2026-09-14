namespace Assignment2
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
            Console.Write("Please enter a number: ");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine($"{number} is " + (IsEven(number) ? "even." : "odd."));

        }

        static bool IsEven(int number)
        {
            if (number % 2 == 0)
            {
                return true;
            }

            return false;

        }
    }
}
