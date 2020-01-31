using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpOnline.Lessons
{
    public class Lesson12Child : Lesson12
    {

        public void BasicChildMethod()
        {
            Console.WriteLine("This is from a child class. What follows is protected");
            BasicProtectedMethod();
            BasicPrivateProtectedMethod();
        }

    } // end class
} // end namespace
