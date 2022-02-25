using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorTest
{
    public static class TestDataShare
    {
        public static IEnumerable<object[]> IsOddOrEvenData
        {
            get
            {
                yield return new object[] { 1, true };
                yield return new object[] { 200, false };
                yield return new object[] { 19, true };
                yield return new object[] { 3, true };

            }
        }

        public static IEnumerable<object[]> IsOddOrEvenDataFromExternalFile
        {
            get
            {
                var allLines = System.IO.File.ReadAllLines("IsOddEvenTestDataFile.txt");
                return allLines.Select(x =>
                {
                    var lineSplit = x.Split(',');
                    return new object[] { int.Parse(lineSplit[0]), bool.Parse(lineSplit[1])};
                });
            }
        }
    }
}
