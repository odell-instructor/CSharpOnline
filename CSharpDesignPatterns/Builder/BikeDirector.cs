using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDesignPatterns
{
    public abstract class BikeDirector
    {
        public abstract IBicycle Build(BikeBuilder builder);
    } // end class
} // end namespace
