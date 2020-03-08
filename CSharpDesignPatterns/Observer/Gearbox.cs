using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDesignPatterns
{
    public class Gearbox : ISpeedChanged
    {
        public Gearbox(Speedometer speed)
        {
            speed.ValueChanged += ValueHasChanged;
        }

        public void ValueHasChanged(object sender, EventArgs args)
        {
            Speedometer mySpeed = (Speedometer)sender;
            if(mySpeed.CurrentSpeed <= 10)
            {
                Console.WriteLine("Now in easy gear");
            } else if(mySpeed.CurrentSpeed <= 20)
            {
                Console.WriteLine("Now in 2nd gear");
            } else if(mySpeed.CurrentSpeed <= 25)
            {
                Console.WriteLine("Now in 3rd gear");
            } else if(mySpeed.CurrentSpeed <= 30)
            {
                Console.WriteLine("Now in 4th gear");
            }
        }

    } // end class
} // end namespace
