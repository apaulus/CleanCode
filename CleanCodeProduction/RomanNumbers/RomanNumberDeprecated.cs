using System.Collections.Generic;
using System.Linq;

namespace CleanCodeProduction.RomanNumbersFun
{
    public class RomanNumber
    {
        private readonly string _wholeRomanNumber;

        public RomanNumber(string wholeRomanNumber)
        {
            _wholeRomanNumber = wholeRomanNumber;
        }

        public int ToInt()
        {
            var parts = _wholeRomanNumber.ToCharArray().ToList();
            var neighbors = new Dictionary<char, NeighborData>
            {
                {'V', new NeighborData('I', 1, 5)}
            };

            var totalValue = 0;
            
            
            foreach (var digit in neighbors)
            {
                var digitIndex = parts.IndexOf(digit.Key);
                if (digitIndex == -1)
                    continue;

                var beforeAmount = 0;
                for (var before = digitIndex - 1; before >= 0; before--)
                {
                    if (parts[before] == digit.Value.Neighbor)
                        beforeAmount += digit.Value.NeighborValue;
                }
            
                var afterAmount = 0;
                for (var after = digitIndex + 1; after < parts.Count; after++)
                {
                    if (parts[after] == digit.Value.Neighbor)
                        afterAmount += digit.Value.NeighborValue;
                }

                totalValue += digit.Value.Value;
                totalValue += afterAmount;
                totalValue -= beforeAmount;

            }

            return totalValue;
        }
    }
}

internal class NeighborData
{
    public NeighborData(char neighbor, int neighborValue, int value)
    {
        Neighbor = neighbor;
        NeighborValue = neighborValue;
        Value = value;
    }

    public char Neighbor { get; }
    public int NeighborValue { get; }
    public int Value { get; }
}