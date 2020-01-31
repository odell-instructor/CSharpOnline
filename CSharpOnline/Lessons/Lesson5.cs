using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpOnline.Lessons
{
    /*This class goes over Value Types
     Lesson 5 - Value Types*/
    class Lesson5
    {

        // Integral - Signed

        // range -128 to 127
        sbyte _mySByteValue = 2;

        // range -32,768 to 32,767
        short _myShortValue = 6;

        // range -2,147,483,648 to 2,147,483,647
        protected int _myIntValue = 25000;

        // range -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807
        internal long _myLongValue = 12345789L;

        // Integral - Unsigned

        // range 0 - 255
        byte _myByteValue = 4;

        // range 0 - 65,535
        ushort _myUShortValue = 42;

        // range 0 - 4,294,967,295
        uint _myUIntValue = 4532U;

        // range 0 - 18,446,744,073,709,551,615
        ulong _myULongValue = 948372UL;

        // Real Numbers

        // range 3.4E +/- 38 (7 digits)
        float _myFloatValue = -123.6589F;

        // range 1.7E +- 308(15 digits)
        double _myDoubleValue = 12.34D;

        // range -7.9228E+24 to 7.9228E+24
        decimal _myDecimalValue = 13.23M;

        // Integral Literals
        // Decimal value of 26 = base10 value (0-9)
        int _val = 26;

        // Hexadecimal value of 26 = base16 value (0-9)(a-f)
        int _val2 = 0x1a;

        // Binary value of 26 = base2 value (0-1)
        int _val3 = 0b11010;

        // Notation & Underscores
        // Notation
        double _val4 = 6.26E-22;

        // Underscores (to separate numbers)
        long _myVal5 = 1_834_432L;
        double _myVal6 = 1_348.4;

        // Casting
        // Explicit cast where fractions are truncated and not rounded
        public void ConvertFloatToInt()
        {
            int converted = (int)_myFloatValue;
            Console.WriteLine(converted);
        }

        // Implicit cast which requires no direct casting
        public void LongFromInt()
        {
            long someValue = _myIntValue;
            Console.WriteLine(someValue);
        }

    } // end class
} // end namespace
