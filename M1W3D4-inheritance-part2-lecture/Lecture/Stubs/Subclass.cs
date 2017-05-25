using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture.Stubs
{
    // Subclass inherits from the AbstractClass
    // Subclass implements the ISkeletonInterface
    public class Subclass : AbstractClass, ISkeletonInterface
    {
        // Subclass must provide an implementation
        // of AbstractMethod because it is defined as "abstract" in the superclass
        public override string AbstractMethod(int parameter1)
        {
            throw new NotImplementedException();
        }

        // Subclass must provide an implementation
        // of SkeletonMethod because it implements the ISkeletonInterface
        public void SkeletonMethod()
        {
            throw new NotImplementedException();
        }

        // Subclass must provide an implementation
        // of SkeletonMethod because it implements the ISkeletonInterface
        public bool SkeletonMethod2(int parameter)
        {
            throw new NotImplementedException();
        }
    }
}
