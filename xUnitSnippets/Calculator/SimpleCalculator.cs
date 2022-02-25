namespace Calculator
{
    public class SimpleCalculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Subtract(int a, int b)
        {
            return a - b;
        }

        public int Multiply(int a, int b)
        {
            return a * b;
        }

        public int Divide(int a, int b)
        {
            return a / b;
        }

        public bool IsEven(int a)
        {
            return a % 2 == 0;
        }


        public bool IsOdd(int a)
        {
            return a % 2 != 0;
        }
    }
}
