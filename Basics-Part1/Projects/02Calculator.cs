using System;
using System.Collections.Generic;
using System.Text;

namespace LearningSpace
{
    public class Calculator2
    {
        public static decimal Add(decimal num1, decimal num2)
        {
            return num1 + num2;
        }
        public static decimal Sub(decimal num1, decimal num2)
        {
            return num1 - num2;
        }
        public static decimal Multiply(decimal num1, decimal num2)
        {
            return num1 * num2;
        }
        public static decimal Divide(decimal num1, decimal num2)
        {
            return num1 / num2;
        }
        public void Run()
        {

            Console.WriteLine("Enter first number");
            string input1 = Console.ReadLine();
            decimal num1 = decimal.Parse(input1);

            Console.WriteLine("Enter second number");
            string input2 = Console.ReadLine();
            decimal num2 = decimal.Parse(input2);

            Console.WriteLine("Choose your operation: +, -, *, /");

            string operation = Console.ReadLine();

            decimal result = 0;
            switch (operation)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    result = num1 / num2;
                    break;
                default:
                    Console.WriteLine("This is not a valid choice");
                    break;
            }
            //output message with result
            Console.WriteLine($"The solution {num1} {operation} {num2} is {result}");
        }

    }
}
