using Calculator;
using Moq;
using Xunit;

namespace CalculatorTest
{
    delegate void MockMethodWithRefInput(int result, ref int value);

    public class MoqTestsWithRefParameters
    {
        private readonly Mock<IMathDatabaseService> _MockMathDatabaseService;

        public MoqTestsWithRefParameters()
        {
            //Mocking database service class behaviour 

            _MockMathDatabaseService = new Mock<IMathDatabaseService>();
        }


        [Fact]
        public void TestingSampleMethodWithRefInput()
        {
            CalcWithDb calcWithDb = new CalcWithDb(_MockMathDatabaseService.Object);

            int valueInt = 10;


            //Mocking ref parameter value using delegate
            _MockMathDatabaseService.Setup(x => x.SampleMethodWithRefInput(It.IsAny<int>(), ref valueInt))
                .Callback(new MockMethodWithRefInput((int result, ref int value) => value = 50))
                .Returns(1);

            var result = calcWithDb.CallingSampleMethodWithRefInput(10, 15);

            Assert.Equal(1, result);

        }


        [Fact]
        public void TestingSampleMethodWithRefInputMoqWithLatestVersion()
        {
            CalcWithDb calcWithDb = new CalcWithDb(_MockMathDatabaseService.Object);

            int valueInt = 0;


            //Mocking ref parameter value using delegate (also using It.Ref)
            _MockMathDatabaseService.Setup(x => x.SampleMethodWithRefInput(It.IsAny<int>(), ref It.Ref<int>.IsAny))
                .Callback(new MockMethodWithRefInput((int result, ref int value) => value = 50))
                .Returns(1);

            var result = calcWithDb.CallingSampleMethodWithRefInput(10, 15);

            Assert.Equal(1, result);

        }

        [Fact]
        public void TestingMethodWithMoqWithOutParameter()
        {
            CalcWithDb calcWithDb = new CalcWithDb(_MockMathDatabaseService.Object);

            int value = 12;

            _MockMathDatabaseService.Setup(x => x.MethodWithOutParameter(It.IsAny<int>(), out value));

            var result = calcWithDb.CallingMethodWithOutParameter(10);

            Assert.Equal(12, result);
        }

    }
}
