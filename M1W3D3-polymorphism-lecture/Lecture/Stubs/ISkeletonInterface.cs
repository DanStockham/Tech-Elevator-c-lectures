using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture.Stubs
{
    // Public Interface
    // - Classes "implement" an interface.
    // - Interfaces are not instantiated.
    public interface ISkeletonInterface
    {
        // The ISkeletonInterface specifies that any class implementing it
        // must provide an implementation for a void SkeletonMethod()
        // - interface methods don't have an implementation in the interface
        // - all interface methods are inherently public
        void SkeletonMethod();

        // The ISkeletonInterface specifies that any class implementing it
        // must provide an implementation for a bool SkeletonMethod2()
        // - interface methods don't have an implementation in the interface
        // - all interface methods are inherently public
        bool SkeletonMethod2(int parameter);
    }
}
