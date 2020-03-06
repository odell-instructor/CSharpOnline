using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDesignPatterns
{
    public class Registration
    {
        private IBicycle _bicycle;

        public Registration(IBicycle bicycle)
        {
            this._bicycle = bicycle;
        }

        public void AllocateBikeSerial()
        {
            SerialNumberGenerator serial = SerialNumberGenerator.Instance;
            Console.WriteLine("Allocating Bike number {0} ", serial.NextOtherSerial);
        }


    } // end class
} // end namespace
