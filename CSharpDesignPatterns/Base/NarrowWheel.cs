using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDesignPatterns
{
    public class NarrowWheel : AbstractWheel
    {
        public NarrowWheel(int size) 
            : base (size, false)
        {

        }
    } // end class
} // end namespace
