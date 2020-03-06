using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDesignPatterns
{
    public class GoldFrame : AbstractBikeOption
    {
        public GoldFrame(IBicycle bicycle)
            :base(bicycle) { }

        public override decimal Price
        {
            get { return decoratedBike.Price + 300.00m; }
        }

        public override string ToString()
        {
            return this.GetType().Name + " Bicycle Color is Gold and costs $" + Price;
        }

    } // end class
} // end namespace
