using System;

namespace Open_Lab_02._03
{
    public class Calculator
    {
        public int Remainder(int dividend, int divisor)
        {
            int quotient = dividend / divisor;
            int remainder = dividend % divisor;
            return remainder;
        }
    }
}
