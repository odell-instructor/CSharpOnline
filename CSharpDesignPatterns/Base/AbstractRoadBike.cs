using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDesignPatterns
{
    public abstract class AbstractRoadBike : AbstractBike
    {
        public AbstractRoadBike(IWheel wheel, BikeColor color)
            : base(wheel, color) { }

        public AbstractRoadBike(IWheel wheel)
            : this(wheel, BikeColor.Chrome) { }

        public override decimal Price
        {
            get { return 540.00m; }
        }

    } // end class
} // end namespace
