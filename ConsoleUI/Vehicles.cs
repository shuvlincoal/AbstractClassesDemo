using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    //internal class Vehicle
    //{
    //}

    /*
     * Create an abstract class called Vehicle  [done]
     * The vehicle class shall have three string properties Year, Make, and Model [done]
     * Set the defaults to something generic in the Vehicle class [done]
     * Vehicle shall have an abstract method called DriveAbstract with no implementation [done]
     * Vehicle shall have a virtual method called DriveVirtual with a base implementation. [done]
     */

    internal abstract class Vehicle //You CAN NOT instantiate an "abstract class
    //it provides a partial implementation of our base clas for our child class 
    //to inherit from.    Up to now classes are defined at compile time
    //ABSTRACT classes allow choices to be made at RUN TIME.   In this case
    //VEHICLE is a broad category which could include cars, motorcycles, airplances,
    //,boats, at RUNTIME the user can select one of these VARIATIONS and
    //the program can at RUNTIME create an INSTANCE that wasn't part of the
    //ORIGINAL source code.   The resulting DERIVED class MUST provide,
    //"fill in" the implementation details
    {
        //Fields

        //Properties
        public int Year { get; set; } = 2012;
        public string Make { get; set; } = "Toyota";
        public string Model { get; set; } = "Rav4";


        //DriveAbstract is a STUBBED out method.   Note the ";" and NO scope
        //MUST use the OVERRIDE keyword when implementing ( "Abstract"  in "DriveAbstract" NOT required in the name itself only here for exercise purposes)
        public abstract void DriveAbstract(); //This MUST be IMPLEMENTED in derived classes


        //VIRTUAL keyword makes this OPTIONAL to implement (not required to the name itself)
        //MUST use the OVERRIDE keyword IF you implement ( "Virtual" in "DriveVirtual" NOT required in the name itself only here for exercise purposes)
        public virtual void DriveVirtual() //It is OPTIONAL
        {
            Console.WriteLine("Would you like a Virtual test drive? ");
            Console.WriteLine("-------------------\n");
        }

    }//Vehicle
}//namespace
