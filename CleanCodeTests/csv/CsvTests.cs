using System.Collections.Generic;
using System.Linq;
using CleanCodeProduction.csv;
using Xunit;

namespace CleanCodeTests.csv
{
    public class CsvTests
    {
        [Fact]
        public void SingleLineSingleItem()
        {
            // given
            var lines = new List<List<string>>
            {
                new List<string> {"l2"}
            };

            var expectedColumSizes = new List<int> {2};
            
            // when
            var columSizes = Csv.GetColumnSizes(lines);

            // then
            Assert.Equal(expectedColumSizes, columSizes);
        }
        
        [Fact]
        public void SingleLineMultipleItems()
        {
            // given
            var lines = new List<List<string>>
            {
                new List<string> {"l2", "ll2"}
            };

            var expectedColumSizes = new List<int> {2, 3};
            
            // when
            var columSizes = Csv.GetColumnSizes(lines);

            // then
            Assert.Equal(expectedColumSizes, columSizes);
        }
        
        [Fact]
        public void MultipleLinesSingleItem()
        {
            // given
            var lines = new List<List<string>>
            {
                new List<string> {"lll4"},
                new List<string> {"llll5"}
            };

            var expectedColumSizes = new List<int> {5};
            
            // when
            var columSizes = Csv.GetColumnSizes(lines);

            // then
            Assert.Equal(expectedColumSizes, columSizes);
        }
        
        [Fact]
        public void MultipleLinesMultipleItems()
        {
            // given
            var lines = new List<List<string>>
            {
                new List<string> {"lllll6", "ll3"},
                new List<string> {"abc", "lll4"}
            };

            var expectedColumSizes = new List<int> {6, 4};
            
            // when
            var columSizes = Csv.GetColumnSizes(lines);

            // then
            Assert.Equal(expectedColumSizes, columSizes);
        }
        
        
        #region lookup things
        // [Theory]
        // [InlineData(19, true)]
        // [InlineData(4, false)]
        // [InlineData(111, false)]
        // [InlineData(440, true)]
        // public void TestCases(int number, bool expectedHappyness)
        // {
        //     var isHappy = Csv.GetColumSizes(number);
        //     Assert.Equal(isHappy, expectedHappyness);
        // }
        #endregion
    }
}