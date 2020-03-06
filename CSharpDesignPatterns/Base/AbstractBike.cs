using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDesignPatterns
{
    public abstract class AbstractBike : IBicycle
    {
        public virtual IWheel Wheel { get; private set; }
        public BikeColor ColorType { get; private set; }
        public abstract decimal Price { get; }

        public AbstractBike(IWheel wheel, BikeColor color)
        {
            this.Wheel = wheel;
            ColorType = color;
        }

        public virtual void Paint(BikeColor color)
        {
            this.ColorType = color;
        }

        public virtual void CleanFrame()
        {
            Console.WriteLine("Cleaning Frame....");
        }

        public virtual void AirTires()
        {
            Console.WriteLine("Airing up Tires....");
        }

        public virtual void TestRide()
        {
            Console.WriteLine("Taking bike for a test ride....");
        }

        public override string ToString()
        {
            return this.GetType().Name + " Bicycle has a " + Wheel +
                " and the Color is " + ColorType + " and it costs $" + Price;
        }

    } // end class
} // end namespace
