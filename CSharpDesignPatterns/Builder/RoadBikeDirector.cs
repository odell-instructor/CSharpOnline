using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDesignPatterns
{
    public class RoadBikeDirector : BikeDirector
    {
        public override IBicycle Build(BikeBuilder builder)
        {
            builder.BuildHandlebars();
            builder.BuildStreetTires();
            return builder.Bicycle;
        }
    } // end class
} // end namespace
