namespace DockerCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            ICalculator calculator = new Calculator();

            while (true)
            {
                Console.WriteLine("Choose an operation:");
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Subtraction");
                Console.WriteLine("3. Multiplication");
                Console.WriteLine("4. Division");
                Console.WriteLine("5. Exit");

                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        PerformOperation(calculator.Add, "Plus");
                        break;
                    case "2":
                        PerformOperation(calculator.Subtract, "Minus");
                        break;
                    case "3":
                        PerformOperation(calculator.Multiply, "Multiply");
                        break;
                    case "4":
                        PerformOperation(calculator.Divide, "Divide");
                        break;
                    case "5":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        static void PerformOperation(Func<double, double, double> operation, string operationName)
        {
            Console.Write("Enter the first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double result = operation(num1, num2);
            Console.WriteLine($"{num1} {operationName} {num2} = {result}");
            Console.WriteLine();
        }
    }
}