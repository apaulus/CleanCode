using System;
using CleanCodeProduction.HappyNumbers;

namespace CleanCodeProduction.RomanNumbers
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter the number to check");
            var numberString = Console.ReadLine() ?? string.Empty;

            var number = int.Parse(numberString);

            var happy = new HappyNumbersImpl().IsHappy(number);

            Console.WriteLine($"Happy? {happy}");

            Console.ReadLine();
        }
    }
}