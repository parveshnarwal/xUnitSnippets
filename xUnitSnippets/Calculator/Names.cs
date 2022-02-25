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
