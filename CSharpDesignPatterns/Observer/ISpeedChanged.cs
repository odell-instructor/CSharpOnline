using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDesignPatterns
{
    public interface ISpeedChanged
    {
        void ValueHasChanged(object sender, EventArgs args);
    } // end interface
} // end namespace
