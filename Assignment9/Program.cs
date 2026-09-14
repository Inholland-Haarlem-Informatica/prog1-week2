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
            Console.WriteLine($"Feedback: {GetGradeFeedback(score)}");
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

        static string GetGradeFeedback(int score)
        {
            switch (score)
            {
                case >= 90:
                    return "Excellent work!";
                case >= 80:
                    return "Good job, but there’s room for improvement.";
                case >= 70:
                    return "You passed, but consider reviewing the material.";
                case >= 60:
                    return "Barely passed, you should work harder.";
            }

            return "Failed, please seek help.";
        }
    }
}
