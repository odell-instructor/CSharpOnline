using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDesignPatterns
{
    public class Touring : AbstractRoadBike
    {
        public Touring(IWheel wheel, BikeColor color)
            : base(wheel, color) {    }

        public Touring(IWheel wheel)
            : this(wheel, BikeColor.Green) {    }

        public override decimal Price
        {
            get { return 570.00m; }
        }

    } // end class
} // end namespace
