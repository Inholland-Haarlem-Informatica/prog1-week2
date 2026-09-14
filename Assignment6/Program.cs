namespace Assignment6
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
            Console.Write("Enter your score (0-100): ");
            int score = int.Parse(Console.ReadLine());

            if (score < 0 || score > 100)
            {
                Console.WriteLine("Invalid input. Please enter a valid score.");
                return;
            }

            Console.WriteLine($"Your grade is: {GetGrade(score)}");
        }

        static string GetGrade(int score)
        {
            switch (score)
            {
                case >= 90:
                    return "A";
                case >= 80:
                    return "B";
                case >= 70:
                    return "C";
                case >= 60:
                    return "D";
            }
            return "F";
        }
    }
}
