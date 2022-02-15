using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Names
    {
        public string NickName { get; set; }
        public string MakeFullName(string fname, string lname)
        {
            return $"{fname} {lname}";
        }
    }
}
