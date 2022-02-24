using System;

namespace SpecFlowCalculator
{
    public class Calculator
    {
        public int FirstNumber { get; set; }
        public int SecondNumber { get; set; }

        public int Add()
        {
            return FirstNumber + SecondNumber;
        }

        public int Subtract()
        {
            return FirstNumber - SecondNumber;
        }

        public int Multiply()
        {
            return FirstNumber * SecondNumber;
        }

        public int Divide()
        {
            return FirstNumber / SecondNumber;
        }

        public int Operator(string p0, int p1)
        {
            switch (p0)
            {
                case "+":
                    return FirstNumber += p1;
                case "-":
                    return FirstNumber -= p1;
                case "*":
                    return FirstNumber *= p1;
                case "/":
                    return FirstNumber /= p1;
                case "%":
                    return FirstNumber %= p1;
                default:
                    return FirstNumber;

            }
        }
    }
}