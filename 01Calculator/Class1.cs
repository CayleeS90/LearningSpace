using System;
using System.Collections.Generic;
using System.Text;

namespace LearningSpace._01Calculator
{
    public class Calculator
    {
        public static decimal Add(decimal firstNum, decimal secondNum)
        {
            return firstNum + secondNum;
        }
        public static decimal Sub(decimal firstNum, decimal secondNum)
        {
            return firstNum - secondNum;
        }
        public static decimal Multiply(decimal firstNum, decimal secondNum)
        {
            return firstNum * secondNum;
        }
        public static decimal Divide(decimal firstNum, decimal secondNum)
        {
            return firstNum / secondNum;
        }
        //static void Main()
        //{
        //    Console.WriteLine("Please choose your first number");
        //    string input1 = Console.ReadLine();
        //    decimal firstNum = decimal.Parse(input1);

        //    Console.WriteLine("Please choose your second number");
        //    string input2 = Console.ReadLine();
        //    decimal secondNum = decimal.Parse(input2);

        //    Console.WriteLine("Please choose your operation");
        //    string operation = Console.ReadLine();

        //    decimal result = 0;

        //    //set string inputs to operations
        //    switch (operation)
        //    {
        //        case "+":
        //            result = Add(firstNum, secondNum);
        //            break;
        //        case "-":
        //            result = Sub(firstNum, secondNum);
        //            break;
        //        case "*":
        //            result = Multiply(firstNum, secondNum);
        //            break;
        //        case "/":
        //            result = Divide(firstNum, secondNum);
        //            break;
        //        default:
        //            Console.WriteLine("This is not a valid choice");
        //            break;
        //    }
        //    //make output message giving the 2 numbers in the solution and the result
        //    Console.WriteLine($"The solution {firstNum}{operation}{secondNum} = {result}");
        //}
    }
}
