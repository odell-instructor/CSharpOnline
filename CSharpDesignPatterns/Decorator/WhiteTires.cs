using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDesignPatterns
{
    public class WhiteTires : AbstractBikeOption
    {
        public WhiteTires(IBicycle bicycle)
            :base(bicycle) { }

        public override decimal Price
        {
            get { return decoratedBike.Price + 80.00m; }
        }

    } // end class
} // end namespace
