using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public interface IMathDatabaseService
    {
        public int StoreResultInDb(int result);
    }

    public class MathDatabaseService : IMathDatabaseService
    {
        public int StoreResultInDb(int result)
        {
            //code to store data in database goes here

            return 1;
        }
    }
}
