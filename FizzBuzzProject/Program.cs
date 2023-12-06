using System;

namespace FizzBuzzProject
{
    class Program
    {
        static void Main(string[] args)
        {
            // Loop from 1 to 100
            for (int i = 1; i <= 100; i++)
            {
                // If the number is divisible by 3 and 5, print FizzBuzz
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                // If the number is divisible by 3, print Fizz
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                // If the number is divisible by 5, print Buzz
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }

            Console.ReadLine();
        }
    }
}

