using System;
using System.Collections.Generic;
using System.Text;

namespace LearningSpace.Basics_Part2.HomeWork.Hw2
{
    public class Calculator
    {
        // Move the Calculator class into a new file
        // Put all Calculator logic in the Calculator class
        public Calculator(double firstNum, double secondNum)
        {
            FirstNum = firstNum;
            SecondNum = secondNum; 
        }

        public double FirstNum { get; set; }
        public double SecondNum { get; set; }

        public double Add(double firstNum, double secondNum)
        {
            return firstNum + secondNum;
        }
        public double Subtract(double firstNum, double secondNum)
        {
            return firstNum - secondNum;
        }
        public double Multiply(double firstNum, double secondNum)
        {
            return firstNum * secondNum;
        }
        public double Divide(double firstNum, double secondNum)
        {
            return firstNum / secondNum;
        }
    }
}
