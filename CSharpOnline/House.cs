using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpOnline
{
    class House
    {
        // Attributes of the class
        int _windowSize;
        string _foundation;
        string _roofType;
        string _doorColor;

        /*
         This method will print out
         about what the door does.
             */
        public virtual void DoorOpenClose()
        {
            Console.WriteLine("The door opens");
        }
        public void DoorOpenClose(string doorColor)
        {
            Console.WriteLine("My door color is {0}", doorColor);
        }

    }
}
