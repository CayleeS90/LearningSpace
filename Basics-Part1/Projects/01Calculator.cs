////using statements for namespaces that allow me to access class, types ect ... 
//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace CSharpTutorial
//{
//    public class Calculator
//    {
//        //creating methods for the operations. Add is the method name. "decimal" is setting the type of parameter for num1 and num2.
//        public static decimal Add(decimal num1, decimal num2)
//        {
//            return num1 + num2;
//        }

//        public static decimal Subtract(decimal num1, decimal num2)
//        {
//            return num1 - num2;
//        }

//        public static decimal Multiply(decimal num1, decimal num2)
//        {
//            return num1 * num2;
//        }

//        public static decimal Divide(decimal num1, decimal num2)
//        {
//            return num1 / num2;
//        }
//        static void Main()
//        {
//            //Will output text asking for first number to be entered into the calculator
//            Console.WriteLine("Enter your first number");
//            //Asking for input from user, this is input will be a string
//            string input1 = Console.ReadLine();
//            //String input1 will be converted to a decimal
//            decimal firstNum = decimal.Parse(input1);
//            //Same as above. Asks for string input and will convert it to a decimal equivalent 
//            Console.WriteLine("Enter your second number");
//            string input2 = Console.ReadLine();
//            decimal secondNum = decimal.Parse(input2);
//            //Prompt will ask for operator
//            Console.WriteLine("Enter your operation: +, -, *, or /");
//            //operator is input as a string
//            string operation = Console.ReadLine();

//            //?
//            decimal result = 0;

//            //referring to the Calculator class an is initializing a new variable calc. calc will now call a Calculator method?
//            //Calculator calc = new Calculator();

//            //Switch statement: this will check the string input (operation)
//            //and use the appropriate operation method to calculate the first number and second number
//            switch (operation)
//            {
//                case "+":
//                    result = Add(firstNum, secondNum);
//                    break;
//                case "-":
//                    result = Subtract(firstNum, secondNum);
//                    break;
//                case "*":
//                    result = Multiply(firstNum, secondNum);
//                    break;
//                case "/":
//                    result = Divide(firstNum, secondNum);
//                    break;
//                //this is the default output if you enter a character that is not an operator
//                default:
//                    Console.WriteLine("Sorry this wasn't a correct choice.");
//                    break;
//            }
//            //Will take the values in the variables and use string interpolation to output results as a string of text. 
//            Console.WriteLine($"The solution {firstNum} {operation} {secondNum} = {result}");
//            Console.Read();
//        }
//    }
//}