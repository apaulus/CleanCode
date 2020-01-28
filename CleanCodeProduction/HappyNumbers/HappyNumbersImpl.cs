using System.Collections.Generic;
using System.Linq;

namespace CleanCodeProduction.HappyNumbers
{
    public class HappyNumbersImpl
    {
        public bool IsHappy(int number)
        {
            return IsHappyRecursive(new List<int> { number });
        }

        private bool IsHappyRecursive(ICollection<int> numbersSeen)
        {
            var happyness = CalculateHappynessValue(numbersSeen.Last());
            
            if (numbersSeen.Contains(happyness))
                return false;

            if (happyness == 1)
                return true;
            
            numbersSeen.Add(happyness);

            return IsHappyRecursive(numbersSeen);
        }

        private int CalculateHappynessValue(in int number)
        {
            return number
                .ToString()
                .ToCharArray()
                .Select(c => int.Parse(c.ToString()))
                .Select(i => i * i)
                .Sum();
        }
    }
}