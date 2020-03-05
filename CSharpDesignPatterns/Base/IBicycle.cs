using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDesignPatterns
{
    public interface IBicycle
    {
        IWheel Wheel { get; }
        BikeColor ColorType { get; }
        decimal Price { get; }

        void Paint(BikeColor color);

    } // end interface
} // end namespace
