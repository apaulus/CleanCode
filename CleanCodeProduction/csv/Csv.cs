using System.Collections.Generic;
using System.Linq;

namespace CleanCodeProduction.csv
{
    public static class Csv
    {
        public static List<int> GetColumnSizes(List<List<string>> lines)
        {
            var columnSizes = new List<int>();
            for (var i = 0; i < lines.First().Count; i++)
            {
                var max = 0;
                for (var j = 0; j < lines.Count; j++)
                {
                    max = lines[j][i].Length > max ? lines[j][i].Length : max;
                }
                
                columnSizes.Add(max);
            }

            return columnSizes;
        }
    }
}