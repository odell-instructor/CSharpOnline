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

        void CleanFrame();
        void AirTires();
        void TestRide();

    } // end interface
} // end namespace
