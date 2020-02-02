using System;
using System.Collections.Generic;
using System.Text;

namespace LearningSpace.Practice
{
    class Class1
    {
        // Write a method that doesn't return anything, takes in no paramters and is called Cat. Have it print with console writeline "Hello Cat!"
        public static void Cat()
        {
            Console.WriteLine("Hello Cat!");
        }

        // Write a method that returns an int and takes in no parameters and is called Dog. Return the value 1.
        public static int Dog()
        {
            return 1;
        }

        // Write a method that returns an int, takes in int one parameter, and simply returns the parameter and is called Test.
        public static int Test(int number)
        {
            return number;
        }
        // Write me a method that takes in 2 parameters that are numbers and returns the added value
        static decimal Add(decimal num1, decimal num2)
        {
            return num1 + num2;
        }
        // Write me a method called PersonName that takes in 2 string parameters: first and last name and returns the string full name.
        public static string PersonName(string firstName, string lastName)
        {
            return firstName + " " + lastName;
        }
        // Write a method that returns a boolean, takes in 1 parameter that is an int, and checks to see if the value of the int is 10
        public static bool IsTen(int num3)
        {
            if (num3 == 10)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // Write a method that creates an new character array with the letters a-e
        // Write a method that returns a boolean, and loop over your new character array with a foreach loop.
        // and break out of the foreach loop when you hit the letter c
        public static bool CharArray()
        {
            char[] arr3 = new char[5] { 'a', 'b', 'c', 'd', 'e' };
            foreach (var item in arr3)
            {
                if (item < arr3[2])
                {
                    Console.WriteLine($"{item}");
                }
                else
                {
                    break;
                }
            }
            return true;
        }
        public static void Main()
        {
            // TEST Write me a method that takes in 2 parameters that are numbers and returns the added value
            decimal num1 = 2;
            decimal num2 = 6;
            decimal result = Add(num1, num2);
            Console.WriteLine($"The sum is {result}");

            // TEST Write me a method called PersonName that takes in 2 string parameters: first and last name and returns the string full name.
            string firstName = "Caylee";
            string lastName = "Stewart";
            Console.WriteLine(PersonName(firstName, lastName));

            // TEST Write a method that returns a boolean, takes in 1 parameter that is an int, and checks to see if the value of the int is 10
            Console.WriteLine(IsTen(10));

            //TEST Write a method with a while loop that continues until count = 10.  Increment count by 1 in the loop. 
            int num = 0;
            while (num < 10)
            {
                Console.WriteLine(num += 1);
            }
            // TEST Write a method that returns a boolean, and loop over your new character array with a foreach loop.
            CharArray();


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
        }
    }
}
