using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDesignPatterns
{
    public class WheelDiagnostics : IWheelVisitor
    {
        public void Visit(IWheel wheel)
        {
            Console.WriteLine("Diagnosing the Wheels");
        }

        public void Visit(Spokes spokes)
        {
            Console.WriteLine("Diganosing the Spokes");
        }

        public void Visit(Bearings bearings)
        {
            Console.WriteLine("Diagnosing the Bearings ");
        }
    } // end class
} // end namespace
