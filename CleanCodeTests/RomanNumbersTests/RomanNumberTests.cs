using CleanCodeProduction.RomanNumbers;
using Xunit;

namespace CleanCodeTests.RomanNumbersTests
{
    public class RomanNumbersTests
    {
        [Theory]
        [InlineData("MCMLXXXIV", 1984)]
        [InlineData("MCDXCII", 1492)]
        public void AcceptanceCriteria(string roman, int number)
        {
            Assert.Equal(number, RomanNumbersImpl.RomanNumberToInt(roman));
        }
    }
}