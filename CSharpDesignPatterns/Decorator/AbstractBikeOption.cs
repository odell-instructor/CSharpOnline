using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDesignPatterns
{
    public abstract class AbstractBikeOption : AbstractBike
    {
        protected internal IBicycle decoratedBike;

        public AbstractBikeOption(IBicycle bicycle)
            :base(bicycle.Wheel, BikeColor.Black)
        {
            this.decoratedBike = bicycle;
        }

    } // end class
} // end namespace
