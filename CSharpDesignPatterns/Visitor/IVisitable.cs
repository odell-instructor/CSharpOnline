using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDesignPatterns
{
    public interface IVisitable
    {
        void AcceptVisitor(IWheelVisitor visitor);
    } // end interface
} // end class
