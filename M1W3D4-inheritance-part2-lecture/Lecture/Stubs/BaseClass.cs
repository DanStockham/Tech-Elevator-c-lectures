using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceLecture.Stubs
{
    // A base class is defined 
    // - The base class is inherited by other classes, in this case the SkeletonClass
    
    public class BaseClass
    {
        // Private BaseClass Variables
        // - Even though a class may inherit from Baseclass, it does not get 
        // - access to its private variables

        private string baseClassVariable;

        // Public Properties
        // - All protected and public properties or methods are accessible
        // - to any subclass
        public string BaseClassProperty
        {
            get { return baseClassVariable; }
        }

        // A method marked virtual
        // is capable of being overridden by a subclass.
        // If it is not marked virtual then all subclasses will inherit the behavior without
        // the ability to override and create their own specific implementation
        public virtual void OveridableMethod()
        {

        }
    }
}
