using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDesignPatterns
{
    public abstract class AbstractWheel : IWheel
    {
        private int _size;
        private bool _wide;

        public AbstractWheel(int size, bool wide)
        {
            this._size = size;
            this._wide = wide;
        }

        public virtual int Size
        {
            get { return _size; }
        }

        public virtual bool Wide
        {
            get { return _wide; }
        }

        public override string ToString()
        {
            return this.GetType().Name + " with a wheel size of " + _size + " inches";
        }

    } // end class
} // end namespace
