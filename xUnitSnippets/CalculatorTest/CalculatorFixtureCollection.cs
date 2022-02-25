using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CalculatorTest
{
    [CollectionDefinition("Calculator")]
    public class CalculatorFixtureCollection : ICollectionFixture<CalculatorFixture>
    {

    }
}
