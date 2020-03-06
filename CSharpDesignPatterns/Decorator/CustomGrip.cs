using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDesignPatterns
{
    public class CustomGrip : AbstractBikeOption
    {
        public CustomGrip(IBicycle bicycle)
            :base(bicycle)  {     }

        public override decimal Price
        {
            get { return decoratedBike.Price + 20.00m; }
        }

    } // end class
} // end namespace
