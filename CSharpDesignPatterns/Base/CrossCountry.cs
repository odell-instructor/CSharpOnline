using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDesignPatterns
{
    public class CrossCountry : AbstractMountainBike
    {
        public CrossCountry(IWheel wheel, BikeColor color) 
            : base(wheel, color) {     }

        public CrossCountry(IWheel wheel) 
            : this(wheel, BikeColor.Blue) {  }

        public override decimal Price
        {
            get { return 850.00m; }
        }

    } // end class
} // end namespace
