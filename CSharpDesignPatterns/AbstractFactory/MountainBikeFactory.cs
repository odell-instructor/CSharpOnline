using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDesignPatterns
{
    public class MountainBikeFactory : AbstractBikeFactory
    {
        public override IBikeFrame CreateBikeFrame()
        {
            return new MountainBikeFrame();
        }

        public override IBikeSeat CreateBikeSeat()
        {
            return new MountainBikeSeat();
        }

    } // end class
} // end namespace
