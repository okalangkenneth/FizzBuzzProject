using Serilog;
using System.Text;

namespace FizzBuzzProject
{
    public class FizzBuzzService
    {
        /// <summary>
        /// Executes the FizzBuzz logic for a specified range.
        /// </summary>
        /// <param name="start">The start of the range.</param>
        /// <param name="end">The end of the range.</param>
        /// <returns>A string with the FizzBuzz results.</returns>
        public async Task<string> ExecuteAsync(int start, int end)
        {

            Log.Debug($"Executing FizzBuzz from {start} to {end}");

            StringBuilder result = new StringBuilder();
            for (int i = start; i <= end; i++)
            {
                // Simulate an asynchronous operation
                await Task.Delay(10); // Delay for 10 milliseconds

                bool fizz = i % 3 == 0;
                bool buzz = i % 5 == 0;

                if (fizz) result.Append("Fizz");
                if (buzz) result.Append("Buzz");
                if (!fizz && !buzz) result.Append(i);

                result.AppendLine();
            }

            Log.Information("Completed executing FizzBuzz");
            return result.ToString();
        }
    }
}

