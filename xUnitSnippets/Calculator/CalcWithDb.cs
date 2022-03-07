using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
