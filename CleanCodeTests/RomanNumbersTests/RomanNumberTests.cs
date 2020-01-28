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
        
        [Theory]
        [InlineData(new[] { 1, 2 }, 3)]
        public void SumProblem(int[] numbers, int value)
        {
            Assert.Equal(value, RomanNumbersImpl.Sum(numbers));
        }
        
        [Theory]
        [InlineData(new[] { 1, 5 }, new[] { -1, 5})]
        [InlineData(new[] { 10, 100 }, new[] { -10, 100})]
        public void NegateProblem(int[] numbers, int[] outNumbers)
        {
            Assert.Equal(outNumbers, RomanNumbersImpl.Negate(numbers));
        }
        
        [Theory]
        [InlineData("MDCLXVI", new[] { 1000, 500, 100, 50, 10, 5, 1})]
        public void MapProblem(string romanString, int[] outNumbers)
        {
            Assert.Equal(outNumbers, RomanNumbersImpl.Map(romanString));
        }
    }
}