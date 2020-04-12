using System;
using System.Collections.Generic;
using System.Text;

namespace LearningSpace
{
    /// <summary>
    /// Syntax refactoring practice
    /// Make sure you complete the Hw4-PreReading.cs file first!
    /// </summary>
    class Hw1
    {
        // -----------------------------------------------------------
        // Create a class called Car with properties
        // -----------------------------------------------------------
        public class Car
        {
            // Add properties: MaxSpeed, Model, Make, Year, MaxGas, CurrentGas
            // Add property GasTankIsEmpty which is false if Gas > 1
            public int MaxSpeed { get; set; }
            //public string Model { get; set; }
            public Make Make{ get; set; }
            public int Year { get; set; }
            public double MaxGas { get; set; }
            public int CurrentGas { get; set; }
            public bool GasTankIsEmpty => CurrentGas < 1;

            // Add a method called Drive() 
            public void Drive()
            {

            }
            // Add a method AddGas() to the Car. It should take in a parameter for gallons and edit the CurrentGas property
            public void AddGas(int gallons)
            {
                CurrentGas += gallons;
            }
            // Add a method called GetGasLevelPercent(), it should return the current gas / max gas
            public double GetGasLevelPercent()
            {
               var gasPercentage = CurrentGas * 100 / MaxGas;

               return gasPercentage;
            }

            // Add a method called GetSummary() will print out all of the properties of this car
            public void GetSummary()
            {
                Console.WriteLine($" Make: {Make.Name} ({Make.Description}) \n Model: {Make.Model.Name} ({Make.Model.Description})\n Year: {Year} \n" +
                $" Max Speed: {MaxSpeed} mph \n Fuel tank capacity: {MaxGas} gallons");

                string result = (GasTankIsEmpty) ? " Gas tank is empty!" : $" Contains {CurrentGas} gallons of fuel \n";
                Console.WriteLine(result);
                Console.WriteLine(" ");
            }
        }
        // -----------------------------------------------------------
        // Create a class called Model.
        // It should have properties Name, Description
        // -----------------------------------------------------------
        public class Model
        {
            public string Name { get; set; }
            public string Description { get; set; }
            
        }

        // -----------------------------------------------------------
        // Create a class called Make.
        // It should have properties Name, Description, and Model
        // Create a constructor that requires a Model as a parameter, and assigns the model passed in to the Model property
        // -----------------------------------------------------------
        public class Make
        {
            public string Name { get; set; }
            public string Description { get; set; }
            public Model Model { get; set; }
            public Make(Model model) 
            {
                Model = model;
            }
        }


        // In the Car class, replace the string Make with the type Make. Remove the property Model

        // -----------------------------------------------------------
        // Create a class called Cat with 4 properties of cats and 2 methods of actions cats do
        // -----------------------------------------------------------
        public class Cat
        {
            public string Name { get; set; }
            public string Color { get; set; }
            public string Size { get; set; }
            public string HairLength { get; set; }

            public void Eat()
            {
               
            }
            public void Poop()
            {
              
            }
        }

        public void Run()
        {
            // Create a Model called Civic
            Model Civic = new Model
            {
                Name = "Civic",
                Description = "Coupe"
            };
            // Create a Model called ES330
            Model ES3330 = new Model()
            {
                Name = "ES3330",
                Description = "Sedan"
            };
            // Create a Make called Honda and pass in the Model Civic
            Make Honda = new Make(Civic)
            {
                Name = "Honda",
                Description = "Import"
            };
            // Create a Make called Lexus and pass in the Model ES3330
            Make Lexus = new Make(ES3330)
            {
                Name = "Lexus",
                Description = "Import"
            };
            // Create an object honda1 that is a Car and assign values to all of its properties, make sure to assign it the right Model
            // Call the GetSummary() method on honda1
            Car honda1 = new Car
            {
                MaxSpeed = 130,
                Make = Honda,
                Year = 2014,
                MaxGas = 13.2,
                CurrentGas = 0
            };
            honda1.GetSummary();
            // Create an object honda2 that is a Car and assign values to all of its properties, make sure to assign it the right Model
            // Call the GetSummary() method on honda2
            Car honda2 = new Car
            {
                MaxSpeed = 124,
                Make = Honda,
                Year = 2012,
                MaxGas = 13.2,
                CurrentGas = 12
            };
            honda2.GetSummary();
            // Create an object lexus1 that is a Car and assign values to all of its properties, make sure to assign it the right Model
            // Call the GetSummary() method on lexus1
            Car lexus1 = new Car
            {
                MaxSpeed = 112,
                Make = Lexus,
                Year = 2010,
                MaxGas = 18.5,
                CurrentGas = 4
            };
            lexus1.GetSummary();

        }
       
    }
}
