using System;

namespace SimpleCalculator
{
    public static class Parser
    {
        public static int ParseFrom(string input)
        {
            var result = int.TryParse(input, out int number);

            while (!result)
            {
                Console.WriteLine($"Input '{input}' is not valid. Please try again:");
                input = Console.ReadLine();
                result = int.TryParse(input, out number);
            }

            return number;
        }
    }
}
