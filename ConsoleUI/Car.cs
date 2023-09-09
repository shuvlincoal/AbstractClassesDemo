using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    /* 
 * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle [done]
 * Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle [done]
 * Provide the implementations for the abstract methods [done]
 * Only in the Motorcycle class will you override the virtual drive method [done]
 */

    internal class Car : Vehicle
    {

        //Fields

        //Properties
        public string Transmission { get; set; }
        public bool RoofRack { get; set; }

        public override void DriveAbstract()
        {
            Console.WriteLine("I'm a \"Car\" implementation using OVERRIDE of the \"abstract\"");
            Console.WriteLine("stubbed-out method \"DriveAbstract\" in the VEHICLE abstract class");
            Console.WriteLine("-------------------");
        }



    }
}
