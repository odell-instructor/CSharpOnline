using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpOnline.Lessons
{
    /*This class goes over lesson 10 content
     Constructors */
    public class Lesson10
    {
        public Lesson10(int value, string type)
        {
            Console.WriteLine("This {0} type and {1} value are from another constructor", type, value);
        }

        public Lesson10(int value)
        {
            Console.WriteLine("This {0} value came from a different constructor", value);
        }

        public Lesson10()
        {
            Console.WriteLine("My Default Constructor");
        }

        public void MyBasicRef(ref int able, int beta)
        {
            able += 6;
            beta += 5;

            Console.WriteLine("Able = {0} , Beta = {1}", able, beta);
        }

        public void MyBasicOut(string name, out string firstname, out string lastname)
        {
            int myIndex = name.IndexOf(' ');
            firstname = name.Substring(0, myIndex);
            lastname = name.Substring(myIndex + 1);
        }

    } // end class
} // end namespace
