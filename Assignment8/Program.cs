namespace Assignment8
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
            Console.Write("Enter a number (1-7) to get the day of the week: ");

            int dayNumber = int.Parse(Console.ReadLine());

            Console.WriteLine($"The day is: {GetDayOfWeek(dayNumber)}");
        }

        static string GetDayOfWeek(int dayNumber)
        {
            string[] weekdays = ["Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"];

            if (dayNumber < 1 || dayNumber > 7)
            {
                return "Invalid day number";
            }

            return weekdays[dayNumber - 1];
        }
    }
}
