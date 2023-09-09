using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{


    /* 
* Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle [done]
* Add a distinct property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle [done]
* Provide the implementations for the abstract methods [done]
* Only in the Motorcycle class will you override the virtual drive method [done]
*/


    internal class Motorcycle : Vehicle
    {
        //Properties
        public int EngineCC { get; set; }
        public bool KickStart { get; set; }

        public override void DriveAbstract()
        {
            Console.WriteLine("I'm a \"Motorcycle\" implementation using OVERRIDE of the \"abstract\"");
            Console.WriteLine("stubbed-out method \"DriveAbstract\" in the VEHICLE abstract class");
            Console.WriteLine("-------------------");
        }
        public override void DriveVirtual()
        {
            //"base" keyword used to explicity call a method from a "base" class"
            //in this case the base class is Vehicle.DriveVirtual()"
            base.DriveVirtual();   
        }

    }
}
