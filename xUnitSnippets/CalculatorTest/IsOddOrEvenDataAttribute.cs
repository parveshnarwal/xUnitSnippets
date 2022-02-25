using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Xunit.Sdk;

namespace CalculatorTest
{
    class IsOddOrEvenDataAttribute : DataAttribute
    {
        public override IEnumerable<object[]> GetData(MethodInfo testMethod)
        {
                yield return new object[] { 1, true };
                yield return new object[] { 200, false };
                yield return new object[] { 19, true };
                yield return new object[] { 3, true };
                yield return new object[] { 4, false };
                yield return new object[] { 1233, true };
        }
    }
}
