using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDesignPatterns
{
    public class WheelInventory : IWheelVisitor
    {
        private int _spokesCount;
        private int _bearingCount;

        public WheelInventory()
        {
            _spokesCount = 29;
            _bearingCount = 1;
        }
        public void Visit(IWheel wheel)
        {
            Console.WriteLine("The wheel has {0} spokes and {1} bearings",
                _spokesCount, _bearingCount);
        }
        public void Visit(Spokes spokes)
        {
            _spokesCount++;
        }
        public void Visit(Bearings bearings)
        {
            _bearingCount++;
        }
    } // end class
} // end namespace
