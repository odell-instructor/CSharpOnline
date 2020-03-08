using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDesignPatterns
{
    public class SpeedMonitor : ISpeedChanged
    {
        public const int SpeedAlert = 30;

        public SpeedMonitor(Speedometer speed)
        {
            speed.ValueChanged += ValueHasChanged;
        }

        public void ValueHasChanged(object sender, EventArgs args)
        {
            Speedometer mySpeed = (Speedometer)sender;

            if(mySpeed.CurrentSpeed > SpeedAlert)
            {
                Console.WriteLine("** ALERT ** Riding too fast! ({0})", mySpeed.CurrentSpeed);
            } else
            {
                Console.WriteLine("... nice and steady ... {0}", mySpeed.CurrentSpeed);
            }
        }

    } // end class
} // end namespace
