using InheritanceLecture.Stubs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Namespace Definition
// Uppercase and aligned with a module or general purpose it provides
// Seperated by Periods like TechElevator.Classes
namespace ProjectNamespace
{
    // Class declaration
    // Naming Convention: Singular, PascalCase
    // The SkeletonClass inherits from BaseClass
    public class SkeletonClass : BaseClass
    {
        // Field aka class variable
        //  - marked const and the value cannot be changed
        //  - we need to know the value ahead of time
        private const int x = 25;

        // Field aka class variable
        //  - marked readonly, the value is only able to be assigned once in the constructor
        //  - works like a constant, cannot be changed once after the constructor
        //      but we can assign an unknown value thru a variable
        private readonly int y;


        ///////////////
        // CONSTRUCTORS
        ///////////////
        // Default Constructor (no arguments)
        // Notes: 
        //  - Must match class name
        //  - Does not return anything
        //  - Also called the empty constructor
        public SkeletonClass()
        {
            y = 5; //assign some arbitary value to readonly field y
        }

        // Constructor
        //  - Must match class name
        //  - Still does not return anything
        //  - Must be different by taking different parameters        
        public SkeletonClass(string requiredVariableValue)
        {
            privateVariable = requiredVariableValue;
        }




        // Field aka class variable
        //  - should be declared private
        //  - private means that it is only accessible from within this class        
        //  - follows camelCase naming convention
        private string privateVariable;

        // Property to access private field
        //  - public means it is accessible from outside of this class anywhere an 
        //      instance is held
        //  - Controls access to private variable
        //  - Pascal casing naming convention and matches the private field it works with
        //  - get { } returns the private field
        //  - set { } sets the private field value & validates the data is acceptable
        public string PublicProperty
        {
            get { return privateVariable; }
            set { privateVariable = value; }
        }



        // Derived (aka calculated) Property to return a value conditionally 
        // based on a private variable value
        // - Doesn't have its own private (backing) variable
        // - Pascal casing naming convention
        // - get { } returns value
        // - no set { }        
        public string DerivedPublicProperty
        {
            get
            {
                if (privateVariable == "C#")
                {
                    return "C# is the best";
                }
                else
                {
                    return "Nothing is better than C#";
                }
            }
        }


        

        ///////////////
        // INSTANCE METHODS
        ///////////////
        // Public Method
        //  - methods are named with verbs (i.e. GetSomething, CalculateSomething, DoSomething, AddSomething)
        //  - all methods have a return statement that ends it
        //  - It must return whatever type is defined in the method signature
        //  - void requires us just to return; (it means nothing)
        //  - methods control access to class variables - "Fields" 
        public void MethodDoSomething()
        {
            return;
        }


        // Public Method 2
        //  - additional public method
        public int MethodDoSomethingElse()
        {
            return 0;
        }

        ////////////////////
        // INHERITED METHODS
        ////////////////////
        // Override keyword indicates that this method is going to override the
        // behavior defined in the parent/base class.
        // - It must have the same signature (access type, return type, name, and parameters) as 
        //   the definition from the base class.
        public override void OveridableMethod()
        {
            // Base is used to call the specific implementation 
            // defined in the base class.
            base.OveridableMethod();
        }


        ////////////////////
        // STATIC METHODS
        ////////////////////
        // Public Static Method
        //  - Static methods belong to the class. An "instance" is not required to use them.
        //  - Static methods cannot access instance members (e.g. properties or methods).
        public static void DoSomethingStatic()
        {
            //If we tried to reference any instance methods
            //we would get a compiler error.

            //Static methods are good for utility functions when you don't
            //need to modify the state of an objecct instance
        }       
    }
}
