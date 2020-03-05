using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDesignPatterns
{
    public abstract class AbstractMountainBike : AbstractBike
    {
        public AbstractMountainBike(IWheel wheel, BikeColor color)
            : base(wheel, color) {  }

        public AbstractMountainBike(IWheel wheel)
            : this(wheel, BikeColor.Black) { }

        public override decimal Price 
        { 
            get { return 740.00m;  } 
        }

    } // end class
} // end namespace
