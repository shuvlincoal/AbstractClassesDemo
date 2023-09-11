using System;
using System.Collections.Generic;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> transportationList = new List<Vehicle>();

            Car car1 = new Car() { Make = "Ferrari", Model = "Fire", Year = 1960 };
            Motorcycle cycle1 = new Motorcycle() { Make = "Volkswagen", Model = "Beetle", Year = 1955 };
            Vehicle vehicle1 = new Car() { Make = "Ford", Model = "Cobra", Year = 1960,  Transmission = "Manual", RoofRack = false };
            Vehicle vehicle2 = new Motorcycle() { EngineCC = 900, KickStart = true };

            transportationList.Add(car1);
            transportationList.Add(cycle1);
            transportationList.Add(vehicle1);
            transportationList.Add(vehicle2);

            /*Using a foreach loop iterate over each of the properties [done]
 */
            foreach (Vehicle transPort in transportationList)
            {
                Console.WriteLine($"Specs: {transPort.Year}");
                Console.WriteLine($"Specs: {transPort.Make}");
                Console.WriteLine($"Specs: {transPort.Model}");
                transPort.DriveVirtual();
                transPort.DriveAbstract();
                Console.WriteLine("--Press Return To See More-----------------");
                Console.ReadLine();
            }
            Console.WriteLine($"Thanks for visiting our Car lot, press return to exit> ");
            Console.WriteLine("-------------------\n\n\n");
            Console.ReadLine();

            #region Vehicles Lab Instructions

            /*
             * Create an abstract class called Vehicle
             * The vehicle class shall have three string properties Year, Make, and Model
             * Set the defaults to something generic in the Vehicle class
             * Vehicle shall have an abstract method called DriveAbstract with no implementation
             * Vehicle shall have a virtual method called DriveVirtual with a base implementation.
             */

            /* 
             * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
             * Add a distinct property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
             * Provide the implementations for the abstract methods
             * Only in the Motorcycle class will you override the virtual drive method
            */

            // Create a list of Vehicle called transportationList

            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * 
             * Set the properties with object initializer syntax
             */

            /*
             * Add the 4 transportationList to the list
             * Using a foreach loop iterate over each of the properties
             */

            // Call each of the drive methods for one car and one motorcycle

            #endregion

        }
    }
}
