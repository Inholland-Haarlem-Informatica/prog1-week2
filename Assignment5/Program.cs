namespace Assignment5
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
            Console.Write("Enter the first number: ");
            int number1 = int.Parse(Console.ReadLine());

            Console.Write("Enter the second number: ");
            int number2 = int.Parse(Console.ReadLine());

            Console.Write("Enter the third number: ");
            int number3 = int.Parse(Console.ReadLine());

            Console.WriteLine($"The largest number is {FindMax(number1, number2, number3)}.");
        }

        static int FindMax(int number1, int number2, int number3)
        {
            if (number1 > number2 && number1 > number3)
            {
                return number1;
            }
            else if (number2 > number1 && number2 > number3)
            {
                return number2;
            }
            else if (number3 > number1 && number3 > number2)
            {
                return number3;
            }
            else
            {
                return 0;
            }
        }
    }
}
