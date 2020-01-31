using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpOnline.Lessons
{
    /*
     This class goes over Access Modifiers
     Lesson 12.
         */
    public class Lesson12
    {

        private void BasicPrivateMethod()
        {
            Console.WriteLine("This is a private method.");
        }

        public void BasicPublicMethod()
        {
            Console.WriteLine("This is a public method calling a private method");
            // Will call private method
            BasicPrivateMethod();
            Lesson5 myLesson5 = new Lesson5();
            myLesson5._myLongValue = 985632741L;
            Console.WriteLine("This value {0} is from lesson 5 using internal modifier.", myLesson5._myLongValue);         

        }

        protected void BasicProtectedMethod()
        {
            Console.WriteLine("This is a protected method");
        }

        private protected void BasicPrivateProtectedMethod()
        {
            Console.WriteLine("This is a private protected method");
        }

        protected internal void BasicProtectedInternalMethod()
        {
            Console.WriteLine("This is a protected internal method");
        }

    } // End class
} // End Namespace
