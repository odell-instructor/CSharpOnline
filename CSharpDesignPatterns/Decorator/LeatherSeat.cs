using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDesignPatterns
{
    public class LeatherSeat : AbstractBikeOption
    {
        public LeatherSeat(IBicycle bicycle) 
            :base(bicycle) { }

        public override decimal Price
        {
            get { return decoratedBike.Price + 40.00m; }
        }

    } // end class
} // end namespace
