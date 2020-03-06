using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDesignPatterns
{
    public class MountainBikeDirector : BikeDirector
    {
        public override IBicycle Build(BikeBuilder builder)
        {
            builder.BuildHandlebars();
            builder.BuildWideTires();
            return builder.Bicycle;
        }
    } // end class
} // end namespace
