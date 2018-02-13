using System;

namespace Calculator 
{
    public class MathCalculator 
    {
        public static int Add(int param1, int param2) 
        {
            return param1 + param2;
        }

        public static int Subtract(int param1, int param2) 
        {
            return param1 - param2;
        }

        public static int Multiply(int param1, int param2) 
        {
            return param1 * param2;
        }

        public static int Divide(int numerator, int denominator) 
        {
            if (denominator == 0) throw new InvalidOperationException("Cannot Divide by O");
            return numerator / denominator;
        }
    }
}