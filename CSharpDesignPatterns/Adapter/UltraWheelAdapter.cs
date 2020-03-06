using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDesignPatterns
{
    public class UltraWheelAdapter : AbstractWheel
    {
        public UltraWheelAdapter(UltraWheel ultraWheel) 
            :base (ultraWheel.WheelSize, false)
        {

        }

    } // end class
} // end namespace
