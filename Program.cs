using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstParam = 12;
            int secondParam = 3;

            // MathCalculator Object 
            MathCalculator calculator = new MathCalculator();

            int addOperation = calculator.Add(firstParam, secondParam);
            // Writing Addition to Console
            Console.WriteLine($"Adding {firstParam} and {secondParam} results in: {addOperation}");

            int subtractOperation = calculator.Subtract(firstParam, secondParam);
            // Writing Subtraction to Console
            Console.WriteLine($"Subtracting {secondParam} from {firstParam} results in: {subtractOperation}");

            int multiplyOperation = calculator.Multiply(firstParam, secondParam);
            Console.WriteLine($"Multiplying {firstParam} and {secondParam} results in: {multiplyOperation}");

            int divideOperation = calculator.Divide(firstParam, secondParam);
            Console.WriteLine($"Divide {firstParam} by {secondParam} results in: {divideOperation}");
        }
    }
}
