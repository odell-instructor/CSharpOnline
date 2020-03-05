using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDesignPatterns
{
    public class Vintage : AbstractRoadBike
    {
        public Vintage(IWheel wheel, BikeColor color) 
            : base(wheel, color) {    }

        public Vintage(IWheel wheel)
            : this(wheel, BikeColor.Green) { }

        public override decimal Price
        {
            get { return 600.00m; }
        }

    } // end class
} // end Namespace
