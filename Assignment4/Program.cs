namespace Assignment4
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
            double number1 = double.Parse(Console.ReadLine());

            Console.Write("Enter the second number: ");
            double number2 = double.Parse(Console.ReadLine());

            Console.Write("Choose an operation (+, -, *, /): ");
            string operation = Console.ReadLine();

            CalculateResult(number1, number2, operation);
        }

        static void CalculateResult(double number1, double number2, string operation)
        {
            switch (operation)
            {
                case "+":
                    Console.WriteLine($"The result is {Add(number1, number2)}.");
                    break;
                case "-":
                    Console.WriteLine($"The result is {Subtract(number1, number2)}.");
                    break;
                case "*":
                    Console.WriteLine($"The result is {Multiply(number1, number2)}.");
                    break;
                case "/":
                    Console.WriteLine($"The result is {Divide(number1, number2)}.");
                    break;
                default:
                    Console.WriteLine("Verkeerde waarde ingevoerd.");
                    break;
            }
        }

        static double Add(double num1, double num2)
        {
            return num1 + num2;
        }

        static double Subtract(double num1, double num2)
        {
            return num1 - num2;
        }

        static double Multiply(double num1, double num2)
        {
            return num1 * num2;
        }

        static double Divide(double num1, double num2)
        {
            return num1 / num2;
        }
    }
}
