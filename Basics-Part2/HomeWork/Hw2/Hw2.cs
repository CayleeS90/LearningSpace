using System;
using System.Collections.Generic;
using System.Text;

namespace LearningSpace.Basics_Part2.HomeWork.Hw2
{
    /// <summary>
    /// Classes practice
    /// </summary>
    class Hw2
    {
        // -----------------------------------------------------------
        // Re-create the Part 1: Calculator project (02b) into a Calculator with classes
        // -----------------------------------------------------------
        public class Run
        {
            // Put all Console.ReadLine and Console.WriteLine methods in the Run Class
            // Make sure your Run class can access the Calculator class methods
            public void Main()
            {
                Console.WriteLine("Calculator is on. Enter your first number");
                var firstNum = double.Parse(Console.ReadLine());

                Console.WriteLine("Enter your second number");
                var secondNum = double.Parse(Console.ReadLine());

                Console.WriteLine("Enter your operation: +, -, *, or /");
                var operation = Console.ReadLine();

                Calculator calc = new Calculator(firstNum, secondNum);

                double result = 0; 
                switch (operation)
                {
                    case "+":
                        result = calc.Add(firstNum, secondNum);
                        break;
                    case "-":
                        result = calc.Subtract(firstNum, secondNum);
                        break;
                    case "*":
                        result = calc.Multiply(firstNum, secondNum);
                        break;
                    case "/":
                        result = calc.Divide(firstNum, secondNum);
                        break;
                    default:
                        Console.WriteLine("Sorry that wasn't a valid choice.");
                        break;
                }

                Console.WriteLine($"The solution {firstNum} {operation} {secondNum} = {result}");
            }
        }
    }
}
