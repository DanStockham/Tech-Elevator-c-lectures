using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture.Stubs
{
    // An Abstract Class is one which cannot be instantiated
    // - It is marked abstract in the class definition
    // - It can contain implemented methods (shared with all subclasses)
    // - It can contain virtual methods (for any subclass to override)
    // - It also contains abstract methods which each subclass must implement
    public abstract class AbstractClass
    {
        // Property
        private int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        // Abstract Methods
        // - They require a return type, name and parameters
        // - Marked abstract
        // - Ends with a semi-colon ; and has no implementation
        // - Any subclass that is not abstract must implement it
        public abstract string AbstractMethod(int parameter1);


    }
}
