using System;

namespace SimpleCalculator
{
    public class Program
    {
        static void Main(string[] args)
        {
            var runAnotherCalculation = true;

            Console.WriteLine("Welcome to NumbersCalculator!");
            Console.WriteLine();

            while (runAnotherCalculation)
            {
                ExecuteCalculation();
                runAnotherCalculation = RunAnother();
            }
        }

        public static bool RunAnother()
        {
            Console.WriteLine("Type 'c' or 'C' if you want to run another calculation, or any other key to exit the program:");
            var continueUserInput = Console.ReadLine();
            return continueUserInput.ToLower().Equals(UserPreferences.RunAnotherCalculation);
        }

        public static void ExecuteCalculation()
        {
            Console.WriteLine("Please provide the 1st number to sum:");
            var number1 = Parser.ParseFrom(Console.ReadLine());

            Console.WriteLine("Please provide the 2nd number to sum:");
            var number2 = Parser.ParseFrom(Console.ReadLine());

            Console.WriteLine($"Sum is: {number1 + number2}");

            Console.WriteLine();
        }
    }
}
