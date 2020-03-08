using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDesignPatterns
{
    public class MountainBikeRange
    {
        private IBicycle[] bicycles;

        public MountainBikeRange()
        {
            bicycles = new IBicycle[6];

            // Define the range of Mountain Bikes available
            bicycles[0] = new CrossCountry(new WideWheel(24));
            bicycles[1] = new CrossCountry(new WideWheel(26));
            bicycles[2] = new CrossCountry(new WideWheel(27), BikeColor.Chrome);
            bicycles[3] = new Downhill(new WideWheel(22));
            bicycles[4] = new Downhill(new WideWheel(24));
            bicycles[5] = new Downhill(new WideWheel(26), BikeColor.Black);
        }

        public IBicycle[] Range
        {
            get { return bicycles; }
        }

        public IEnumerator<IBicycle> GetEnumerator()
        {
            return ((IEnumerable<IBicycle>)bicycles).GetEnumerator();
        }

    } // end class
} // end namespace
