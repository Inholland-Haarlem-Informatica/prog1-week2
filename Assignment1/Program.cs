namespace Assignment1
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
            Console.Write("Please enter your age: ");
            int age = int.Parse(Console.ReadLine());

            if (IsAdult(age))
            {
                Console.WriteLine("You are an adult.");
            }
            else
            {
                Console.WriteLine("You are a minor.");
            }
        }

        static bool IsAdult(int age)
        {
            if (age >= 18)
            {
                return true;
            }

            return false;

        }
    }
}
