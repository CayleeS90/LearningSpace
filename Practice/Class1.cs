using System;
using System.Collections.Generic;
using System.Text;

namespace LearningSpace.Practice
{
    class Class1
    {
        static void Main()
        {
            // Write a method that doesn't return anything, takes in no paramters and is called Cat. Have it print with console writeline "Hello Cat!"
            void Cat()
            {
                Console.WriteLine("Hello Cat!");
            }

            // Write a method that returns an int and takes in no parameters and is called Dog. Return the value 1.
            int Dog()
            {
                return 1;
            }

            // Write a method that returns an int, takes in int one parameter, and simply returns the parameter and is called Test.
            int Test(int number)
            {
                return number;
            }

            // Write me a method that takes in 2 parameters that are numbers and returns the added value
            decimal num1 = 2;
            decimal num2 = 6;
            static decimal Add(decimal num1, decimal num2)
            {
                return num1 + num2;
            }
            decimal result = Add(num1, num2);
            Console.WriteLine($"The sum is {result}");

            // Given the following int array...
            int[] arr = new int[] { 6, 3, 4, 0, 9 };
            // what number is at index 2?
            // Answer: 4
            // what number is at index 4?
            // Answer:9
            // what number is at index 0?
            // Answer: 6

            // From the array above, write a variable that = first value of the array:
            int number = arr[0];
            Console.WriteLine(number);
            // From the array above, write a variable that = the last value of the array:
            int number2 = arr[4];
            Console.WriteLine(number2);

            // Write a string array that has 4 colors in it
            string[] arr2 = new string[] { "Navy", "Violet", "Scarlet", "Tan" };
            Array.ForEach(arr2, Console.WriteLine);
            // Write me a method called PersonName that takes in 2 string parameters: first and last name and returns the string full name.


            // Write a method that returns a boolean, takes in 1 parameter that is an int, and checks to see if the value of the int is 10


            // Write a method with a while loop that continues until count = 10.  Increment count by 1 in the loop. 


            // Write a method that creates an new character array with the letters a-e


            // Write a method that returns a boolean, and loop over your new character array with a foreach loop.
            // and break out of the foreach loop when you hit the letter c


        }
    }
}
