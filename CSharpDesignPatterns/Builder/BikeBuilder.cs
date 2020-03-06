using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDesignPatterns
{
    public abstract class BikeBuilder
    {
        public abstract IBicycle Bicycle { get; }

        public virtual void BuildStreetTires() { }
        public virtual void BuildWideTires() { }

        public abstract void BuildHandlebars();

    } // end class
} // end namespace
