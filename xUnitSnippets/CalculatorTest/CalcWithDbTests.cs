using Calculator;
using Moq;
using System;
using Xunit;

namespace CalculatorTest
{
    public class CalcWithDbTests
    {
        private readonly Mock<IMathDatabaseService> _MockMathDatabaseService;

        public CalcWithDbTests()
        {
            //Mocking database service class behaviour 

            _MockMathDatabaseService = new Mock<IMathDatabaseService>();
        }

        [Fact]
        public void AddNumberAndStore_Returns_Result_WhenDatabaseCallSuccess()
        {
            CalcWithDb calcWithDb = new CalcWithDb(_MockMathDatabaseService.Object);

            _MockMathDatabaseService.Setup(x => x.StoreResultInDb(It.IsAny<int>())).Returns(1);

            var result = calcWithDb.AddNumberAndStore(5, 8);

            Assert.Equal(13, result);


        }

        [Fact]
        public void AddNumberAndStore_Returns_Result_WhenDatabaseThrowsException()
        {
            CalcWithDb calcWithDb = new CalcWithDb(_MockMathDatabaseService.Object);

            _MockMathDatabaseService.Setup(x => x.StoreResultInDb(It.IsAny<int>())).Throws(new Exception());

            var result = Assert.Throws<Exception>(() => calcWithDb.AddNumberAndStore(10, 34));

            Assert.Equal("Failed to store in DB", result.Message);

        }

        [Fact]
        public void AddNumberAndStore_Returns_Negative99_WhenDbGiverOtherThanOneAsOutput()
        {
            CalcWithDb calcWithDb = new CalcWithDb(_MockMathDatabaseService.Object);

            _MockMathDatabaseService.Setup(x => x.StoreResultInDb(It.IsAny<int>())).Returns(401);

            var result = calcWithDb.AddNumberAndStore(5, 8);

            Assert.Equal(-99, result);

        }
    }
}
