using CleanCodeProduction.HappyNumbers;
using Xunit;

namespace CleanCodeTests.HappyNumbers
{
    public class HappyNumbersTests
    {
        [Theory]
        [InlineData(19, true)]
        [InlineData(4, false)]
        [InlineData(111, false)]
        [InlineData(440, true)]
        public void TestCases(int number, bool expectedHappyness)
        {
            var isHappy = new HappyNumbersImpl().IsHappy(number);
            Assert.Equal(isHappy, expectedHappyness);
        }
    }
}