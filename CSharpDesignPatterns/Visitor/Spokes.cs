using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDesignPatterns
{
    public class Spokes : IVisitable
    {
        public void AcceptVisitor(IWheelVisitor vistor)
        {
            vistor.Visit(this);
        }
    } // end class
} // end space
