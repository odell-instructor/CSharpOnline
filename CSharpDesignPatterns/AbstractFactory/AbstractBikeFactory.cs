using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDesignPatterns
{
    public abstract class AbstractBikeFactory
    {
        public abstract IBikeFrame CreateBikeFrame();
        public abstract IBikeSeat CreateBikeSeat();
    } // end class
} // end namespace
