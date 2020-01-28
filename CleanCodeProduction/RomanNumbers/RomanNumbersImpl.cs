using System.Collections.Generic;
using System.Linq;

namespace CleanCodeProduction.RomanNumbers
{
    public static class RomanNumbersImpl
    {
        public static int RomanNumberToInt(string roman)
        {
            return Sum(Negate(Map(roman)));
        }

        public static int Sum(IEnumerable<int> numbers)
        {
            return numbers.Sum();
        }

        public static int[] Negate(int[] numbers)
        {
            for (var i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] < numbers[i + 1])
                {
                    numbers[i] = -numbers[i];
                }
            }

            return numbers;
        }
        
        
        public static int[] Map(string romanString)
        {
            var mapping = new Dictionary<char, int>
            {
                { 'M', 1000 },
                { 'D', 500 },
                { 'C', 100 },
                { 'L', 50 },
                { 'X', 10 },
                { 'V', 5 },
                { 'I', 1 }
            };

            return romanString
                .Select(c => mapping[c])
                .ToArray();
        }
    }
}