using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpOnline.Lessons
{
    /*This class goes over Strings & More
     Lesson 6 - String & More */
    class Lesson6
    {

        string _myString = "Hello World";

        // Trim
        public void MyTrimExample()
        {
            string myStr = " Space ";
            // Before trim
            Console.WriteLine(myStr);
            // trim
            string mytrim = myStr.Trim();
            // After trim
            Console.WriteLine(mytrim);
        }

        // Equals
        public void MyEqualsExample()
        {
            bool isExampleEqual = _myString.Equals("World");
            Console.WriteLine(isExampleEqual);
        }

        // ToUpper & ToLower
        public void MyLowerUpperExample()
        {
            // Nested Method - Method called through another method
            Console.WriteLine(_myString.ToLower());
            Console.WriteLine(_myString.ToUpper());
        }

        // Length
        public void MyStringLength()
        {
            Console.WriteLine(_myString.Length);
        }

        // Concatenation - with 2 parameters
        public void MyJoinedStrings(string value1, string value2)
        {
            Console.WriteLine(value1 + value2);
        }

        // String Builder - with 2 parameters, return string
        public string MyStringBuilder(string food, int amount)
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("My favorite food is ");
            builder.Append(food).Append(" and I ate ")
                .Append(amount).Append(" plates of it.");
            // returns the value out of the method
            return builder.ToString(); 
        }

        // Char - single quote
        public void MyExampleChar()
        {
            char myChar = 't';
            char myOther = '\u00A7';
            char copyright = '\u00A9';
            Console.WriteLine(myOther + " " + copyright);
            Console.WriteLine(myChar);
        }

        // Escape Sequence
        public string MyEscapeExample()
        {
            return "That\'s a cool toy. \tCan I\n play with it?";
        }

        public void MyPlaceHolderExample(string game, string type)
        {
            Console.WriteLine("My favorite game {0} is a {1}", game, type);
        }

    } // end class
} // end namespace
