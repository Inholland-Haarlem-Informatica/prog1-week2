namespace Assignment3
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
            Console.Write("Enter a number: ");
            int input = int.Parse(Console.ReadLine());
            CheckNumber(input);
        }

        static void CheckNumber(int number)
        {
            if (number == 0)
            {
                Console.WriteLine("The number is zero.");
            }
            else if (number < 0)
            {
                Console.WriteLine("The number is negative.");
            }
            else
            {
                Console.WriteLine("The number is positive.");
            }
        }
    }
}
