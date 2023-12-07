using Serilog;

namespace FizzBuzzProject
{
    class Program
    {
        static void Main(string[] args)
        {
            // Configure Serilog for logging
            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Debug()
                .WriteTo.Console()
                .WriteTo.File("logs/fizzbuzz.txt", rollingInterval: RollingInterval.Day)
                .CreateLogger();

            Log.Information("Starting FizzBuzz application");

            // Run an infinite loop to show the menu continuously until the user decides to exit
            while (true)
            {
                Console.WriteLine("\nFizzBuzz Application Menu:");
                Console.WriteLine("1. Run FizzBuzz");
                Console.WriteLine("2. View Instructions");
                Console.WriteLine("3. Exit");
                Console.Write("Select an option: ");

                string? option = Console.ReadLine(); // Allow 'option' to be null

                if (option is null)
                {
                    Log.Warning("No input received");
                    continue; // Skip the current iteration and show the menu again
                }

                try
                {
                    switch (option)
                    {
                        case "1":
                            RunFizzBuzz();
                            break;
                        case "2":
                            DisplayInstructions();
                            break;
                        case "3":
                            Log.Information("Exiting FizzBuzz application");
                            Log.CloseAndFlush();
                            return; // Exit the application
                        default:
                            Console.WriteLine("Invalid option. Please try again.");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Log.Error(ex, "An error occurred while processing your request");
                }
            }
        }

        private static void RunFizzBuzz()
        {
            Console.Write("Enter start number: ");
            int start = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter end number: ");
            int end = Convert.ToInt32(Console.ReadLine());

            FizzBuzzService fizzBuzz = new FizzBuzzService();
            string output = fizzBuzz.Execute(start, end);
            Console.WriteLine(output);
        }

        private static void DisplayInstructions()
        {
            Console.WriteLine("\nFizzBuzz Instructions:");
            Console.WriteLine("- Enter a range of numbers (start and end).");
            Console.WriteLine("- For multiples of 3, 'Fizz' will be printed.");
            Console.WriteLine("- For multiples of 5, 'Buzz' will be printed.");
            Console.WriteLine("- For multiples of both 3 and 5, 'FizzBuzz' will be printed.");
        }
    }
}


