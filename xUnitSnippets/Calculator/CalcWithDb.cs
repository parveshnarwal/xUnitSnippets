using System;

namespace Calculator
{
    public class CalcWithDb
    {
        private readonly IMathDatabaseService _mathDatabaseService;

        public CalcWithDb(IMathDatabaseService mathDatabaseService)
        {
            _mathDatabaseService = mathDatabaseService;
        }

        public int AddNumberAndStore(int a, int b)
        {
            int result = a + b;

            try
            {
                int dbResult = _mathDatabaseService.StoreResultInDb(result);

                if (dbResult == 1)
                {
                    return result;
                }

                else
                {
                    return -99;
                }
            }
            catch
            {
                throw new Exception("Failed to store in DB");
            }

            

        }

        public int CallingSampleMethodWithRefInput(int a, int b)
        {
            int result = a + b;

            int value = 10;

            _mathDatabaseService.SampleMethodWithRefInput(result, ref value);

            if(value == 2 * result)
            {
                return 1;
            }

            else
            {
                return -99;
            }
        }

        public int CallingMethodWithOutParameter(int a)
        {
            int result;

            _mathDatabaseService.MethodWithOutParameter(a, out result);

            return result;

        }
    }
}
