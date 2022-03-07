namespace Calculator
{
    public interface IMathDatabaseService
    {
        public int StoreResultInDb(int result);
        public int SampleMethodWithRefInput(int result, ref int value);
        public void MethodWithOutParameter(int result, out int value);
    }

    public class MathDatabaseService : IMathDatabaseService
    {
        public int StoreResultInDb(int result)
        {
            //code to store data in database goes here

            return 1;
        }

        public int SampleMethodWithRefInput(int result, ref int value)
        {
            value = 2 * result;

            return 5;

        }

        public void MethodWithOutParameter(int result, out int value)
        {
            value = result + 2;
        }
    }
}
