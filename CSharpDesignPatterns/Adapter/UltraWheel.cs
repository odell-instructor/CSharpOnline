using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDesignPatterns
{
    public class UltraWheel
    {
        private int _size;

        public UltraWheel(int size)
        {
            this._size = size;
        }

        public int WheelSize
        {
            get { return _size; }
        }

        public override string ToString()
        {
            return "ULTRA WHEEL " + _size;
        }

    } // end class
} // end namespace
