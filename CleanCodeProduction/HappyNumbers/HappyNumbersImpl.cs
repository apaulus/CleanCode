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
            var happiness = CalculateHappinessValue(numbersSeen.Last());
            
            if (numbersSeen.Contains(happiness))
                return false;

            if (happiness == 1)
                return true;
            
            numbersSeen.Add(happiness);

            return IsHappyRecursive(numbersSeen);
        }

        private int CalculateHappinessValue(in int number)
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