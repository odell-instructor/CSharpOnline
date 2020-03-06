using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDesignPatterns
{
    public class SerialNumberGenerator
    {
        private static volatile SerialNumberGenerator instance;
        public static object synchronizationRoot = new object();
        private int _count = 12345;

        public static SerialNumberGenerator Instance
        {
            get
            {
                if(instance == null)
                {
                    lock(synchronizationRoot)
                    {
                        if(instance == null)
                        {
                            instance = new SerialNumberGenerator();
                        }
                    }
                }
                return instance;
            }
        }

        private SerialNumberGenerator() { }

        public int NextSerial()
        {
            return ++_count;
        }

        public int NextOtherSerial
        {
            get { return ++_count; }
        }

    } // end class
} // end namespace
