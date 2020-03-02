using System;
using System.Collections.Generic;
using System.Text;

namespace LearningSpace
{
    public class Calculator2
    {
        // operations need to be funtioning methods
        public decimal Add(decimal num1, decimal num2)
        {
            return num1 + num2;
        }
        public decimal Sub(decimal num1, decimal num2)
        {
            return num1 - num2;
        }
        public decimal Multiply(decimal num1, decimal num2)
        {
            return num1 * num2;
        }
        public decimal Divide(decimal num1, decimal num2)
        {
            return num1 / num2;
        }
        public void Run()
        {
            // must be able to enter in and read number input
            Console.WriteLine("Please choose your first number.");
            decimal num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Please choose your second number.");
            decimal num2 = int.Parse(Console.ReadLine());

            // must be able to choose and input an operation
            Console.WriteLine("Please choose an operation: +, -, * or /");
            string operation = Console.ReadLine();

            decimal result = 0;

            switch (operation)
            {
                case "+":
                    result = Add(num1, num2);
                    break;
                case "-":
                    result = Sub(num1, num2);
                    break;
                case "*":
                    result = Multiply(num1, num2);
                    break;
                case "/":
                    result = Divide(num1, num2);
                    break;
                default:
                    Console.WriteLine("This is not a valid operation.");
                    break;
            }
            // print sum
            Console.WriteLine($"the sum of {num1} {operation} {num2} = {result}");
        }
    }
}
